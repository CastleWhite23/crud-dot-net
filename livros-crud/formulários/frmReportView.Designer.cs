namespace livros_crud.formulários
{
    partial class frmReportView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsLivro = new livros_crud.dados.dtsLivro();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmb_cidade = new System.Windows.Forms.ComboBox();
            this.getEditorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.livrosTableAdapter = new livros_crud.dados.dtsLivroTableAdapters.LivrosTableAdapter();
            this.dtsLivroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTodos = new System.Windows.Forms.Button();
            this.getEditorasTableAdapter = new livros_crud.dados.dtsLivroTableAdapters.getEditorasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEditorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLivroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.dtsLivro;
            // 
            // dtsLivro
            // 
            this.dtsLivro.DataSetName = "dtsLivro";
            this.dtsLivro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "dtsReportViewLivros";
            reportDataSource1.Value = this.livrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "livros_crud.Relátorios.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 374);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmb_cidade
            // 
            this.cmb_cidade.DataSource = this.getEditorasBindingSource;
            this.cmb_cidade.DisplayMember = "EDITORA";
            this.cmb_cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cidade.FormattingEnabled = true;
            this.cmb_cidade.Location = new System.Drawing.Point(34, 36);
            this.cmb_cidade.Name = "cmb_cidade";
            this.cmb_cidade.Size = new System.Drawing.Size(139, 21);
            this.cmb_cidade.TabIndex = 1;
            this.cmb_cidade.ValueMember = "EDITORA";
            // 
            // getEditorasBindingSource
            // 
            this.getEditorasBindingSource.DataMember = "getEditoras";
            this.getEditorasBindingSource.DataSource = this.dtsLivro;
            // 
            // livrosBindingSource1
            // 
            this.livrosBindingSource1.DataMember = "Livros";
            this.livrosBindingSource1.DataSource = this.dtsLivro;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por editora";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(179, 34);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(98, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // dtsLivroBindingSource
            // 
            this.dtsLivroBindingSource.DataSource = this.dtsLivro;
            this.dtsLivroBindingSource.Position = 0;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(283, 34);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(98, 23);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "&Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // getEditorasTableAdapter
            // 
            this.getEditorasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_cidade);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportView";
            this.Text = "frmReportView";
            this.Load += new System.EventHandler(this.frmReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEditorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLivroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dados.dtsLivro dtsLivro;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private dados.dtsLivroTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.ComboBox cmb_cidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.BindingSource livrosBindingSource1;
        private System.Windows.Forms.BindingSource dtsLivroBindingSource;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.BindingSource getEditorasBindingSource;
        private dados.dtsLivroTableAdapters.getEditorasTableAdapter getEditorasTableAdapter;
    }
}