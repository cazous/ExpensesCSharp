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
            buscarDados.BuscarPorData(tabelaFilterForm, DetailDateInicio.Value, DetailDateFim.Value);
            buscarDados.EstatisticasGastosTotaisPorData(DetailDateInicio.Value, DetailDateFim.Value, labelValorGastosTotais);
            buscarDados.EstatisticasFormaPagamentoPorData(DetailDateInicio.Value, DetailDateFim.Value, labelQuantCC, "Cartão de Crédito");
            buscarDados.EstatisticasFormaPagamentoPorData(DetailDateInicio.Value, DetailDateFim.Value, labelQuantPix, "PIX");
            buscarDados.EstatisticasFormaPagamentoPorData(DetailDateInicio.Value, DetailDateFim.Value, labelQuantDebito, "Débito");
        }

        private void DetailBTNMes_Click(object sender, EventArgs e)
        {
            buscarDados.BuscarUltimoMes(tabelaFilterForm);
            buscarDados.EstatisticasGastosTotaisPorMes(labelValorGastosTotais);
            buscarDados.EstatisticasFormaPagamentoPorMes(labelQuantCC, "Cartão de Crédito");
            buscarDados.EstatisticasFormaPagamentoPorMes(labelQuantPix, "PIX");
            buscarDados.EstatisticasFormaPagamentoPorMes(labelQuantDebito, "Débito");
        }

        private void DetailBTNAno_Click(object sender, EventArgs e)
        {
            buscarDados.BuscarUltimoAno(tabelaFilterForm);
            buscarDados.EstatisticasGastosTotaisPorAno(labelValorGastosTotais);
            buscarDados.EstatisticasFormaPagamentoPorAno(labelQuantCC, "Cartão de Crédito");
            buscarDados.EstatisticasFormaPagamentoPorAno(labelQuantPix, "PIX");
            buscarDados.EstatisticasFormaPagamentoPorAno(labelQuantDebito, "Débito");
        }
    }
}
