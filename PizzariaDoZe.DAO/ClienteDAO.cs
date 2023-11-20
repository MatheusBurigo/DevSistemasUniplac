using PizzariaDoZe.DAO.utils;
using System.Data;
using System.Data.Common;
using static PizzariaDoZe.DAO.Interfaces;

namespace PizzariaDoZe.DAO;
public class ClienteDAO
{
    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }
    public ClienteDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }

    public int Inserir(Cliente cliente)
    {
        ConnectionInterface connection = Funcoes.NewConnection(factory, StringConexao);

        //Adiciona parâmetro (@campo e valor)
        var nome = connection.comando.CreateParameter(); nome.ParameterName = "@nome";
        nome.Value = cliente.Nome; connection.comando.Parameters.Add(nome);

        var cpf = connection.comando.CreateParameter(); cpf.ParameterName = "@cpf";
        cpf.Value = cliente.Cpf; connection.comando.Parameters.Add(cpf);

        var telefone = connection.comando.CreateParameter(); telefone.ParameterName = "@telefone";
        telefone.Value = cliente.Telefone; connection.comando.Parameters.Add(telefone);

        var email = connection.comando.CreateParameter(); email.ParameterName = "@email";
        email.Value = cliente.Email; connection.comando.Parameters.Add(email);

        var endereco_id = connection.comando.CreateParameter(); endereco_id.ParameterName = "@endereco_id";
        endereco_id.Value = cliente.EnderecoId; connection.comando.Parameters.Add(endereco_id);

        var numero = connection.comando.CreateParameter(); numero.ParameterName = "@numero";
        numero.Value = cliente.Numero; connection.comando.Parameters.Add(numero);

        var complemento = connection.comando.CreateParameter(); complemento.ParameterName = "@complemento";
        complemento.Value = cliente.Complemento; connection.comando.Parameters.Add(complemento);

        connection.conexao.Open();

        //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
        string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";

        //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
        connection.comando.CommandText = @"INSERT INTO tb_clientes (nome, cpf, telefone, email, endereco_id, numero, complemento)
        VALUES(@nome, @cpf, @telefone, @email, @endereco_id, @numero, @complemento);" + auxSQL_ID;

        //executa o comando no banco de dados e captura o ID gerado
        var IdGerado = connection.comando.ExecuteScalar();

        return Convert.ToInt32(IdGerado);
    }

    public DataTable Buscar(Cliente cliente)
    {
        ConnectionInterface connection = Funcoes.NewConnection(factory, StringConexao);

        string auxSqlFiltro = "";
        if (cliente.Id > 0)
        {
            auxSqlFiltro = "WHERE cc.id_cliente = " + cliente.Id + " ";
        }
        else if (cliente.Nome.Length > 0)
        {
            auxSqlFiltro = "WHERE cc.nome_cliente like '%" + cliente.Nome + "%' ";
        }

        connection.conexao.Open();

        connection.comando.CommandText = @" " +
        "SELECT cc.id_cliente AS ID, cc.nome_cliente AS Nome, cc.cpf AS CPF, cc.telefone AS Telefone, cc.email AS 'E-mail', " +
        "e.id_endereco AS ID, e.cep AS CEP, e.logradouro AS Logradouro, e.bairro AS Bairro, " +
        "c.id_cidade AS IDCidade, c.nome_cidade AS Cidade, " +
        "u.id_uf AS IDUF, u.nome_uf AS UF, " +
        "p.id_pais AS IDPais, p.nome_pais AS Pais, " +
        "cc.numero AS Número, cc.complemento AS Complemento " +
        "FROM tb_clientes AS cc " +
        "INNER JOIN tb_enderecos AS e ON e.id_endereco = cc.endereco_id " +
        "INNER JOIN cad_cidades AS c ON c.id_cidade = e.cidade_id " +
        "INNER JOIN cad_uf AS u ON u.id_uf = c.uf_id " +
        "INNER JOIN cad_paises AS p ON p.id_pais = u.pais_id " +
        auxSqlFiltro +
        "ORDER BY cc.nome_cliente;";

        //Executa o script na conexão e retorna as linhas afetadas.
        var sdr = connection.comando.ExecuteReader();
        DataTable linhas = new();
        linhas.Load(sdr);

        return linhas;
    }

    public void Editar(Cliente cliente)
    {
        ConnectionInterface connection = Funcoes.NewConnection(factory, StringConexao);

        var id = connection.comando.CreateParameter(); id.ParameterName = "@id"; id.Value = cliente.Id; connection.comando.Parameters.Add(id);
        var nome = connection.comando.CreateParameter(); nome.ParameterName = "@nome"; nome.Value = cliente.Nome; connection.comando.Parameters.Add(nome);
        var cpf = connection.comando.CreateParameter(); cpf.ParameterName = "@cpf"; cpf.Value = cliente.Cpf; connection.comando.Parameters.Add(cpf);
        var telefone = connection.comando.CreateParameter(); telefone.ParameterName = "@telefone"; telefone.Value = cliente.Telefone; connection.comando.Parameters.Add(telefone);
        var email = connection.comando.CreateParameter(); email.ParameterName = "@email"; email.Value = cliente.Email; connection.comando.Parameters.Add(email);
        var endereco_id = connection.comando.CreateParameter(); endereco_id.ParameterName = "@endereco_id"; endereco_id.Value = cliente.EnderecoId; connection.comando.Parameters.Add(endereco_id);
        var numero = connection.comando.CreateParameter(); numero.ParameterName = "@numero"; numero.Value = cliente.Numero; connection.comando.Parameters.Add(numero);
        var complemento = connection.comando.CreateParameter(); complemento.ParameterName = "@complemento"; complemento.Value = cliente.Complemento; connection.comando.Parameters.Add(complemento);

        connection.conexao.Open();

        //realiza o UPDATE
        connection.comando.CommandText = @"UPDATE tb_clientes SET " +
            "nome = @nome, " +
            "cpf = @cpf, " +
            "telefone = @telefone, " +
            "email = @email, " +
            "endereco_id = @endereco_id, " +
            "numero = @numero, " +
            "complemento = @complemento " +
            "WHERE id_cliente = @id;";

        //executa o comando no banco de dados
        _ = connection.comando.ExecuteNonQuery();
    }

    public void Excluir(Cliente cliente)
    {
        ConnectionInterface connection = Funcoes.NewConnection(factory, StringConexao);

        var id = connection.comando.CreateParameter();
        id.ParameterName = "@id";
        id.Value = cliente.Id;
        connection.comando.Parameters.Add(id);

        connection.conexao.Open();

        //realiza o DELETE
        connection.comando.CommandText = @"DELETE FROM tb_clientes WHERE id_cliente = @id;";

        //executa o comando no banco de dados
        _ = connection.comando.ExecuteNonQuery();
    }
}