using ExpensesCSharp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesCSharp.Mensagens
{
    internal class MensagensConfirmacao
    {
        AtualizarDados atualizarDados = new AtualizarDados();
        ExcluirDados excluirDados = new ExcluirDados();
        public void ConfirmarExclusao(int _id)
        {
           var confirmResult =  MessageBox.Show("Deseja prosseguir com a exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmResult == DialogResult.Yes)
            {
                excluirDados.deletarGasto(_id);
            }
            
        }

        public void ConfirmarAtualizacao()
        {
            MessageBox.Show("Atualizado com sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
