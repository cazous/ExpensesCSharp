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
using System.Globalization;

namespace ExpensesCSharp.Forms
{
    public partial class DetailForm : Form
    {
        DataForm dataForm;
        AtualizarDados atualizarDados = new AtualizarDados();
        MensagensErro mensagemErro = new MensagensErro();
        MensagensConfirmacao mensagensConfirmacao = new MensagensConfirmacao();

        int idGasto = 0;
      
        public DetailForm(int _id, DataForm _dataForm, DataGridView _tabela)
        {
            InitializeComponent();
            dataForm = _dataForm;
            idGasto = _id;
            lblDetailFormId.Text = "ID: " + idGasto;
            dtpDetailForm.Value = (DateTime)_tabela.SelectedCells[1].Value;
            txtDetailFormDescricao.Text = _tabela.SelectedCells[2].Value.ToString();
            cbDetailForm.SelectedItem = _tabela.SelectedCells[3].Value.ToString();
            txtDetailFormValor.Text = _tabela.SelectedCells[4].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDetailFormUpdate_Click(object sender, EventArgs e)
        {
            if (txtDetailFormDescricao.Text == "" || txtDetailFormValor.Text == "")
            {
                mensagemErro.ErroDeAtualizacaoATT002();
            }
            else
            {
                DataForm dataForm = new DataForm();
                atualizarDados.AtualizarGastos(idGasto, dtpDetailForm.Value,txtDetailFormDescricao.Text,(String)cbDetailForm.SelectedItem, Decimal.Parse(txtDetailFormValor.Text, CultureInfo.InvariantCulture));
                mensagensConfirmacao.ConfirmarAtualizacao();
                this.Close();
                
            }
        }

        private void btnDetailFormCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
