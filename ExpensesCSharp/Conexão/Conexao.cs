using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesCSharp.Conexão
{
    internal class Conexao
    {
        SqlConnection connection;

        private string stringConnection = "";

        public SqlConnection OpenConnection()
        {
            stringConnection = "Server = localhost\\SQLEXPRESS; Database = ExpensesDB; User Id = sa; Password = moon2010"; //C# entende '\' como um comando, portanto para utiliza-la é necessário '\\'
            try
            {
                connection = new SqlConnection(stringConnection);
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Application.Exit();
            }
            return connection;
        }

    }
}
