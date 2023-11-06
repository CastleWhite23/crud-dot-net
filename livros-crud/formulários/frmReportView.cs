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
    public partial class frmReportView : Form
    {
        public frmReportView()
        {
            InitializeComponent();
        }

        private void frmReportView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dtsLivro.getEditoras'. Você pode movê-la ou removê-la conforme necessário.
            this.getEditorasTableAdapter.Fill(this.dtsLivro.getEditoras);
            // TODO: esta linha de código carrega dados na tabela 'dtsLivro.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.dtsLivro.Livros);

            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {


            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Editora", cmb_cidade.Text));
                this.reportViewer1.RefreshReport();
            
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Editora", (string)null));
            this.reportViewer1.RefreshReport();
        }
    }
}
