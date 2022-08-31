namespace WindowsFormsApp1
{
    partial class frmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimparTexts = new System.Windows.Forms.Button();
            this.dgvAlimentos = new System.Windows.Forms.DataGridView();
            this.idalimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafabricacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aula_edsonDataSet = new WindowsFormsApp1.aula_edsonDataSet();
            this.btnListar = new System.Windows.Forms.Button();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.chkAlimento = new System.Windows.Forms.CheckBox();
            this.chkQuantidade = new System.Windows.Forms.CheckBox();
            this.chkDataFabricacao = new System.Windows.Forms.CheckBox();
            this.chkDataValidade = new System.Windows.Forms.CheckBox();
            this.chkPreco = new System.Windows.Forms.CheckBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnApagarv1 = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.alimentosTableAdapter = new WindowsFormsApp1.aula_edsonDataSetTableAdapters.alimentosTableAdapter();
            this.aulaedsonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alimentosTableAdapter1 = new WindowsFormsApp1.aula_edsonDataSetTableAdapters.alimentosTableAdapter();
            this.aula_edsonDataSet1 = new WindowsFormsApp1.aula_edsonDataSet();
            this.aulaedsonDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnApagarv2 = new System.Windows.Forms.Button();
            this.txtDataFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.txtDataValidade = new System.Windows.Forms.MaskedTextBox();
            this.lblConsultadata = new System.Windows.Forms.Label();
            this.lblFab = new System.Windows.Forms.Label();
            this.lblVali = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.txtFab = new System.Windows.Forms.MaskedTextBox();
            this.txtVali = new System.Windows.Forms.MaskedTextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_edsonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaedsonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_edsonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaedsonDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de fabricação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Validade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Preço";
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(118, 36);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(100, 20);
            this.txtAlimento.TabIndex = 7;
            
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(118, 139);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 172);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(143, 172);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimparTexts
            // 
            this.btnLimparTexts.Location = new System.Drawing.Point(15, 201);
            this.btnLimparTexts.Name = "btnLimparTexts";
            this.btnLimparTexts.Size = new System.Drawing.Size(75, 23);
            this.btnLimparTexts.TabIndex = 14;
            this.btnLimparTexts.Text = "Limpar Texts";
            this.btnLimparTexts.UseVisualStyleBackColor = true;
            this.btnLimparTexts.Click += new System.EventHandler(this.btnLimparTexts_Click);
            // 
            // dgvAlimentos
            // 
            this.dgvAlimentos.AutoGenerateColumns = false;
            this.dgvAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalimentoDataGridViewTextBoxColumn,
            this.alimentoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.datafabricacaoDataGridViewTextBoxColumn,
            this.datavalidadeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn});
            this.dgvAlimentos.DataSource = this.alimentosBindingSource;
            this.dgvAlimentos.Location = new System.Drawing.Point(270, 68);
            this.dgvAlimentos.Name = "dgvAlimentos";
            this.dgvAlimentos.Size = new System.Drawing.Size(605, 239);
            this.dgvAlimentos.TabIndex = 15;
            this.dgvAlimentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlimentos_CellClick);
            // 
            // idalimentoDataGridViewTextBoxColumn
            // 
            this.idalimentoDataGridViewTextBoxColumn.DataPropertyName = "id_alimento";
            this.idalimentoDataGridViewTextBoxColumn.HeaderText = "id_alimento";
            this.idalimentoDataGridViewTextBoxColumn.Name = "idalimentoDataGridViewTextBoxColumn";
            // 
            // alimentoDataGridViewTextBoxColumn
            // 
            this.alimentoDataGridViewTextBoxColumn.DataPropertyName = "alimento";
            this.alimentoDataGridViewTextBoxColumn.HeaderText = "alimento";
            this.alimentoDataGridViewTextBoxColumn.Name = "alimentoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // datafabricacaoDataGridViewTextBoxColumn
            // 
            this.datafabricacaoDataGridViewTextBoxColumn.DataPropertyName = "data_fabricacao";
            this.datafabricacaoDataGridViewTextBoxColumn.HeaderText = "data_fabricacao";
            this.datafabricacaoDataGridViewTextBoxColumn.Name = "datafabricacaoDataGridViewTextBoxColumn";
            // 
            // datavalidadeDataGridViewTextBoxColumn
            // 
            this.datavalidadeDataGridViewTextBoxColumn.DataPropertyName = "data_validade";
            this.datavalidadeDataGridViewTextBoxColumn.HeaderText = "data_validade";
            this.datavalidadeDataGridViewTextBoxColumn.Name = "datavalidadeDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // alimentosBindingSource
            // 
            this.alimentosBindingSource.DataMember = "alimentos";
            this.alimentosBindingSource.DataSource = this.aula_edsonDataSet;
            // 
            // aula_edsonDataSet
            // 
            this.aula_edsonDataSet.DataSetName = "aula_edsonDataSet";
            this.aula_edsonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(270, 325);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Checked = true;
            this.chkID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkID.Location = new System.Drawing.Point(284, 45);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(35, 17);
            this.chkID.TabIndex = 17;
            this.chkID.Text = "Id";
            this.chkID.UseVisualStyleBackColor = true;
            this.chkID.Click += new System.EventHandler(this.chkID_Click);
            // 
            // chkAlimento
            // 
            this.chkAlimento.AutoSize = true;
            this.chkAlimento.Checked = true;
            this.chkAlimento.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlimento.Location = new System.Drawing.Point(325, 45);
            this.chkAlimento.Name = "chkAlimento";
            this.chkAlimento.Size = new System.Drawing.Size(66, 17);
            this.chkAlimento.TabIndex = 18;
            this.chkAlimento.Text = "Alimento";
            this.chkAlimento.UseVisualStyleBackColor = true;
            this.chkAlimento.Click += new System.EventHandler(this.chkAlimento_Click);
            // 
            // chkQuantidade
            // 
            this.chkQuantidade.AutoSize = true;
            this.chkQuantidade.Checked = true;
            this.chkQuantidade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQuantidade.Location = new System.Drawing.Point(414, 45);
            this.chkQuantidade.Name = "chkQuantidade";
            this.chkQuantidade.Size = new System.Drawing.Size(81, 17);
            this.chkQuantidade.TabIndex = 19;
            this.chkQuantidade.Text = "Quantidade";
            this.chkQuantidade.UseVisualStyleBackColor = true;
            this.chkQuantidade.Click += new System.EventHandler(this.chkQuantidade_Click);
            // 
            // chkDataFabricacao
            // 
            this.chkDataFabricacao.AutoSize = true;
            this.chkDataFabricacao.Checked = true;
            this.chkDataFabricacao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataFabricacao.Location = new System.Drawing.Point(501, 45);
            this.chkDataFabricacao.Name = "chkDataFabricacao";
            this.chkDataFabricacao.Size = new System.Drawing.Size(105, 17);
            this.chkDataFabricacao.TabIndex = 20;
            this.chkDataFabricacao.Text = "Data Fabricação";
            this.chkDataFabricacao.UseVisualStyleBackColor = true;
            this.chkDataFabricacao.Click += new System.EventHandler(this.chkDataFabricacao_Click);
            // 
            // chkDataValidade
            // 
            this.chkDataValidade.AutoSize = true;
            this.chkDataValidade.Checked = true;
            this.chkDataValidade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDataValidade.Location = new System.Drawing.Point(612, 45);
            this.chkDataValidade.Name = "chkDataValidade";
            this.chkDataValidade.Size = new System.Drawing.Size(93, 17);
            this.chkDataValidade.TabIndex = 21;
            this.chkDataValidade.Text = "Data Validade";
            this.chkDataValidade.UseVisualStyleBackColor = true;
            this.chkDataValidade.Click += new System.EventHandler(this.chkDataValidade_Click);
            // 
            // chkPreco
            // 
            this.chkPreco.AutoSize = true;
            this.chkPreco.Checked = true;
            this.chkPreco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreco.Location = new System.Drawing.Point(711, 45);
            this.chkPreco.Name = "chkPreco";
            this.chkPreco.Size = new System.Drawing.Size(54, 17);
            this.chkPreco.TabIndex = 22;
            this.chkPreco.Text = "Preço";
            this.chkPreco.UseVisualStyleBackColor = true;
            this.chkPreco.Click += new System.EventHandler(this.chkPreco_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(15, 230);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 24);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnApagarv1
            // 
            this.btnApagarv1.Location = new System.Drawing.Point(143, 201);
            this.btnApagarv1.Name = "btnApagarv1";
            this.btnApagarv1.Size = new System.Drawing.Size(75, 24);
            this.btnApagarv1.TabIndex = 24;
            this.btnApagarv1.Text = "Apagar V1";
            this.btnApagarv1.UseVisualStyleBackColor = true;
            this.btnApagarv1.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Location = new System.Drawing.Point(771, 45);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(55, 17);
            this.chkAtivo.TabIndex = 25;
            this.chkAtivo.Text = "Ativos";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.Click += new System.EventHandler(this.chkAtivo_Click);
            // 
            // alimentosTableAdapter
            // 
            this.alimentosTableAdapter.ClearBeforeFill = true;
            // 
            // aulaedsonDataSetBindingSource
            // 
            this.aulaedsonDataSetBindingSource.DataSource = this.aula_edsonDataSet;
            this.aulaedsonDataSetBindingSource.Position = 0;
            // 
            // alimentosTableAdapter1
            // 
            this.alimentosTableAdapter1.ClearBeforeFill = true;
            // 
            // aula_edsonDataSet1
            // 
            this.aula_edsonDataSet1.DataSetName = "aula_edsonDataSet";
            this.aula_edsonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulaedsonDataSetBindingSource1
            // 
            this.aulaedsonDataSetBindingSource1.DataSource = this.aula_edsonDataSet;
            this.aulaedsonDataSetBindingSource1.Position = 0;
            // 
            // btnApagarv2
            // 
            this.btnApagarv2.Location = new System.Drawing.Point(143, 231);
            this.btnApagarv2.Name = "btnApagarv2";
            this.btnApagarv2.Size = new System.Drawing.Size(75, 24);
            this.btnApagarv2.TabIndex = 26;
            this.btnApagarv2.Text = "Apagar V2";
            this.btnApagarv2.UseVisualStyleBackColor = true;
            this.btnApagarv2.Click += new System.EventHandler(this.btnApagarv2_Click);
            // 
            // txtDataFabricacao
            // 
            this.txtDataFabricacao.Location = new System.Drawing.Point(118, 87);
            this.txtDataFabricacao.Mask = "00/00/0000";
            this.txtDataFabricacao.Name = "txtDataFabricacao";
            this.txtDataFabricacao.Size = new System.Drawing.Size(100, 20);
            this.txtDataFabricacao.TabIndex = 27;
            this.txtDataFabricacao.ValidatingType = typeof(System.DateTime);
            //this.txtDataFabricacao.TextChanged += new System.EventHandler(this.txtDataFabricacao_TextChanged);
            // 
            // txtDataValidade
            // 
            this.txtDataValidade.Location = new System.Drawing.Point(118, 113);
            this.txtDataValidade.Mask = "00/00/0000";
            this.txtDataValidade.Name = "txtDataValidade";
            this.txtDataValidade.Size = new System.Drawing.Size(100, 20);
            this.txtDataValidade.TabIndex = 28;
            this.txtDataValidade.ValidatingType = typeof(System.DateTime);
            //this.txtDataValidade.TextChanged += new System.EventHandler(this.txtDataValidade_TextChanged);
            // 
            // lblConsultadata
            // 
            this.lblConsultadata.AutoSize = true;
            this.lblConsultadata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConsultadata.Location = new System.Drawing.Point(9, 270);
            this.lblConsultadata.Name = "lblConsultadata";
            this.lblConsultadata.Size = new System.Drawing.Size(101, 13);
            this.lblConsultadata.TabIndex = 29;
            this.lblConsultadata.Text = "Consultar pela data:";
            // 
            // lblFab
            // 
            this.lblFab.AutoSize = true;
            this.lblFab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFab.Location = new System.Drawing.Point(12, 294);
            this.lblFab.Name = "lblFab";
            this.lblFab.Size = new System.Drawing.Size(98, 13);
            this.lblFab.TabIndex = 30;
            this.lblFab.Text = "Data de fabricação";
            // 
            // lblVali
            // 
            this.lblVali.AutoSize = true;
            this.lblVali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVali.Location = new System.Drawing.Point(12, 320);
            this.lblVali.Name = "lblVali";
            this.lblVali.Size = new System.Drawing.Size(89, 13);
            this.lblVali.TabIndex = 31;
            this.lblVali.Text = "Data de Validade";
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(118, 10);
            this.txtID.Mask = "00000";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 32;
            this.txtID.ValidatingType = typeof(int);
            //this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(118, 61);
            this.txtQuantidade.Mask = "00000";
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 33;
            this.txtQuantidade.ValidatingType = typeof(int);
            //this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // txtFab
            // 
            this.txtFab.Location = new System.Drawing.Point(118, 291);
            this.txtFab.Mask = "00/00/0000";
            this.txtFab.Name = "txtFab";
            this.txtFab.Size = new System.Drawing.Size(100, 20);
            this.txtFab.TabIndex = 34;
            this.txtFab.ValidatingType = typeof(System.DateTime);
            // 
            // txtVali
            // 
            this.txtVali.Location = new System.Drawing.Point(118, 317);
            this.txtVali.Mask = "00/00/0000";
            this.txtVali.Name = "txtVali";
            this.txtVali.Size = new System.Drawing.Size(100, 20);
            this.txtVali.TabIndex = 35;
            this.txtVali.ValidatingType = typeof(System.DateTime);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(129, 348);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 36;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 383);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtVali);
            this.Controls.Add(this.txtFab);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblVali);
            this.Controls.Add(this.lblFab);
            this.Controls.Add(this.lblConsultadata);
            this.Controls.Add(this.txtDataValidade);
            this.Controls.Add(this.txtDataFabricacao);
            this.Controls.Add(this.btnApagarv2);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.btnApagarv1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.chkPreco);
            this.Controls.Add(this.chkDataValidade);
            this.Controls.Add(this.chkDataFabricacao);
            this.Controls.Add(this.chkQuantidade);
            this.Controls.Add(this.chkAlimento);
            this.Controls.Add(this.chkID);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvAlimentos);
            this.Controls.Add(this.btnLimparTexts);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_edsonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaedsonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aula_edsonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaedsonDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimparTexts;
        private System.Windows.Forms.DataGridView dgvAlimentos;
        private System.Windows.Forms.Button btnListar;
        private aula_edsonDataSet aula_edsonDataSet;
        private System.Windows.Forms.BindingSource alimentosBindingSource;
        private aula_edsonDataSetTableAdapters.alimentosTableAdapter alimentosTableAdapter;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.CheckBox chkAlimento;
        private System.Windows.Forms.CheckBox chkQuantidade;
        private System.Windows.Forms.CheckBox chkDataFabricacao;
        private System.Windows.Forms.CheckBox chkDataValidade;
        private System.Windows.Forms.CheckBox chkPreco;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnApagarv1;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.BindingSource aulaedsonDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafabricacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private aula_edsonDataSetTableAdapters.alimentosTableAdapter alimentosTableAdapter1;
        private aula_edsonDataSet aula_edsonDataSet1;
        private System.Windows.Forms.BindingSource aulaedsonDataSetBindingSource1;
        private System.Windows.Forms.Button btnApagarv2;
        private System.Windows.Forms.MaskedTextBox txtDataFabricacao;
        private System.Windows.Forms.MaskedTextBox txtDataValidade;
        private System.Windows.Forms.Label lblConsultadata;
        private System.Windows.Forms.Label lblFab;
        private System.Windows.Forms.Label lblVali;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtQuantidade;
        private System.Windows.Forms.MaskedTextBox txtFab;
        private System.Windows.Forms.MaskedTextBox txtVali;
        private System.Windows.Forms.Button btnProcurar;
    }
}

