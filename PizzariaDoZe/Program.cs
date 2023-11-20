using System.Configuration;
using System.Data.Common;
using System.Globalization;

namespace PizzariaDoZe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // No .NET 2.1 ou posterior os provedores não são mais registrados automaticamente no DbProviderFactories
            // Após instalar os pacotes via NuGet, realizar o registro manualmente no DbProviderFactories
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);
            #region Idioma
            AjustaIdiomaRegiao();
            #endregion

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        static public void AjustaIdiomaRegiao()
        {
            // ? indica que o valor pode ser nulo
            // no ternário estamos tratando para isso não acontecer
            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ?
                ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";

            //ajusta o idioma/região
            // o operador ! (null-forgiving) afirma que o valor já foi tratado e não será nulo aqui
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);
        }
    }
}