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
public class ValorDAO
{
    private readonly DbProviderFactory factory;
    private string Provider { get; set; }
    private string StringConexao { get; set; }
    public ValorDAO(string provider, string stringConexao)
    {
        Provider = provider;
        StringConexao = stringConexao;
        factory = DbProviderFactories.GetFactory(Provider);
    }
    public int Inserir(Valor valor)
    {
        ConnectionInterface connection = Funcoes.NewConnection(factory, StringConexao);

        //Adiciona parâmetro (@campo e valor)
        var tamanho = connection.comando.CreateParameter();
        tamanho.ParameterName = "@tamanho";
        tamanho.Value = valor.Tamanho;
        connection.comando.Parameters.Add(tamanho);

        var categoria = connection.comando.CreateParameter();
        categoria.ParameterName = "@categoria";
        categoria.Value = valor.Categoria;
        connection.comando.Parameters.Add(categoria);

        var valorPizza = connection.comando.CreateParameter();
        valorPizza.ParameterName = "@valorPizza";
        valorPizza.Value = valor.ValorPizza;
        connection.comando.Parameters.Add(valorPizza);

        var valorBorda = connection.comando.CreateParameter();
        valorBorda.ParameterName = "@valorBorda";
        valorBorda.Value = valor.ValorBorda;
        connection.comando.Parameters.Add(valorBorda);

        connection.conexao.Open();

        //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
        string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";

        //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
        connection.comando.CommandText = @"INSERT INTO tb_valor (tamanho, categoria, valor, valor_borda) " +
        "VALUES (@tamanho, @categoria, @valorPizza, @valorBorda);" + auxSQL_ID;

        //executa o comando no banco de dados e captura o ID gerado
        var IdSaborGerado = connection.comando.ExecuteScalar();
        return Convert.ToInt32(IdSaborGerado);
    }
    public DataTable Buscar(Valor valor)
    {
        ConnectionInterface connection = Funcoes.NewConnection(factory, StringConexao);

        //verifica se tem filtro e personaliza o SQL do filtro
        string auxSqlFiltro = "";
        if (valor.Id > 0)
        {
            auxSqlFiltro = "WHERE v.id_valor = " + valor.Id + " ";
        }

        connection.conexao.Open();

        connection.comando.CommandText = @" " +
        "SELECT id_valor AS ID, tamanho AS Tamanho, categoria AS Categoria, valor AS Valor, valor_borda AS 'Valor Borda' " +
        "FROM tb_valor AS v " +
        auxSqlFiltro +
        ";";

        //Executa o script na conexão e retorna as linhas afetadas.
        var sdr = connection.comando.ExecuteReader();
        DataTable linhas = new();

        linhas.Load(sdr);

        return linhas;
    }
    public void Editar(Valor valor)
    {
        ConnectionInterface connection = Funcoes.NewConnection(factory, StringConexao);

        //Adiciona parâmetro (@campo e valor)
        var id = connection.comando.CreateParameter(); id.ParameterName = "@id";
        id.Value = valor.Id; connection.comando.Parameters.Add(id);
        var tamanho = connection.comando.CreateParameter(); tamanho.ParameterName = "@tamanho";
        tamanho.Value = valor.Tamanho; connection.comando.Parameters.Add(tamanho);
        var categoria = connection.comando.CreateParameter(); categoria.ParameterName = "@categoria";
        categoria.Value = valor.Categoria; connection.comando.Parameters.Add(categoria);
        var valorPizza = connection.comando.CreateParameter(); valorPizza.ParameterName = "@valorPizza";
        valorPizza.Value = valor.ValorPizza; connection.comando.Parameters.Add(valorPizza);
        var valorBorda = connection.comando.CreateParameter(); valorBorda.ParameterName = "@valorBorda";
        valorBorda.Value = valor.ValorBorda; connection.comando.Parameters.Add(valorBorda);

        connection.conexao.Open();

        //realiza o UPDATE
        connection.comando.CommandText = @"" +
        "UPDATE tb_valor SET " +
        "tamanho = @tamanho, " +
        "categoria = @categoria, " +
        "valor = @valorPizza, " +
        "valor_borda = @valorBorda " +
        "WHERE id_valor = @id;";

        //executa o comando no banco de dados
        _ = connection.comando.ExecuteNonQuery();
    }
    public void Excluir(Valor valor)
    {
        ConnectionInterface connection = Funcoes.NewConnection(factory, StringConexao);

        //Adiciona parâmetro (@campo e valor)
        var id = connection.comando.CreateParameter();
        id.ParameterName = "@id";
        id.Value = valor.Id;
        connection.comando.Parameters.Add(id);

        connection.conexao.Open();

        //exclui
        connection.comando.CommandText = @"DELETE FROM tb_valor WHERE id_valor = @id;";
        _ = connection.comando.ExecuteNonQuery();
    }

}
