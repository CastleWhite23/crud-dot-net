namespace livros_crud.formulários
{
    partial class frmCadLivros
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
            System.Windows.Forms.Label id_LivroLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autoresLabel;
            System.Windows.Forms.Label eDITORALabel;
            System.Windows.Forms.Label dataedicaoLabel;
            System.Windows.Forms.Label assuntoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadLivros));
            this.livrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsLivro = new livros_crud.dados.dtsLivro();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.livrosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.livrosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livrosTableAdapter = new livros_crud.dados.dtsLivroTableAdapters.LivrosTableAdapter();
            this.tableAdapterManager = new livros_crud.dados.dtsLivroTableAdapters.TableAdapterManager();
            this.gob_inputs = new System.Windows.Forms.GroupBox();
            this.id_LivroTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autoresTextBox = new System.Windows.Forms.TextBox();
            this.eDITORATextBox = new System.Windows.Forms.TextBox();
            this.dataedicaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.btnAtua = new System.Windows.Forms.Button();
            id_LivroLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autoresLabel = new System.Windows.Forms.Label();
            eDITORALabel = new System.Windows.Forms.Label();
            dataedicaoLabel = new System.Windows.Forms.Label();
            assuntoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingNavigator)).BeginInit();
            this.livrosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).BeginInit();
            this.gob_inputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_LivroLabel
            // 
            id_LivroLabel.AutoSize = true;
            id_LivroLabel.Location = new System.Drawing.Point(13, 22);
            id_LivroLabel.Name = "id_LivroLabel";
            id_LivroLabel.Size = new System.Drawing.Size(45, 13);
            id_LivroLabel.TabIndex = 13;
            id_LivroLabel.Text = "Id Livro:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(15, 48);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 15;
            tituloLabel.Text = "Titulo:";
            // 
            // autoresLabel
            // 
            autoresLabel.AutoSize = true;
            autoresLabel.Location = new System.Drawing.Point(15, 74);
            autoresLabel.Name = "autoresLabel";
            autoresLabel.Size = new System.Drawing.Size(46, 13);
            autoresLabel.TabIndex = 17;
            autoresLabel.Text = "Autores:";
            autoresLabel.Click += new System.EventHandler(this.autoresLabel_Click);
            // 
            // eDITORALabel
            // 
            eDITORALabel.AutoSize = true;
            eDITORALabel.Location = new System.Drawing.Point(15, 100);
            eDITORALabel.Name = "eDITORALabel";
            eDITORALabel.Size = new System.Drawing.Size(43, 13);
            eDITORALabel.TabIndex = 19;
            eDITORALabel.Text = "Editora:";
            // 
            // dataedicaoLabel
            // 
            dataedicaoLabel.AutoSize = true;
            dataedicaoLabel.Location = new System.Drawing.Point(13, 123);
            dataedicaoLabel.Name = "dataedicaoLabel";
            dataedicaoLabel.Size = new System.Drawing.Size(65, 13);
            dataedicaoLabel.TabIndex = 21;
            dataedicaoLabel.Text = "Dataedicao:";
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Location = new System.Drawing.Point(377, 18);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(48, 13);
            assuntoLabel.TabIndex = 23;
            assuntoLabel.Text = "Assunto:";
            // 
            // livrosBindingNavigator
            // 
            this.livrosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.livrosBindingNavigator.BindingSource = this.livrosBindingSource;
            this.livrosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.livrosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.livrosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.livrosBindingNavigatorSaveItem});
            this.livrosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.livrosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.livrosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.livrosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.livrosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.livrosBindingNavigator.Name = "livrosBindingNavigator";
            this.livrosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.livrosBindingNavigator.Size = new System.Drawing.Size(824, 25);
            this.livrosBindingNavigator.TabIndex = 0;
            this.livrosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // livrosBindingNavigatorSaveItem
            // 
            this.livrosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.livrosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosBindingNavigatorSaveItem.Image")));
            this.livrosBindingNavigatorSaveItem.Name = "livrosBindingNavigatorSaveItem";
            this.livrosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.livrosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.livrosBindingNavigatorSaveItem.Click += new System.EventHandler(this.livrosBindingNavigatorSaveItem_Click);
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
            this.livrosDataGridView.Location = new System.Drawing.Point(53, 270);
            this.livrosDataGridView.Name = "livrosDataGridView";
            this.livrosDataGridView.ReadOnly = true;
            this.livrosDataGridView.Size = new System.Drawing.Size(691, 268);
            this.livrosDataGridView.TabIndex = 13;
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
            this.dataGridViewTextBoxColumn4.HeaderText = "EDITORA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Dataedicao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dataedicao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Assunto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Assunto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
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
            // gob_inputs
            // 
            this.gob_inputs.Controls.Add(id_LivroLabel);
            this.gob_inputs.Controls.Add(this.id_LivroTextBox);
            this.gob_inputs.Controls.Add(tituloLabel);
            this.gob_inputs.Controls.Add(this.tituloTextBox);
            this.gob_inputs.Controls.Add(autoresLabel);
            this.gob_inputs.Controls.Add(this.autoresTextBox);
            this.gob_inputs.Controls.Add(eDITORALabel);
            this.gob_inputs.Controls.Add(this.eDITORATextBox);
            this.gob_inputs.Controls.Add(dataedicaoLabel);
            this.gob_inputs.Controls.Add(this.dataedicaoDateTimePicker);
            this.gob_inputs.Controls.Add(assuntoLabel);
            this.gob_inputs.Controls.Add(this.assuntoTextBox);
            this.gob_inputs.Location = new System.Drawing.Point(35, 88);
            this.gob_inputs.Name = "gob_inputs";
            this.gob_inputs.Size = new System.Drawing.Size(735, 152);
            this.gob_inputs.TabIndex = 14;
            this.gob_inputs.TabStop = false;
            // 
            // id_LivroTextBox
            // 
            this.id_LivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Id_Livro", true));
            this.id_LivroTextBox.Enabled = false;
            this.id_LivroTextBox.Location = new System.Drawing.Point(80, 15);
            this.id_LivroTextBox.Name = "id_LivroTextBox";
            this.id_LivroTextBox.Size = new System.Drawing.Size(284, 20);
            this.id_LivroTextBox.TabIndex = 14;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(80, 41);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(284, 20);
            this.tituloTextBox.TabIndex = 16;
            // 
            // autoresTextBox
            // 
            this.autoresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Autores", true));
            this.autoresTextBox.Location = new System.Drawing.Point(80, 67);
            this.autoresTextBox.Name = "autoresTextBox";
            this.autoresTextBox.Size = new System.Drawing.Size(284, 20);
            this.autoresTextBox.TabIndex = 18;
            // 
            // eDITORATextBox
            // 
            this.eDITORATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "EDITORA", true));
            this.eDITORATextBox.Location = new System.Drawing.Point(80, 93);
            this.eDITORATextBox.Name = "eDITORATextBox";
            this.eDITORATextBox.Size = new System.Drawing.Size(284, 20);
            this.eDITORATextBox.TabIndex = 20;
            // 
            // dataedicaoDateTimePicker
            // 
            this.dataedicaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.livrosBindingSource, "Dataedicao", true));
            this.dataedicaoDateTimePicker.Location = new System.Drawing.Point(80, 119);
            this.dataedicaoDateTimePicker.Name = "dataedicaoDateTimePicker";
            this.dataedicaoDateTimePicker.Size = new System.Drawing.Size(284, 20);
            this.dataedicaoDateTimePicker.TabIndex = 22;
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Assunto", true));
            this.assuntoTextBox.Location = new System.Drawing.Point(431, 18);
            this.assuntoTextBox.Multiline = true;
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(284, 124);
            this.assuntoTextBox.TabIndex = 24;
            // 
            // btnAtua
            // 
            this.btnAtua.Location = new System.Drawing.Point(51, 246);
            this.btnAtua.Name = "btnAtua";
            this.btnAtua.Size = new System.Drawing.Size(196, 23);
            this.btnAtua.TabIndex = 15;
            this.btnAtua.Text = "Atualizar";
            this.btnAtua.UseVisualStyleBackColor = true;
            this.btnAtua.Click += new System.EventHandler(this.btnAtua_Click);
            // 
            // frmCadLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 580);
            this.Controls.Add(this.btnAtua);
            this.Controls.Add(this.gob_inputs);
            this.Controls.Add(this.livrosDataGridView);
            this.Controls.Add(this.livrosBindingNavigator);
            this.Name = "frmCadLivros";
            this.Text = "Cadastro de Livros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadLivros_FormClosing);
            this.Load += new System.EventHandler(this.frmCadLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingNavigator)).EndInit();
            this.livrosBindingNavigator.ResumeLayout(false);
            this.livrosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).EndInit();
            this.gob_inputs.ResumeLayout(false);
            this.gob_inputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dados.dtsLivro dtsLivro;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private dados.dtsLivroTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private dados.dtsLivroTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator livrosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton livrosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView livrosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox gob_inputs;
        private System.Windows.Forms.TextBox id_LivroTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autoresTextBox;
        private System.Windows.Forms.TextBox eDITORATextBox;
        private System.Windows.Forms.DateTimePicker dataedicaoDateTimePicker;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.Button btnAtua;
    }
}