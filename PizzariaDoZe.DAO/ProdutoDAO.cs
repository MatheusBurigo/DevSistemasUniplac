using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzariaDoZe.DAO.utils;
using static PizzariaDoZe.DAO.Interfaces;

namespace PizzariaDoZe.DAO;
public class ProdutoDAO
{
    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }
    public ProdutoDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }
    public int Inserir(Produto produto)
    {
        ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

        //Adiciona parâmetro (@campo e valor)
        var descricao = connections.comando.CreateParameter(); descricao.ParameterName = "@descricao";
        descricao.Value = produto.Descricao; connections.comando.Parameters.Add(descricao);

        var valorProduto = connections.comando.CreateParameter(); valorProduto.ParameterName = "@valorProduto";
        valorProduto.Value = produto.Valor; connections.comando.Parameters.Add(valorProduto);

        var tipo = connections.comando.CreateParameter(); tipo.ParameterName = "@tipo";
        tipo.Value = produto.Tipo; connections.comando.Parameters.Add(tipo);

        var ml = connections.comando.CreateParameter(); ml.ParameterName = "@ml";
        ml.Value = produto.ML; connections.comando.Parameters.Add(ml);

        connections.conexao.Open();

        //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
        string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";

        //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
        connections.comando.CommandText = @"" +
        "INSERT INTO cad_produtos (descricao_produto, valor, tipo, medida_unitaria) " +
        "VALUES (@descricao, @valorProduto, @tipo, @ml);" +
        auxSQL_ID;

        //executa o comando no banco de dados e captura o ID gerado
        var IdSaborGerado = connections.comando.ExecuteScalar();
        return Convert.ToInt32(IdSaborGerado);
    }
    public DataTable Buscar(Produto produto)
    {
        ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

        //verifica se tem filtro e personaliza o SQL do filtro
        string auxSqlFiltro = "";
        if (produto.Id > 0)
        {
            auxSqlFiltro = "WHERE p.id_produto = " + produto.Id + " ";
        }
        else if (produto.Descricao.Length > 0)
        {
            auxSqlFiltro = "WHERE p.descricao_produto like '%" + produto.Descricao + "%' ";
        }

        connections.conexao.Open();

        connections.comando.CommandText = @" " +
        "SELECT id_produto AS ID, descricao_produto AS Descrição, valor AS Valor, tipo AS 'Tipo Produto', medida_unitaria AS ML " +
        "FROM cad_produtos AS p " +
        auxSqlFiltro +
        "ORDER BY p.descricao_produto;";

        //Executa o script na conexão e retorna as linhas afetadas.
        var sdr = connections.comando.ExecuteReader();
        DataTable linhas = new();
        linhas.Load(sdr);

        return linhas;
    }
    public void Editar(Produto produto)
    {
        ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

        //Adiciona parâmetro (@campo e valor)
        var id = connections.comando.CreateParameter(); id.ParameterName = "@id";
        id.Value = produto.Id; connections.comando.Parameters.Add(id);

        var descricao = connections.comando.CreateParameter(); descricao.ParameterName = "@descricao";
        descricao.Value = produto.Descricao; connections.comando.Parameters.Add(descricao);

        var valorProduto = connections.comando.CreateParameter(); valorProduto.ParameterName = "@valorProduto";
        valorProduto.Value = produto.Valor; connections.comando.Parameters.Add(valorProduto);

        var tipo = connections.comando.CreateParameter(); tipo.ParameterName = "@tipo";
        tipo.Value = produto.Tipo; connections.comando.Parameters.Add(tipo);

        var ml = connections.comando.CreateParameter(); ml.ParameterName = "@ml";
        ml.Value = produto.ML; connections.comando.Parameters.Add(ml);

        connections.conexao.Open();

        //realiza o UPDATE
        connections.comando.CommandText = @"" +
        "UPDATE cad_produtos SET " +
        "descricao_produto = @descricao, " +
        "valor = @valorProduto, " +
        "tipo = @tipo, " +
        "medida_unitaria = @ml " +
        "WHERE id_produto = @id;";

        //executa o comando no banco de dados
        _ = connections.comando.ExecuteNonQuery();
    }
    public void Excluir(Produto produto)
    {
        ConnectionInterface connections = Funcoes.NewConnection(factory, StringConexao);

        //Adiciona parâmetro (@campo e valor)
        var id = connections.comando.CreateParameter();
        id.ParameterName = "@id";
        id.Value = produto.Id;
        connections.comando.Parameters.Add(id);

        connections.conexao.Open();

        //exclui
        connections.comando.CommandText = @"DELETE FROM cad_produtos WHERE id_produto = @id;";
        _ = connections.comando.ExecuteNonQuery();
    }
}
