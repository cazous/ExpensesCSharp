using ExpensesCSharp.Data;
using ExpensesCSharp.Mensagens;
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
        MensagensErro mensagensErro = new MensagensErro();
        MensagensConfirmacao mensagensConfirmacao = new MensagensConfirmacao();
        public DataForm()
        {
            InitializeComponent();
            atualizarTabela();
            
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDescricao.Text == "" || txtValor.Text == "")
                {
                    mensagensErro.ErroDeInsercaoIns002();
                }
                else
                {
                    inserirDados.InserirGasto(dtpData.Value, txtDescricao.Text, (String)cmbPagamento.SelectedItem, Decimal.Parse(txtValor.Text));
                    atualizarTabela();

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtDescricao.Text == "" || txtValor.Text == "")
                {
                    mensagensErro.ErroDeInsercaoIns002();
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
           mensagensConfirmacao.ConfirmarExclusao(idGasto);
            atualizarTabela();

        }

        public void atualizarTabela()
        {
            buscarDados.PreencherTabelas(tabelaDataForm);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctxEditar_Click(object sender, EventArgs e)
        {
            //DetailForm detailForm = new DetailForm(int.Parse(tabelaDataForm.SelectedCells[0].Value.ToString()));
            //detailForm.Show();Mostra form na tela pro usuario permitindo clique no form anterior
            //detailForm.ShowDialog(); //Mostra form sem permitir o clique no form anterior

            //
            DetailForm detailForm = new DetailForm(int.Parse(tabelaDataForm.SelectedCells[0].Value.ToString()),this, tabelaDataForm);
            lblIdGasto.Text = tabelaDataForm.SelectedCells[0].Value.ToString();
            detailForm.ShowDialog();
            atualizarTabela();
            
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }
     
    }
}
