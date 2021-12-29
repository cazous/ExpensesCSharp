using ExpensesCSharp.Conexão;
using ExpensesCSharp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadForm(new DataForm());
        }

        public void loadForm(object _form)
        {
            if(this.PainelPrincipal.Controls.Count > 0) //Caso exista algum elemento de controle na tela, os remove
            {
                this.PainelPrincipal.Controls.RemoveAt(0);
            }
            Form form = _form as Form; //Atribui o parametro como Form a uma variavel do tipo form
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.PainelPrincipal.Controls.Add(form);
            this.PainelPrincipal.Tag = form;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            loadForm(new DataForm());
            buttonHome.Enabled = false;
            buttonHome.BackColor = Color.SteelBlue;
            buttonDetails.Enabled = true;
            buttonDetails.BackColor = Color.LightSkyBlue;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            loadForm(new FilterForm());
            buttonHome.Enabled = true;
            buttonHome.BackColor = Color.LightSkyBlue;
            buttonDetails.Enabled = false;
            buttonDetails.BackColor = Color.SteelBlue;
        }

        private void PainelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
