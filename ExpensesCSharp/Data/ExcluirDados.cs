using ExpensesCSharp.Conexão;
using ExpensesCSharp.Mensagens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesCSharp.Data
{
    internal class ExcluirDados : Conexao   
    {
        MensagensErro mensagemErro = new MensagensErro();

        public void deletarGasto(int _id)
        {
            try
            {
                using(SqlConnection con = OpenConnection())
                {
                    string queryExclusao = "DELETE FROM Expense WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(queryExclusao, con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = _id;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {

                //Mensagem erro;
            }
        }
    }
}
