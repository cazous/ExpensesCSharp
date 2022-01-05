using ExpensesCSharp.Conexão;
using ExpensesCSharp.Mensagens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesCSharp.Data
{
    internal class BuscarDados : Conexao
    {
        MensagensErro mensagensErro = new MensagensErro();
        public void PreencherTabelas(DataGridView _tabela)
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string querySelecao = "SELECT id, [data], descricao, pagamento, valor FROM Expense";
                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, con); //Executor da query se seleção
                    adapter.SelectCommand.ExecuteNonQuery(); //Execução
                    adapter.Fill(datatable); //Preenchimento objeto tabela (datatable)
                    _tabela.DataSource = datatable; //Atribuindo tabela de dados como fonte de dados para o parametro
                }

            }
            catch (Exception e)
            {
                mensagensErro.ErroDeBuscaBus001(e);
            }

        }

        public void BuscarPorData(DataGridView _tabela, DateTime _dataInicial, DateTime _dataFinal)
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string querySelecao = "SELECT * FROM Expense WHERE [data] BETWEEN @dataInicial AND @dataFinal";
                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataInicial", _dataInicial);
                    adapter.SelectCommand.Parameters.AddWithValue("@dataFinal", _dataFinal);
                    //adapter.SelectCommand.ExecuteNonQuery();
                    adapter.Fill(datatable);
                    _tabela.DataSource = datatable;

                }
            }
            catch (Exception e)
            {

                //Mensagem de erro
            }
        }
    }
}
