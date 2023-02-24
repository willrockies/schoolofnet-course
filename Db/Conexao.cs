using System;

namespace Db
{
    public class Conexao
    {
        private static readonly string server = "NBABT007\\SQLEXPRESS";
        private static readonly string database = "Financeiro";
        private static readonly string username = "sa";
        private static readonly string password = "@wa4n12k20%";

        public static string GetStringConnection() => $"Server={server};Database={database};User Id={username};Password={password}";

    }
}
