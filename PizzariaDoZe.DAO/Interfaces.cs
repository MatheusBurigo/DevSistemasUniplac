using System.Data.Common;

namespace PizzariaDoZe.DAO
{
    public class Interfaces
    {
        public class ConnectionInterface
        {
            public DbConnection conexao { get; set; }
            public DbCommand comando { get; set; }
        }
    }
}
