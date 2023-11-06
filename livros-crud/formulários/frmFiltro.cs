using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livros_crud.formulários
{
    public partial class frmFiltro : Form
    {
        public frmFiltro()
        {
            InitializeComponent();
        }
        
        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtsLivro);

        }

        private void frmFiltro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dtsLivro.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.dtsLivro.Livros);
            cmb_opc.SelectedIndex = 0;
            cmbCampo.SelectedIndex = 0;

        }

        private void cmb_opc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_opc.Text == "Que esteja entre")
            {
                dateTimePicker1.Enabled = true; dateTimePicker2.Enabled = true;
                txt_principal.Enabled = false;
                txt_principal.Text = "";
                cmbCampo.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = false; dateTimePicker2.Enabled = false;
                txt_principal.Enabled = true;
                cmbCampo.Enabled = true;
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            string vFiltro = cmb_opc.Text;
            string vCampo = cmbCampo.Text;
            string texto = txt_principal.Text;
            string txtFiltro = "";
            DateTime data1 = dateTimePicker1.Value, data2 = dateTimePicker2.Value;

            if(txt_principal.Enabled && texto == "")
            {
                MessageBox.Show("Preencha todos os campos antes de filtrar", "Erro ao filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (vFiltro)
                {
                    case "Que começa com":
                        txtFiltro = vCampo + " like '" + texto + "%'";
                        break;
                    case "Que contém":
                        txtFiltro = vCampo + " like '%" + texto + "'";
                        break;
                    case "Igual a":
                        txtFiltro = vCampo + " like '" + texto + "'";
                        break;
                    case "Que esteja entre":
                        vCampo = "Dataedicao";
                        txtFiltro = vCampo + ">= '" + data1 + "' and " + vCampo + " <="+ "'" + data2 +"'";
                        break;
                    default:
                        break;
                }
                livrosBindingSource.Filter =  txtFiltro;
            }
           

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            livrosBindingSource.Filter = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
