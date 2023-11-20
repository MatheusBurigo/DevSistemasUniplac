using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PizzariaDoZe.DAO.Interfaces;

namespace PizzariaDoZe.DAO.utils
{
    internal class Funcoes
    {
        public static ConnectionInterface NewConnection(DbProviderFactory factory, string StringConexao)
        {
            ConnectionDb startConnection = new ConnectionDb();
            ConnectionInterface connections = startConnection.StartConnection(factory, StringConexao);
            return connections;
        }
    }
}
