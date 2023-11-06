using livros_crud.dados.dtsLivroTableAdapters;
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
    public partial class frmNovoCrud : Form
    {
        public frmNovoCrud()
        {
            InitializeComponent();
        }

        private void frmNovoCrud_Load(object sender, EventArgs e)
        {


        }

        private void id_LivroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (btnNovo.Text == "&Novo")
            {
                habilita_controles();
                txtID.Text = "";
                txtID.Enabled = false;
                txtTitulo.Focus();
                btnNovo.Text = "&Gravar";
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

            }else if (btnNovo.Text == "&Gravar")
            {
                string titulo = txtTitulo.Text,autores = txtAutores.Text, editora = txtEditora.Text, assunto = txtAssunto.Text;
                LivrosTableAdapter objLivro = new LivrosTableAdapter();
                string id = objLivro.qryUltimoIDGerado().ToString();
                 objLivro.qryInsertLivro(titulo, autores, editora, dtDataEdicao.Value, assunto);
                MessageBox.Show("Livro cadastrado com sucesso - ID =" + id);
                limpa_controles();
                desabilita_controles();
                btnNovo.Text = "&Novo";
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void livrosBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

        }
        private void limpa_controles()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    (controle as TextBox).Clear();
                }
                else if (controle is DateTimePicker)
                {
                    (controle as DateTimePicker).Value = DateTime.Now;
                }
            }
            txtID.Focus();
        }

        private void habilita_controles()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox || controle is DateTimePicker)
                {
                    controle.Enabled = true;
                }

            }
           
        }

        private void desabilita_controles(){
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox || controle is DateTimePicker)
                {
                    controle.Enabled = false;
                }

            }
            txtID.Enabled = true;
           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            LivrosTableAdapter objLivro = new LivrosTableAdapter();

            if(btnAlterar.Text == "&Alterar")
            {
                if(txtID.Text == "")
                {
                    MessageBox.Show("Por favor preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                
                    DataTable dt = objLivro.GetDataBy(int.Parse(txtID.Text));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum registro com o id - " + txtID.Text + " - foi encontrado", "Regsitro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtTitulo.Text = dt.Rows[0]["Titulo"].ToString();
                        txtAutores.Text = dt.Rows[0]["Autores"].ToString();
                        txtEditora.Text = dt.Rows[0]["EDITORA"].ToString();
                        txtAssunto.Text = dt.Rows[0]["Assunto"].ToString();
                        dtDataEdicao.Value = DateTime.Parse(dt.Rows[0]["Dataedicao"].ToString());
                        habilita_controles();
                        txtID.Enabled = false;
                        btnAlterar.Text = "&Gravar";
                        btnNovo.Enabled = false;
                        btnExcluir.Enabled = false;
                   }
                   
                }
            }
            else
            {
                objLivro.qryUpdateRegistro(txtTitulo.Text.ToString(),txtAutores.Text.ToString(),
                    txtEditora.Text.ToString(), DateTime.Parse((dtDataEdicao.Value).ToString()) ,
                     txtAssunto.Text.ToString() , int.Parse(txtID.Text) );

                MessageBox.Show("Alterações Realizadas com sucesso!");
                limpa_controles();
                desabilita_controles();
                btnAlterar.Text = "&Alterar";
                btnNovo.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LivrosTableAdapter objLivro = new LivrosTableAdapter();

            if(txtID.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(txtID.Text);
                DataTable dt = objLivro.GetDataBy(int.Parse(txtID.Text));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro com o id - " + txtID.Text + " - foi encontrado", "Regsitro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNovo.Enabled = false;
                    btnAlterar.Enabled = false;
                    txtTitulo.Text = dt.Rows[0]["Titulo"].ToString();
                    txtAutores.Text = dt.Rows[0]["Autores"].ToString();
                    txtEditora.Text = dt.Rows[0]["EDITORA"].ToString();
                    txtAssunto.Text = dt.Rows[0]["Assunto"].ToString();
                    dtDataEdicao.Value = DateTime.Parse(dt.Rows[0]["Dataedicao"].ToString());
                    habilita_controles();
                    txtID.Enabled = false;
                    if(MessageBox.Show("Deseja excluir o registro?", "Excluindo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        objLivro.qryDeletarRegistro(id);
                        MessageBox.Show("Registro excluído com sucesso!");
                        desabilita_controles();
                        limpa_controles();
                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                    }
                    else
                    {
                        desabilita_controles();
                        limpa_controles();
                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;

                    }
                }
            }
        }

    }
}
