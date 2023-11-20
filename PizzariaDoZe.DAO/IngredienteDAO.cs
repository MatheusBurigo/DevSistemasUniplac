using PizzariaDoZe.DAO.utils;
using System.Data;
using System.Data.Common;
using static PizzariaDoZe.DAO.Interfaces;

namespace PizzariaDoZe.DAO;
public class IngredienteDAO
{

    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }

    public IngredienteDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }

    public void Inserir (Ingrediente ingrediente)
    {
        ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

        //Adiciona parâmetro (@campo e valor)
        var nome = connections.comando.CreateParameter();
        nome.ParameterName = "@nome";
        nome.Value = ingrediente.Nome;
        connections.comando.Parameters.Add(nome);
        connections.conexao.Open();
        connections.comando.CommandText = @"INSERT INTO cad_ingredientes(descricao_ingrediente) VALUES (@nome)";
        //Executa o script na conexão e retorna o número de linhas afetadas.
        connections.comando.ExecuteNonQuery();
        //using faz o Close() automático quando fecha o seu escopo
    }

    public DataTable Buscar (Ingrediente ingrediente, bool fetchAll)
    {
        ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

        //verifica se tem filtro e personaliza o SQL do filtro
        string auxSqlFiltro = "";
        if (!fetchAll)
        {
            if (ingrediente.Id > 0)
            {
                auxSqlFiltro = "WHERE i.id_ingrediente = " + ingrediente.Id + " ";
            }
            else if (ingrediente.Nome.Length > 0)
            {
                auxSqlFiltro = "WHERE i.descricao_ingrediente like '%" + ingrediente.Nome + "%' ";
            }
        }

        connections.conexao.Open();

        connections.comando.CommandText = @" " +
        "SELECT i.id_ingrediente AS ID, i.descricao_ingrediente AS Nome " +
        "FROM cad_ingredientes i " +
        auxSqlFiltro +
        "ORDER BY i.descricao_ingrediente;";
        //Executa o script na conexão e retorna as linhas afetadas.
        var sdr = connections.comando.ExecuteReader();
        DataTable linhas = new();
        linhas.Load(sdr);

        return linhas;
    }

    public void Editar(Ingrediente ingrediente)
    {
        ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

        //Adiciona parâmetro (@campo e valor)
        var id = connections.comando.CreateParameter();
        id.ParameterName = "@id";
        id.Value = ingrediente.Id;
        connections.comando.Parameters.Add(id);

        var nome = connections.comando.CreateParameter();
        nome.ParameterName = "@nome";
        nome.Value = ingrediente.Nome;
        connections.comando.Parameters.Add(nome);

        connections.conexao.Open();

        //realiza o UPDATE
        connections.comando.CommandText = @"UPDATE cad_ingredientes SET " +
        "descricao_ingrediente = @nome " +
        "WHERE id_ingrediente = @id;";
        //executa o comando no banco de dados

        _ = connections.comando.ExecuteNonQuery();
    }

    public void Excluir(Ingrediente ingrediente)
    {
        ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

        //Adiciona parâmetro (@campo e valor)
        var id = connections.comando.CreateParameter();
        id.ParameterName = "@id";
        id.Value = ingrediente.Id;
        connections.comando.Parameters.Add(id);

        connections.conexao.Open();

        //realiza o DELETE
        connections.comando.CommandText = @"DELETE FROM cad_ingredientes WHERE id_ingrediente = @id;";

        //executa o comando no banco de dados
        _ = connections.comando.ExecuteNonQuery();
    }
}
