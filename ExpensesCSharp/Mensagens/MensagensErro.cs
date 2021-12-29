using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesCSharp.Mensagens
{
    internal class MensagensErro
    {
        public void ErroDeInsercaoGastos(Exception _e)
        {
            MessageBox.Show("(INS - 001): Erro de inserção em banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
