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
    internal class InserirDados : Conexao
    {
        MensagensErro mensagensErro = new MensagensErro();
        BuscarDados buscarDados = new BuscarDados();
        public void InserirGasto(DateTime _data, string _descricao, string _pagamento, decimal _valor)
        {
            try
            {
                string queryInsercao = "INSERT INTO Expense ([data], descricao, pagamento, valor) " +
                    "VALUES (@data, @descricao, @pagamento, @valor)";

                using (SqlConnection con = OpenConnection())
                {
                    SqlCommand cmd = new SqlCommand(queryInsercao, con); //Executor da query em C#
                    cmd.Parameters.Add("@data", SqlDbType.DateTime).Value = _data; //Parametros sendo passados para o executor
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = _descricao;
                    cmd.Parameters.Add("@pagamento", SqlDbType.VarChar).Value = _pagamento;
                    cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = _valor;

                    cmd.ExecuteNonQuery(); //Execução
                }

            }
            catch (Exception e)
            {
                mensagensErro.ErroDeInsercaoGastos(e);
            }
        }
    }
}
