﻿using PizzariaDoZe.DAO.utils;
using System.Data;
using System.Data.Common;
using static PizzariaDoZe.DAO.Interfaces;

namespace PizzariaDoZe.DAO
{
    public class SaborDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public SaborDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public int Inserir(Sabor sabor)
        {
            ConnectionInterface connection = Funcoes.NewConnection(factory, StringConexao);

            var descricao = connection.comando.CreateParameter(); descricao.ParameterName = "@descricao"; descricao.Value = sabor.Descricao; connection.comando.Parameters.Add(descricao);
            var foto = connection.comando.CreateParameter(); foto.ParameterName = "@foto"; foto.Value = sabor.Foto; connection.comando.Parameters.Add(foto);
            var categoria = connection.comando.CreateParameter(); categoria.ParameterName = "@categoria"; categoria.Value = sabor.Categoria; connection.comando.Parameters.Add(categoria);
            var tipo = connection.comando.CreateParameter(); tipo.ParameterName = "@tipo"; tipo.Value = sabor.Tipo; connection.comando.Parameters.Add(tipo);
            connection.conexao.Open();
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = connection.conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            connection.comando.Transaction = transacao;
            try
            {
                //ajusta o comando SQL para capturar o ID gerado tanto do MySQL como do SQLServer
                string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
                //realiza o INSERT e retorna o ID gerado, algo que vai ser necessário na sequencia
                connection.comando.CommandText = @"INSERT INTO tb_sabores (descricao_sabor, foto, categoria, tipo) VALUES (@descricao, @foto, @categoria, @tipo);" + auxSQL_ID;
                //executa o comando no banco de dados e captura o ID gerado
                var IdSaborGerado = connection.comando.ExecuteScalar();
                // realiza um loop para pegar todos os ingredientes selecionados
                foreach (Ingrediente auxIngrediente in sabor.SaborIngredientes)
                {
                    // salvar os ingredientes do sabor
                    connection.comando.CommandText = @"INSERT INTO itens_sabores(sabor_id, ingrediente_id) VALUES (" + Convert.ToInt32(IdSaborGerado) + "," + auxIngrediente.Id + ")";
                    //Executa o script na conexão e retorna o número de linhas afetadas.
                    var linhasRecebimentoComanda = connection.comando.ExecuteNonQuery();
                }
                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();
                return Convert.ToInt32(IdSaborGerado);
            }
            catch (Exception ex)
            {
                // Alguns dos comandos SQL acima gerou erro, dessa forma, todos os comandos serão desfeitos através do Rollback()
                transacao.Rollback();
                // retorna uma exceção para quem chamou a execução
                throw new Exception(ex.Message);
            }
        }

        public DataTable Buscar(Sabor sabor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro e personaliza o SQL do filtro
            string auxSqlFiltro = "";
            if (sabor.Id > 0)
            {
                auxSqlFiltro = "WHERE s.id_sabor = " + sabor.Id + " ";
            }
            else if (sabor.Descricao.Length > 0)
            {
                auxSqlFiltro = "WHERE s.descricao_sabor like '%" + sabor.Descricao + "%' ";
            }
            conexao.Open();
            //ajusta o comando SQL para listar os ingredientes separados por virgula, tanto no MySQL como do SQLServer
            string auxIngredientesPorVirgula = Provider.Contains("MySql") ? "GROUP_CONCAT(i.descricao_ingrediente SEPARATOR ', ')" : "STRING_AGG(i.descricao_ingrediente, ', ')";
            comando.CommandText = @" " +
            "SELECT s.id_sabor AS ID, s.descricao_sabor AS Nome, s.foto AS Foto, s.categoria AS Categoria, s.tipo AS Tipo " +
            ", (SELECT " + auxIngredientesPorVirgula + " FROM itens_sabores AS iss, cad_ingredientes i WHERE iss.sabor_id = s.id_sabor AND i.id_ingrediente = iss.ingrediente_id ) AS " +
            "Ingredientes " +
            "FROM tb_sabores AS s " +
            auxSqlFiltro +
            "ORDER BY s.descricao_sabor;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

        public void Editar(Sabor sabor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var id = comando.CreateParameter(); id.ParameterName = "@id"; id.Value = sabor.Id; comando.Parameters.Add(id);
            var descricao = comando.CreateParameter(); descricao.ParameterName = "@descricao"; descricao.Value = sabor.Descricao; comando.Parameters.Add(descricao);
            var foto = comando.CreateParameter(); foto.ParameterName = "@foto"; foto.Value = sabor.Foto; comando.Parameters.Add(foto);
            var categoria = comando.CreateParameter(); categoria.ParameterName = "@categoria"; categoria.Value = sabor.Categoria; comando.Parameters.Add(categoria);
            var tipo = comando.CreateParameter(); tipo.ParameterName = "@tipo"; tipo.Value = sabor.Tipo; comando.Parameters.Add(tipo);
            conexao.Open();
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //realiza o UPDATE
                comando.CommandText = @"UPDATE tb_sabores SET descricao_sabor = @descricao, foto = @foto, categoria = @categoria, tipo = @tipo WHERE id_sabor = @id;";
                //executa o comando no banco de dados e captura o ID gerado
                _ = comando.ExecuteNonQuery();
                //limpa todos os ingredientes do sabor
                comando.CommandText = @"DELETE FROM itens_sabores WHERE sabor_id = " + sabor.Id + ";";
                _ = comando.ExecuteNonQuery();
                // realiza um loop para adicionar os ingredientes do sabor
                foreach (Ingrediente auxIngrediente in sabor.SaborIngredientes)
                {
                    // salvar os ingredientes do sabor
                    comando.CommandText = @"INSERT INTO itens_sabores(sabor_id, ingrediente_id) VALUES (" + sabor.Id + "," + auxIngrediente.Id + ")";
                    //Executa o script na conexão
                    _ = comando.ExecuteNonQuery();
                }
                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();
            }
            catch (Exception ex)
            {
                // Alguns dos comandos SQL acima gerou erro, dessa forma, todos os comandos serão desfeitos através do Rollback()
                transacao.Rollback();
                // retorna uma exceção para quem chamou a execução
                throw new Exception(ex.Message);
            }
        }

        public DataTable BuscarItensSabor(Sabor sabor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
            conexao.Open();
            comando.CommandText = @" " +
            "SELECT i.id_ingrediente AS ID, i.descricao_ingrediente AS Nome " +
            "FROM cad_ingredientes AS i, itens_sabores AS iss " +
            "WHERE iss.sabor_id = " + sabor.Id + " AND iss.ingrediente_id = i.id_ingrediente " +
            "ORDER BY i.descricao_ingrediente;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

        public void Excluir(Sabor sabor)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var id = comando.CreateParameter();
            id.ParameterName = "@id";
            id.Value = sabor.Id;
            comando.Parameters.Add(id);
            conexao.Open();
            // Inicia o controle de Transação LOCAL
            DbTransaction transacao = conexao.BeginTransaction();
            // Associa o command com o controle de Transação
            comando.Transaction = transacao;
            try
            {
                //limpa todos os ingredientes do sabor
                comando.CommandText = @"DELETE FROM itens_sabores WHERE sabor_id = @id;";
                _ = comando.ExecuteNonQuery();
                //realiza o UPDATE
                comando.CommandText = @"DELETE FROM tb_sabores WHERE id_sabor = @id;";
                _ = comando.ExecuteNonQuery();
                // Como não ocorreu nenhum erro, confirma as transações através do Commit()
                transacao.Commit();
            }
            catch (Exception ex)
            {
                // Alguns dos comandos SQL acima gerou erro, dessa forma, todos os comandos serão desfeitos através do Rollback()
                transacao.Rollback();
                // retorna uma exceção para quem chamou a execução
                throw new Exception(ex.Message);
            }
        }

    }
}
