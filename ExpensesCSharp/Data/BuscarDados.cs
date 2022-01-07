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
        #region Filtros
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

        public void BuscarUltimoMes(DataGridView _tabela)
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string mesAtual = DateTime.Now.Month.ToString();

                    string querySelecao = "SELECT * FROM Expense where month(data) = @mesAtual order by [data]";

                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@mesAtual", mesAtual);
                    adapter.Fill(datatable);
                    _tabela.DataSource = datatable;
                }
            }
            catch (Exception e)
            {

                //Mensagem de erro
            }

        }

        public void BuscarUltimoAno(DataGridView _tabela)
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string anoAtual = DateTime.Now.Year.ToString();

                    string querySelecao = "SELECT * FROM Expense where year(data) = @anoAtual order by [data]";

                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@anoAtual", anoAtual);
                    adapter.Fill(datatable);
                    _tabela.DataSource = datatable;
                }
            }
            catch (Exception)
            {
                //Mensagem de erro
            }

        }
        #endregion
        #region Estatisticas
        public void EstatisticasGastosTotaisPorData(DateTime _dataInicial, DateTime _dataFinal, Label _label)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string querySelecao = "SELECT SUM(valor) FROM Expense WHERE [data] BETWEEN @dataInicial AND @dataFinal";

                    SqlCommand cmd = new SqlCommand(querySelecao, con);
                    cmd.Parameters.Add("@dataInicial", SqlDbType.DateTime).Value = _dataInicial;
                    cmd.Parameters.Add("@dataFinal", SqlDbType.DateTime).Value = _dataFinal;

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (reader.IsDBNull(0))
                    {
                        _label.Text = "0";
                    }
                    else
                    {
                        _label.Text = reader.GetDecimal(0).ToString();
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void EstatisticasFormaPagamentoPorData(DateTime _dataInicial, DateTime _dataFinal, Label _label, string _pagamento)
        {
            //SELECT SUM(valor) FROM Expense WHERE [data] BETWEEN '01-01-2022' AND '20-01-2022' AND pagamento = 'Débito'
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string querySelecao = "SELECT COUNT(pagamento) FROM Expense WHERE [data] BETWEEN @dataInicial AND @dataFinal AND pagamento = @pagamento";

                    SqlCommand cmd = new SqlCommand(querySelecao, con);
                    cmd.Parameters.Add("@datainicial", SqlDbType.DateTime).Value = _dataInicial;
                    cmd.Parameters.Add("@dataFinal", SqlDbType.DateTime).Value = _dataFinal;
                    cmd.Parameters.Add("@pagamento", SqlDbType.VarChar).Value = _pagamento;

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    _label.Text = reader.GetInt32(0).ToString();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void EstatisticasGastosTotaisPorMes(Label _label)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string mesAtual = DateTime.Now.Month.ToString();

                    string querySelecao = "SELECT SUM(valor) FROM Expense WHERE month(data) = @mesAtual";

                    SqlCommand cmd = new SqlCommand(querySelecao, con);
                    cmd.Parameters.Add("@mesAtual", SqlDbType.VarChar).Value = mesAtual;
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    _label.Text = reader.GetDecimal(0).ToString();

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }
        public void EstatisticasFormaPagamentoPorMes(Label _label, string _pagamento)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string mesAtual = DateTime.Now.Month.ToString();

                    string querySelecao = "SELECT COUNT(pagamento) FROM Expense WHERE month(data) = @mesAtual AND pagamento = @pagamento";

                    SqlCommand cmd = new SqlCommand(querySelecao, con);
                    cmd.Parameters.Add("@mesAtual", SqlDbType.VarChar).Value = mesAtual;
                    cmd.Parameters.Add("@pagamento", SqlDbType.VarChar).Value = _pagamento;

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    _label.Text = reader.GetInt32(0).ToString();

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }
        public void EstatisticasGastosTotaisPorAno(Label _label)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string anoAtual = DateTime.Now.Year.ToString();

                    string querySelecao = "SELECT SUM(valor) FROM Expense WHERE year(data) = @anoAtual";

                    SqlCommand cmd = new SqlCommand(querySelecao, con);
                    cmd.Parameters.Add("@anoAtual", SqlDbType.VarChar).Value = anoAtual;
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    _label.Text = reader.GetDecimal(0).ToString();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public void EstatisticasFormaPagamentoPorAno(Label _label, string _pagamento)
        {
            try
            {
                using (SqlConnection con = OpenConnection())
                {
                    string anoAtual = DateTime.Now.Year.ToString();

                    string querySelecao = "SELECT COUNT(pagamento) FROM Expense WHERE year(data) = @anoAtual AND  pagamento = @pagamento";

                    SqlCommand cmd = new SqlCommand(querySelecao, con);
                    cmd.Parameters.Add("@anoAtual", SqlDbType.VarChar).Value = anoAtual;
                    cmd.Parameters.Add("@pagamento", SqlDbType.VarChar).Value = _pagamento;
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    _label.Text = reader.GetInt32(0).ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        #endregion
    }
}
