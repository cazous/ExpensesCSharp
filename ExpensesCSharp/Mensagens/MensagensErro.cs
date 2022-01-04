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
        public void ErroDeInsercaoIns001(Exception _e)
        {
            MessageBox.Show("(INS - 001): Erro de inserção em banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ErroDeInsercaoIns002()
        {
            MessageBox.Show("(INS - 002): Campos obrigatórios a serem preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ErroDeAtualizacaoATT001(Exception _e)
        {
            MessageBox.Show("(ATT - 001): Erro de atualização em banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ErroDeAtualizacaoATT002()
        {
            MessageBox.Show("(ATT - 002): Campos obrigatórios a serem preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ErroDeBuscaBus001(Exception _e)
        {
            MessageBox.Show("(BUS - 001): Erro de busca em banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
