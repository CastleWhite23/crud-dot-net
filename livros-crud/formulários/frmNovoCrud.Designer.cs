namespace livros_crud.formulários
{
    partial class frmNovoCrud
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
            System.Windows.Forms.Label id_LivroLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autoresLabel;
            System.Windows.Forms.Label eDITORALabel;
            System.Windows.Forms.Label dataedicaoLabel;
            System.Windows.Forms.Label assuntoLabel;
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutores = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.dtDataEdicao = new System.Windows.Forms.DateTimePicker();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            id_LivroLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autoresLabel = new System.Windows.Forms.Label();
            eDITORALabel = new System.Windows.Forms.Label();
            dataedicaoLabel = new System.Windows.Forms.Label();
            assuntoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_LivroLabel
            // 
            id_LivroLabel.AutoSize = true;
            id_LivroLabel.Location = new System.Drawing.Point(41, 95);
            id_LivroLabel.Name = "id_LivroLabel";
            id_LivroLabel.Size = new System.Drawing.Size(45, 13);
            id_LivroLabel.TabIndex = 5;
            id_LivroLabel.Text = "Id Livro:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(41, 121);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 7;
            tituloLabel.Text = "Titulo:";
            // 
            // autoresLabel
            // 
            autoresLabel.AutoSize = true;
            autoresLabel.Location = new System.Drawing.Point(41, 147);
            autoresLabel.Name = "autoresLabel";
            autoresLabel.Size = new System.Drawing.Size(46, 13);
            autoresLabel.TabIndex = 9;
            autoresLabel.Text = "Autores:";
            // 
            // eDITORALabel
            // 
            eDITORALabel.AutoSize = true;
            eDITORALabel.Location = new System.Drawing.Point(41, 173);
            eDITORALabel.Name = "eDITORALabel";
            eDITORALabel.Size = new System.Drawing.Size(43, 13);
            eDITORALabel.TabIndex = 11;
            eDITORALabel.Text = "Editora:";
            // 
            // dataedicaoLabel
            // 
            dataedicaoLabel.AutoSize = true;
            dataedicaoLabel.Location = new System.Drawing.Point(41, 200);
            dataedicaoLabel.Name = "dataedicaoLabel";
            dataedicaoLabel.Size = new System.Drawing.Size(65, 13);
            dataedicaoLabel.TabIndex = 13;
            dataedicaoLabel.Text = "Dataedicao:";
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Location = new System.Drawing.Point(41, 225);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(48, 13);
            assuntoLabel.TabIndex = 15;
            assuntoLabel.Text = "Assunto:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(470, 92);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(275, 62);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(470, 160);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(275, 62);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(470, 225);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(275, 62);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(112, 92);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(291, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(112, 118);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(291, 20);
            this.txtTitulo.TabIndex = 8;
            // 
            // txtAutores
            // 
            this.txtAutores.Enabled = false;
            this.txtAutores.Location = new System.Drawing.Point(112, 144);
            this.txtAutores.Name = "txtAutores";
            this.txtAutores.Size = new System.Drawing.Size(291, 20);
            this.txtAutores.TabIndex = 10;
            // 
            // txtEditora
            // 
            this.txtEditora.Enabled = false;
            this.txtEditora.Location = new System.Drawing.Point(112, 170);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(291, 20);
            this.txtEditora.TabIndex = 12;
            // 
            // dtDataEdicao
            // 
            this.dtDataEdicao.Enabled = false;
            this.dtDataEdicao.Location = new System.Drawing.Point(112, 196);
            this.dtDataEdicao.Name = "dtDataEdicao";
            this.dtDataEdicao.Size = new System.Drawing.Size(291, 20);
            this.dtDataEdicao.TabIndex = 14;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Enabled = false;
            this.txtAssunto.Location = new System.Drawing.Point(112, 222);
            this.txtAssunto.Multiline = true;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(291, 136);
            this.txtAssunto.TabIndex = 16;
            // 
            // frmNovoCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(id_LivroLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(autoresLabel);
            this.Controls.Add(this.txtAutores);
            this.Controls.Add(eDITORALabel);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(dataedicaoLabel);
            this.Controls.Add(this.dtDataEdicao);
            this.Controls.Add(assuntoLabel);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmNovoCrud";
            this.Text = "Novo CRUD";
            this.Load += new System.EventHandler(this.frmNovoCrud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutores;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.DateTimePicker dtDataEdicao;
        private System.Windows.Forms.TextBox txtAssunto;
    }
}