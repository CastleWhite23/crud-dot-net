using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using livros_crud.formulários;


namespace livros_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;          
        }

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                frmCadLivros objCadLivros = new frmCadLivros();
                objCadLivros.MdiParent = this;
                objCadLivros.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Deseja sair do formulário?", "Fechando formúlario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Close();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void novoCrudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovoCrud objNovoCrud = new frmNovoCrud();
            objNovoCrud.MdiParent = this;
            objNovoCrud.Show();
        }

        private void filtroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFiltro objFiltro = new frmFiltro();
            objFiltro.MdiParent = this;
            objFiltro.Show();
        }

        private void relatórioDeLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportView objReportViewer = new frmReportView();
            objReportViewer.MdiParent = this;
            objReportViewer.Show();
        }
    }
}
