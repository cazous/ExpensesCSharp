using ExpensesCSharp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesCSharp.Forms
{
    public partial class FilterForm : Form
    {
        BuscarDados buscarDados = new BuscarDados();
        public FilterForm()
        {
            InitializeComponent();
            atualizarTabela();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DetailForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void atualizarTabela()
        {
            buscarDados.PreencherTabelas(tabelaFilterForm);
        }

        private void DetailBTNBuscar_Click(object sender, EventArgs e)
        {
            //tabelaFilterForm.DataSource = null;
            //tabelaFilterForm.Rows.Clear();
            //Limpar a tabela antes da busca
            buscarDados.BuscarPorData(tabelaFilterForm, DetailDateInicio.Value, DetailDateFim.Value);
        }
    }
}
