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
    public partial class DataForm : Form
    {
        InserirDados inserirDados = new InserirDados();
        BuscarDados buscarDados = new BuscarDados();
        AtualizarDados atualizarDados = new AtualizarDados();
        ExcluirDados excluirDados = new ExcluirDados();
        
        public DataForm()
        {
            InitializeComponent();
            atualizarTabela();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (dtpData.Value == null || txtDescricao.Text == "" || txtValor.Text == "")
                {
                    //mensagem de erro
                }
                else
                {
                    inserirDados.InserirGasto(dtpData.Value, txtDescricao.Text, (String)cmbPagamento.SelectedItem, Decimal.Parse(txtValor.Text));
                    atualizarTabela();

                }
            }
           
        }

        private void tabelaDataForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ctxExcluir_Click(object sender, EventArgs e)
        {
            int idGasto = int.Parse(tabelaDataForm.SelectedCells[0].Value.ToString());
            excluirDados.deletarGasto(idGasto);
            atualizarTabela();

        }

        private void atualizarTabela()
        {
            buscarDados.PreencherTabelaDetailForm(tabelaDataForm);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctxEditar_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm(int.Parse(tabelaDataForm.SelectedCells[0].Value.ToString()));
            //detailForm.Show();Mostra form na tela pro usuario permitindo clique no form anterior
            detailForm.ShowDialog(); //Mostra form sem permitir o clique no form anterior
            
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }
       
    }
}
