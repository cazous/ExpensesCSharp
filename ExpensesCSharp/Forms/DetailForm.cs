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
    public partial class DetailForm : Form
    {
        AtualizarDados atualizarDados = new AtualizarDados();
        int idGasto = 0;
        public DetailForm(int _id)
        {
            InitializeComponent();
            idGasto = _id;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDetailFormUpdate_Click(object sender, EventArgs e)
        {
            //DataForm dataForm = new DataForm();
            //int id = dataForm.passarId();
            //Console.WriteLine(id);
            
                //atualizarDados.AtualizarGastos(_id,);
        }
    }
}
