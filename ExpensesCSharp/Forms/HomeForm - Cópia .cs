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

            loadForm(new Form1());
            buttonHome.Enabled = false;
            buttonDetails.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            loadForm(new DetailForm());
            buttonHome.Enabled = true;
            buttonDetails.Enabled = false;
        }
    }
}
