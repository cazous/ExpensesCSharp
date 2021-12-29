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
        public void PreencherTabelaDetailForm(DataGridView _tabela)
        {
            DataTable datatable = new DataTable();

            {
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
                    //Mensagem de erro
                }
            }
        }
    }
}
