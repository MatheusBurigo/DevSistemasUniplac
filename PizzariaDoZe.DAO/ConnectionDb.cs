using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PizzariaDoZe.DAO.Interfaces;

namespace PizzariaDoZe.DAO
{
    internal class ConnectionDb
    {

        public ConnectionInterface StartConnection(DbProviderFactory factory, string stringConexao)
        {
            using DbConnection conexao = factory.CreateConnection()!; //Cria conexão
            conexao!.ConnectionString = stringConexao; //Atribui a string de conexão
            using DbCommand comando = factory.CreateCommand()!; //Cria comando
            comando!.Connection = conexao; //Atribui conexão

            ConnectionInterface response = new ConnectionInterface();
            response.conexao = conexao;
            response.comando = comando;

            return response;
        }
    }
}
