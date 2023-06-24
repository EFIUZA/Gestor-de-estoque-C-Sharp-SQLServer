using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Tabela
{
    //Classe para acessar o banco de dados
    public class conn
    {
        // Variaveis para acessar o banco de dados
        private static string server = "NB-EFF";
        private static string dataBase = "EstoqueCSharp";
        private static string user = "sa";
        private static string password = "sqlserver";
        // Comando de acesso ao banco de dados
        public static string StrCon
        {
            // Comando para acessar banco de dados em SQL Server com o usuario do windows
            get { return $"Data Source={server};Integrated Security=True;Initial Catalog={dataBase}"; }
            
            // Comando para acessar banco de dados em SQL Server com os usuarios das variaveis
            // get { return $"Data Source={server}; Integrate Security=false;Initial Catalog={dataBase}; User ID={user}; Password={password}"}
        }
    }
}
