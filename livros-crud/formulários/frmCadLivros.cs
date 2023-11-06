using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livros_crud.formulários
{
    public partial class frmCadLivros : Form
    {
        public frmCadLivros()
        {
            InitializeComponent();
        }

        private bool novoRegistro = false;
        private bool confirmarExclusao = false;
        private bool excluirRegistro = false;

        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsLivro);
            //não quero usar o update se o cara não quiser excluir o registro
            if(!novoRegistro)
            {
                MessageBox.Show("Alterações salvas com sucesso!", "Alterações salvas", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Registro adicionado com sucesso!", "Aicionar registro", MessageBoxButtons.OK);
                novoRegistro = false;
            }
            
         
        }

        private void frmCadLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dtsLivro.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.dtsLivro.Livros);

        }

       
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
                
                DialogResult resultado = MessageBox.Show("Deseja excluir o registro ?", "Excluindo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    excluirRegistro = true;
                    MessageBox.Show("Registro excluido com sucesso!");
                    this.tableAdapterManager.UpdateAll(this.dtsLivro);
                    excluirRegistro = false;

            }
            else
            {
                livrosTableAdapter.Fill(dtsLivro.Livros);

            }
                 
        }

        private void livrosBindingSource_CurrentChanging(object sender, CancelEventArgs e)
        {
            // Verifica se a exclusão do registro está sendo realizada
            //if (excluirRegistro)
            //{
            //    //    Pára a execução do evento

            //    e.Cancel = true;
            // }

         }
        private void frmCadLivros_FormClosing(object sender, FormClosingEventArgs e)
        {
                    novoRegistro = false;
  
        }

        private void autoresLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            novoRegistro = true;
        }

        private void btnAtua_Click(object sender, EventArgs e)
        {
            livrosBindingSource.Filter = "";
        }
    }
}
