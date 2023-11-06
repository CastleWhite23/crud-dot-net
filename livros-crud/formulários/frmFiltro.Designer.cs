namespace livros_crud.formulários
{
    partial class frmFiltro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtsLivro = new livros_crud.dados.dtsLivro();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new livros_crud.dados.dtsLivroTableAdapters.LivrosTableAdapter();
            this.tableAdapterManager = new livros_crud.dados.dtsLivroTableAdapters.TableAdapterManager();
            this.txt_principal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.livrosDataGridView = new System.Windows.Forms.DataGridView();
            this.cmb_opc = new System.Windows.Forms.ComboBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsLivro
            // 
            this.dtsLivro.DataSetName = "dtsLivro";
            this.dtsLivro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.dtsLivro;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LivrosTableAdapter = this.livrosTableAdapter;
            this.tableAdapterManager.UpdateOrder = livros_crud.dados.dtsLivroTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_principal
            // 
            this.txt_principal.Location = new System.Drawing.Point(297, 63);
            this.txt_principal.Name = "txt_principal";
            this.txt_principal.Size = new System.Drawing.Size(302, 20);
            this.txt_principal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtre os registros";
            // 
            // livrosDataGridView
            // 
            this.livrosDataGridView.AllowUserToAddRows = false;
            this.livrosDataGridView.AutoGenerateColumns = false;
            this.livrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.livrosDataGridView.DataSource = this.livrosBindingSource;
            this.livrosDataGridView.Location = new System.Drawing.Point(44, 132);
            this.livrosDataGridView.Name = "livrosDataGridView";
            this.livrosDataGridView.ReadOnly = true;
            this.livrosDataGridView.Size = new System.Drawing.Size(716, 340);
            this.livrosDataGridView.TabIndex = 6;
            // 
            // cmb_opc
            // 
            this.cmb_opc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_opc.FormattingEnabled = true;
            this.cmb_opc.Items.AddRange(new object[] {
            "Que começa com",
            "Que contém",
            "Igual a",
            "Que esteja entre"});
            this.cmb_opc.Location = new System.Drawing.Point(170, 63);
            this.cmb_opc.Name = "cmb_opc";
            this.cmb_opc.Size = new System.Drawing.Size(121, 21);
            this.cmb_opc.TabIndex = 5;
            this.cmb_opc.SelectedIndexChanged += new System.EventHandler(this.cmb_opc_SelectedIndexChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(605, 64);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(155, 21);
            this.btnFiltro.TabIndex = 9;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Titulo",
            "Autores",
            "Editora",
            "Assunto"});
            this.cmbCampo.Location = new System.Drawing.Point(268, 26);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(141, 21);
            this.cmbCampo.TabIndex = 11;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(41, 26);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(221, 18);
            this.lblCampo.TabIndex = 12;
            this.lblCampo.Text = "Selecione um campo para filtrar:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(415, 25);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(345, 22);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Que esteja entre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(399, 95);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "a";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Livro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Livro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Autores";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autores";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EDITORA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Editora";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Dataedicao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data de Edição";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Assunto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Assunto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 190;
            // 
            // frmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txt_principal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.livrosDataGridView);
            this.Controls.Add(this.cmb_opc);
            this.Name = "frmFiltro";
            this.Text = "frmFiltro";
            this.Load += new System.EventHandler(this.frmFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dados.dtsLivro dtsLivro;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private dados.dtsLivroTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private dados.dtsLivroTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_principal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView livrosDataGridView;
        private System.Windows.Forms.ComboBox cmb_opc;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}