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
    internal class AtualizarDados : Conexao
    {
        MensagensErro mensagensErro = new MensagensErro();

        public void AtualizarGastos(int _id, DateTime _data, string _descricao, string _pagamento, decimal _valor)
        {
            try
            {
                string query = "UPDATE Expense SET [data] = @data, descricao = @descricao, pagamento = @pagamento, valor = @valor WHERE id = @id";

                using (SqlConnection con = OpenConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = _id;
                    cmd.Parameters.Add("@data", SqlDbType.DateTime).Value = _data;
                    cmd.Parameters.Add("@descricao", SqlDbType.DateTime).Value = _descricao;
                    cmd.Parameters.Add("@pagamento", SqlDbType.VarChar).Value = _pagamento;
                    cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = _valor;

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {

                //Mensagem de erro
            }
           
        }
    }
}
