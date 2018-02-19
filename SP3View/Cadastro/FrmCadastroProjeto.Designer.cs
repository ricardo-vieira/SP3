namespace SP3View.Cadastro
{
    partial class FrmCadastroProjeto
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label dESCRICAOLabel;
            System.Windows.Forms.Label dATACRIACAOLabel;
            System.Windows.Forms.Label iDGERENTELabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProjeto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInativar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Localizar = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpInformacoes = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cblEsforcoAdicional = new System.Windows.Forms.CheckedListBox();
            this.cblApoioSteakHolders = new System.Windows.Forms.CheckedListBox();
            this.cblApoioAltaGestao = new System.Windows.Forms.CheckedListBox();
            this.cblCapacidadeEntregaEquipe = new System.Windows.Forms.CheckedListBox();
            this.nudPrevisaoConclusao = new System.Windows.Forms.NumericUpDown();
            this.txtDataHoraAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.bsProjeto = new System.Windows.Forms.BindingSource(this.components);
            this.txtNomeGerente = new System.Windows.Forms.TextBox();
            this.btnLocalizarGerente = new System.Windows.Forms.Button();
            this.txtIDGerente = new System.Windows.Forms.TextBox();
            this.txtDataCriacao = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCrescimentoFixo = new System.Windows.Forms.TextBox();
            this.rbtCrestimentoPercentual = new System.Windows.Forms.RadioButton();
            this.txtCrescimentoProporcional = new System.Windows.Forms.TextBox();
            this.ckbPermitirReceitasVariaveis = new System.Windows.Forms.CheckBox();
            this.rbtCrescimentoFixo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceitaFixa = new System.Windows.Forms.TextBox();
            this.txtInvestimentoPrevisto = new System.Windows.Forms.TextBox();
            this.tbpPessoasProjetos = new System.Windows.Forms.TabPage();
            this.dtgProjetoPessoa = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgProjetoPessoabtnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgProjetoPessoaBtnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.bsProjetoPessoa = new System.Windows.Forms.BindingSource(this.components);
            this.grbProjetosPessoasInformacoes = new System.Windows.Forms.GroupBox();
            this.txtProjetoPessoaObservacoes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpProjetoPessoaIngresso = new System.Windows.Forms.DateTimePicker();
            this.txtProjetoPessoaOcupacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProjetoPessoaNome = new System.Windows.Forms.TextBox();
            this.btnProjetoPessoaLocalizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProjetoPessoaCodigo = new System.Windows.Forms.TextBox();
            this.grbProjetosPessoasAcoes = new System.Windows.Forms.GroupBox();
            this.btnProjetoPessoaExcluir = new System.Windows.Forms.Button();
            this.btnProjetoPessoaAlterar = new System.Windows.Forms.Button();
            this.btnPessoaProjetoIncluir = new System.Windows.Forms.Button();
            this.tbpReceitasVariaveis = new System.Windows.Forms.TabPage();
            this.tbpReunioes = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            dESCRICAOLabel = new System.Windows.Forms.Label();
            dATACRIACAOLabel = new System.Windows.Forms.Label();
            iDGERENTELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpInformacoes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevisaoConclusao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjeto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tbpPessoasProjetos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProjetoPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetoPessoa)).BeginInit();
            this.grbProjetosPessoasInformacoes.SuspendLayout();
            this.grbProjetosPessoasAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(8, 19);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(55, 16);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "Código:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOMELabel.Location = new System.Drawing.Point(8, 47);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(48, 16);
            nOMELabel.TabIndex = 0;
            nOMELabel.Text = "Nome:";
            // 
            // dESCRICAOLabel
            // 
            dESCRICAOLabel.AutoSize = true;
            dESCRICAOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dESCRICAOLabel.Location = new System.Drawing.Point(8, 75);
            dESCRICAOLabel.Name = "dESCRICAOLabel";
            dESCRICAOLabel.Size = new System.Drawing.Size(73, 16);
            dESCRICAOLabel.TabIndex = 4;
            dESCRICAOLabel.Text = "Descrição:";
            // 
            // dATACRIACAOLabel
            // 
            dATACRIACAOLabel.AutoSize = true;
            dATACRIACAOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dATACRIACAOLabel.Location = new System.Drawing.Point(278, 19);
            dATACRIACAOLabel.Name = "dATACRIACAOLabel";
            dATACRIACAOLabel.Size = new System.Drawing.Size(124, 16);
            dATACRIACAOLabel.TabIndex = 6;
            dATACRIACAOLabel.Text = "Data/Hora Criação:";
            // 
            // iDGERENTELabel
            // 
            iDGERENTELabel.AutoSize = true;
            iDGERENTELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDGERENTELabel.Location = new System.Drawing.Point(8, 195);
            iDGERENTELabel.Name = "iDGERENTELabel";
            iDGERENTELabel.Size = new System.Drawing.Size(59, 16);
            iDGERENTELabel.TabIndex = 8;
            iDGERENTELabel.Text = "Gerente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(651, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 16);
            label1.TabIndex = 12;
            label1.Text = "Data/Hora Alteração:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(6, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 32);
            label2.TabIndex = 14;
            label2.Text = "Investimento \r\nPrevisto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(9, 223);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(81, 32);
            label5.TabIndex = 21;
            label5.Text = "Previsão de\r\nConclusão:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(197, 235);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 16);
            label6.TabIndex = 23;
            label6.Text = "Dias";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(6, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(140, 32);
            label4.TabIndex = 27;
            label4.Text = "Capacidade de \r\nentrega da Equipe:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(170, 38);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(160, 16);
            label7.TabIndex = 29;
            label7.Text = "Apoio da Alta Gestão:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(393, 22);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(107, 32);
            label8.TabIndex = 31;
            label8.Text = "Apoio dos \r\nSteakHolders:\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(623, 38);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(134, 16);
            label9.TabIndex = 33;
            label9.Text = "Esforço Adicional:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripSeparator2,
            this.btnEditar,
            this.toolStripSeparator5,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.btnCancelar,
            this.toolStripSeparator4,
            this.btnInativar,
            this.toolStripSeparator1,
            this.Localizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 57);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(54, 54);
            this.btnNovo.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 54);
            this.btnEditar.Text = "toolStripButton1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 57);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(54, 54);
            this.btnSalvar.Text = "toolStripButton1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(54, 54);
            this.btnCancelar.Text = "toolStripButton1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // btnInativar
            // 
            this.btnInativar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInativar.Image = ((System.Drawing.Image)(resources.GetObject("btnInativar.Image")));
            this.btnInativar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInativar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(54, 54);
            this.btnInativar.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // Localizar
            // 
            this.Localizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Localizar.Image = ((System.Drawing.Image)(resources.GetObject("Localizar.Image")));
            this.Localizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Localizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Localizar.Name = "Localizar";
            this.Localizar.Size = new System.Drawing.Size(54, 54);
            this.Localizar.Text = "toolStripButton1";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbpInformacoes);
            this.tabControl1.Controls.Add(this.tbpPessoasProjetos);
            this.tabControl1.Controls.Add(this.tbpReceitasVariaveis);
            this.tabControl1.Controls.Add(this.tbpReunioes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 544);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpInformacoes
            // 
            this.tbpInformacoes.AutoScroll = true;
            this.tbpInformacoes.BackColor = System.Drawing.Color.White;
            this.tbpInformacoes.Controls.Add(this.button1);
            this.tbpInformacoes.Controls.Add(this.groupBox2);
            this.tbpInformacoes.Controls.Add(this.nudPrevisaoConclusao);
            this.tbpInformacoes.Controls.Add(label6);
            this.tbpInformacoes.Controls.Add(label5);
            this.tbpInformacoes.Controls.Add(this.txtDataHoraAlteracao);
            this.tbpInformacoes.Controls.Add(label1);
            this.tbpInformacoes.Controls.Add(this.txtNomeGerente);
            this.tbpInformacoes.Controls.Add(this.btnLocalizarGerente);
            this.tbpInformacoes.Controls.Add(iDGERENTELabel);
            this.tbpInformacoes.Controls.Add(this.txtIDGerente);
            this.tbpInformacoes.Controls.Add(this.txtDataCriacao);
            this.tbpInformacoes.Controls.Add(dATACRIACAOLabel);
            this.tbpInformacoes.Controls.Add(dESCRICAOLabel);
            this.tbpInformacoes.Controls.Add(this.txtDescricao);
            this.tbpInformacoes.Controls.Add(iDLabel);
            this.tbpInformacoes.Controls.Add(this.txtID);
            this.tbpInformacoes.Controls.Add(nOMELabel);
            this.tbpInformacoes.Controls.Add(this.txtNome);
            this.tbpInformacoes.Controls.Add(this.groupBox3);
            this.tbpInformacoes.Location = new System.Drawing.Point(4, 28);
            this.tbpInformacoes.Name = "tbpInformacoes";
            this.tbpInformacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInformacoes.Size = new System.Drawing.Size(1000, 512);
            this.tbpInformacoes.TabIndex = 0;
            this.tbpInformacoes.Text = "Informações Principais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label9);
            this.groupBox2.Controls.Add(this.cblEsforcoAdicional);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Controls.Add(this.cblApoioSteakHolders);
            this.groupBox2.Controls.Add(label7);
            this.groupBox2.Controls.Add(this.cblApoioAltaGestao);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(this.cblCapacidadeEntregaEquipe);
            this.groupBox2.Location = new System.Drawing.Point(12, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 135);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "D. I. C. E.";
            // 
            // cblEsforcoAdicional
            // 
            this.cblEsforcoAdicional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblEsforcoAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblEsforcoAdicional.FormattingEnabled = true;
            this.cblEsforcoAdicional.Items.AddRange(new object[] {
            "Até 10%",
            "Entre 10% e 20%",
            "Entre 20% e 40%",
            "Acima de 40% "});
            this.cblEsforcoAdicional.Location = new System.Drawing.Point(626, 57);
            this.cblEsforcoAdicional.Name = "cblEsforcoAdicional";
            this.cblEsforcoAdicional.Size = new System.Drawing.Size(134, 68);
            this.cblEsforcoAdicional.TabIndex = 32;
            // 
            // cblApoioSteakHolders
            // 
            this.cblApoioSteakHolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblApoioSteakHolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblApoioSteakHolders.FormattingEnabled = true;
            this.cblApoioSteakHolders.Items.AddRange(new object[] {
            "Ancioso",
            "Dispostos",
            "Relutantes",
            "Fortemente Relutantes"});
            this.cblApoioSteakHolders.Location = new System.Drawing.Point(396, 57);
            this.cblApoioSteakHolders.Name = "cblApoioSteakHolders";
            this.cblApoioSteakHolders.Size = new System.Drawing.Size(164, 68);
            this.cblApoioSteakHolders.TabIndex = 30;
            // 
            // cblApoioAltaGestao
            // 
            this.cblApoioAltaGestao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblApoioAltaGestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblApoioAltaGestao.FormattingEnabled = true;
            this.cblApoioAltaGestao.Items.AddRange(new object[] {
            "Apoio Formal e Total",
            "Desejam Sucesso",
            "Neutro",
            "Relutantes"});
            this.cblApoioAltaGestao.Location = new System.Drawing.Point(173, 57);
            this.cblApoioAltaGestao.Name = "cblApoioAltaGestao";
            this.cblApoioAltaGestao.Size = new System.Drawing.Size(164, 68);
            this.cblApoioAltaGestao.TabIndex = 28;
            // 
            // cblCapacidadeEntregaEquipe
            // 
            this.cblCapacidadeEntregaEquipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblCapacidadeEntregaEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblCapacidadeEntregaEquipe.FormattingEnabled = true;
            this.cblCapacidadeEntregaEquipe.Items.AddRange(new object[] {
            "Muito Bom",
            "Bom",
            "Médio",
            "Pobre"});
            this.cblCapacidadeEntregaEquipe.Location = new System.Drawing.Point(9, 57);
            this.cblCapacidadeEntregaEquipe.Name = "cblCapacidadeEntregaEquipe";
            this.cblCapacidadeEntregaEquipe.Size = new System.Drawing.Size(119, 68);
            this.cblCapacidadeEntregaEquipe.TabIndex = 0;
            // 
            // nudPrevisaoConclusao
            // 
            this.nudPrevisaoConclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrevisaoConclusao.Location = new System.Drawing.Point(99, 233);
            this.nudPrevisaoConclusao.Name = "nudPrevisaoConclusao";
            this.nudPrevisaoConclusao.Size = new System.Drawing.Size(94, 22);
            this.nudPrevisaoConclusao.TabIndex = 24;
            this.nudPrevisaoConclusao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDataHoraAlteracao
            // 
            this.txtDataHoraAlteracao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjeto, "DATACRIACAO", true));
            this.txtDataHoraAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataHoraAlteracao.Location = new System.Drawing.Point(792, 16);
            this.txtDataHoraAlteracao.Name = "txtDataHoraAlteracao";
            this.txtDataHoraAlteracao.Size = new System.Drawing.Size(200, 22);
            this.txtDataHoraAlteracao.TabIndex = 13;
            // 
            // bsProjeto
            // 
            this.bsProjeto.DataSource = typeof(SP3Model.Projeto);
            // 
            // txtNomeGerente
            // 
            this.txtNomeGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGerente.Location = new System.Drawing.Point(200, 192);
            this.txtNomeGerente.Name = "txtNomeGerente";
            this.txtNomeGerente.Size = new System.Drawing.Size(792, 22);
            this.txtNomeGerente.TabIndex = 11;
            // 
            // btnLocalizarGerente
            // 
            this.btnLocalizarGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarGerente.Location = new System.Drawing.Point(161, 192);
            this.btnLocalizarGerente.Name = "btnLocalizarGerente";
            this.btnLocalizarGerente.Size = new System.Drawing.Size(32, 22);
            this.btnLocalizarGerente.TabIndex = 10;
            this.btnLocalizarGerente.Text = "...";
            this.btnLocalizarGerente.UseVisualStyleBackColor = true;
            // 
            // txtIDGerente
            // 
            this.txtIDGerente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjeto, "IDGERENTE", true));
            this.txtIDGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDGerente.Location = new System.Drawing.Point(99, 192);
            this.txtIDGerente.Name = "txtIDGerente";
            this.txtIDGerente.Size = new System.Drawing.Size(56, 22);
            this.txtIDGerente.TabIndex = 9;
            // 
            // txtDataCriacao
            // 
            this.txtDataCriacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjeto, "DATACRIACAO", true));
            this.txtDataCriacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCriacao.Location = new System.Drawing.Point(408, 16);
            this.txtDataCriacao.Name = "txtDataCriacao";
            this.txtDataCriacao.Size = new System.Drawing.Size(200, 22);
            this.txtDataCriacao.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjeto, "DESCRICAO", true));
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(99, 72);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(893, 114);
            this.txtDescricao.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjeto, "ID", true));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(99, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(94, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProjeto, "NOME", true));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(99, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(893, 22);
            this.txtNome.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCrescimentoFixo);
            this.groupBox3.Controls.Add(this.rbtCrestimentoPercentual);
            this.groupBox3.Controls.Add(this.txtCrescimentoProporcional);
            this.groupBox3.Controls.Add(this.ckbPermitirReceitasVariaveis);
            this.groupBox3.Controls.Add(this.rbtCrescimentoFixo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtReceitaFixa);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(this.txtInvestimentoPrevisto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 107);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Financeiros";
            // 
            // txtCrescimentoFixo
            // 
            this.txtCrescimentoFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrescimentoFixo.Location = new System.Drawing.Point(653, 50);
            this.txtCrescimentoFixo.Name = "txtCrescimentoFixo";
            this.txtCrescimentoFixo.Size = new System.Drawing.Size(146, 22);
            this.txtCrescimentoFixo.TabIndex = 1;
            // 
            // rbtCrestimentoPercentual
            // 
            this.rbtCrestimentoPercentual.AutoSize = true;
            this.rbtCrestimentoPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCrestimentoPercentual.Location = new System.Drawing.Point(456, 77);
            this.rbtCrestimentoPercentual.Name = "rbtCrestimentoPercentual";
            this.rbtCrestimentoPercentual.Size = new System.Drawing.Size(191, 20);
            this.rbtCrestimentoPercentual.TabIndex = 27;
            this.rbtCrestimentoPercentual.TabStop = true;
            this.rbtCrestimentoPercentual.Text = "Crescimento Percentual(%):";
            this.rbtCrestimentoPercentual.UseVisualStyleBackColor = true;
            // 
            // txtCrescimentoProporcional
            // 
            this.txtCrescimentoProporcional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrescimentoProporcional.Location = new System.Drawing.Point(653, 76);
            this.txtCrescimentoProporcional.Name = "txtCrescimentoProporcional";
            this.txtCrescimentoProporcional.Size = new System.Drawing.Size(146, 22);
            this.txtCrescimentoProporcional.TabIndex = 0;
            // 
            // ckbPermitirReceitasVariaveis
            // 
            this.ckbPermitirReceitasVariaveis.AutoSize = true;
            this.ckbPermitirReceitasVariaveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPermitirReceitasVariaveis.Location = new System.Drawing.Point(6, 53);
            this.ckbPermitirReceitasVariaveis.Name = "ckbPermitirReceitasVariaveis";
            this.ckbPermitirReceitasVariaveis.Size = new System.Drawing.Size(181, 20);
            this.ckbPermitirReceitasVariaveis.TabIndex = 16;
            this.ckbPermitirReceitasVariaveis.Text = "Permitir receitas variáveis";
            this.ckbPermitirReceitasVariaveis.UseVisualStyleBackColor = true;
            // 
            // rbtCrescimentoFixo
            // 
            this.rbtCrescimentoFixo.AutoSize = true;
            this.rbtCrescimentoFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCrescimentoFixo.Location = new System.Drawing.Point(456, 52);
            this.rbtCrescimentoFixo.Name = "rbtCrescimentoFixo";
            this.rbtCrescimentoFixo.Size = new System.Drawing.Size(132, 20);
            this.rbtCrescimentoFixo.TabIndex = 26;
            this.rbtCrescimentoFixo.TabStop = true;
            this.rbtCrescimentoFixo.Text = "Crescimento Fixo:";
            this.rbtCrescimentoFixo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Receita Fixa:";
            // 
            // txtReceitaFixa
            // 
            this.txtReceitaFixa.Location = new System.Drawing.Point(285, 51);
            this.txtReceitaFixa.Name = "txtReceitaFixa";
            this.txtReceitaFixa.Size = new System.Drawing.Size(136, 22);
            this.txtReceitaFixa.TabIndex = 17;
            // 
            // txtInvestimentoPrevisto
            // 
            this.txtInvestimentoPrevisto.Location = new System.Drawing.Point(98, 21);
            this.txtInvestimentoPrevisto.Name = "txtInvestimentoPrevisto";
            this.txtInvestimentoPrevisto.Size = new System.Drawing.Size(170, 22);
            this.txtInvestimentoPrevisto.TabIndex = 15;
            // 
            // tbpPessoasProjetos
            // 
            this.tbpPessoasProjetos.AutoScroll = true;
            this.tbpPessoasProjetos.BackColor = System.Drawing.Color.White;
            this.tbpPessoasProjetos.Controls.Add(this.dtgProjetoPessoa);
            this.tbpPessoasProjetos.Controls.Add(this.grbProjetosPessoasInformacoes);
            this.tbpPessoasProjetos.Controls.Add(this.grbProjetosPessoasAcoes);
            this.tbpPessoasProjetos.Location = new System.Drawing.Point(4, 28);
            this.tbpPessoasProjetos.Name = "tbpPessoasProjetos";
            this.tbpPessoasProjetos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPessoasProjetos.Size = new System.Drawing.Size(1000, 512);
            this.tbpPessoasProjetos.TabIndex = 1;
            this.tbpPessoasProjetos.Text = "Pessoas do Projeto";
            // 
            // dtgProjetoPessoa
            // 
            this.dtgProjetoPessoa.AllowUserToAddRows = false;
            this.dtgProjetoPessoa.AllowUserToDeleteRows = false;
            this.dtgProjetoPessoa.AutoGenerateColumns = false;
            this.dtgProjetoPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProjetoPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dtgProjetoPessoabtnEditar,
            this.dtgProjetoPessoaBtnExcluir});
            this.dtgProjetoPessoa.DataSource = this.bsProjetoPessoa;
            this.dtgProjetoPessoa.Location = new System.Drawing.Point(8, 146);
            this.dtgProjetoPessoa.Name = "dtgProjetoPessoa";
            this.dtgProjetoPessoa.ReadOnly = true;
            this.dtgProjetoPessoa.RowHeadersVisible = false;
            this.dtgProjetoPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProjetoPessoa.Size = new System.Drawing.Size(984, 361);
            this.dtgProjetoPessoa.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDPESSOA";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cód. Pessoa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomePessoa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Colaborador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 230;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OCUPACAO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ocupação";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OBSERVACOES";
            this.dataGridViewTextBoxColumn8.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DATAINGRESSO";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ingresso";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 135;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeProjeto";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeProjeto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDPROJETO";
            this.dataGridViewTextBoxColumn4.HeaderText = "IDPROJETO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Pessoa";
            this.dataGridViewTextBoxColumn9.HeaderText = "Pessoa";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Projeto";
            this.dataGridViewTextBoxColumn10.HeaderText = "Projeto";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dtgProjetoPessoabtnEditar
            // 
            this.dtgProjetoPessoabtnEditar.HeaderText = "";
            this.dtgProjetoPessoabtnEditar.Name = "dtgProjetoPessoabtnEditar";
            this.dtgProjetoPessoabtnEditar.ReadOnly = true;
            this.dtgProjetoPessoabtnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProjetoPessoabtnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtgProjetoPessoabtnEditar.Width = 20;
            // 
            // dtgProjetoPessoaBtnExcluir
            // 
            this.dtgProjetoPessoaBtnExcluir.HeaderText = "";
            this.dtgProjetoPessoaBtnExcluir.Name = "dtgProjetoPessoaBtnExcluir";
            this.dtgProjetoPessoaBtnExcluir.ReadOnly = true;
            this.dtgProjetoPessoaBtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProjetoPessoaBtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dtgProjetoPessoaBtnExcluir.Width = 20;
            // 
            // bsProjetoPessoa
            // 
            this.bsProjetoPessoa.DataSource = typeof(SP3Model.View.ProjetosPessoasInformacoesCompletas);
            // 
            // grbProjetosPessoasInformacoes
            // 
            this.grbProjetosPessoasInformacoes.Controls.Add(this.txtProjetoPessoaObservacoes);
            this.grbProjetosPessoasInformacoes.Controls.Add(this.label13);
            this.grbProjetosPessoasInformacoes.Controls.Add(this.label12);
            this.grbProjetosPessoasInformacoes.Controls.Add(this.dtpProjetoPessoaIngresso);
            this.grbProjetosPessoasInformacoes.Controls.Add(this.txtProjetoPessoaOcupacao);
            this.grbProjetosPessoasInformacoes.Controls.Add(this.label11);
            this.grbProjetosPessoasInformacoes.Controls.Add(this.txtProjetoPessoaNome);
            this.grbProjetosPessoasInformacoes.Controls.Add(this.btnProjetoPessoaLocalizar);
            this.grbProjetosPessoasInformacoes.Controls.Add(this.label10);
            this.grbProjetosPessoasInformacoes.Controls.Add(this.txtProjetoPessoaCodigo);
            this.grbProjetosPessoasInformacoes.Location = new System.Drawing.Point(140, 6);
            this.grbProjetosPessoasInformacoes.Name = "grbProjetosPessoasInformacoes";
            this.grbProjetosPessoasInformacoes.Size = new System.Drawing.Size(852, 134);
            this.grbProjetosPessoasInformacoes.TabIndex = 1;
            this.grbProjetosPessoasInformacoes.TabStop = false;
            this.grbProjetosPessoasInformacoes.Text = "Informações";
            // 
            // txtProjetoPessoaObservacoes
            // 
            this.txtProjetoPessoaObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjetoPessoaObservacoes.Location = new System.Drawing.Point(105, 79);
            this.txtProjetoPessoaObservacoes.Multiline = true;
            this.txtProjetoPessoaObservacoes.Name = "txtProjetoPessoaObservacoes";
            this.txtProjetoPessoaObservacoes.Size = new System.Drawing.Size(741, 49);
            this.txtProjetoPessoaObservacoes.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Observações:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(613, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Ingresso:";
            // 
            // dtpProjetoPessoaIngresso
            // 
            this.dtpProjetoPessoaIngresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProjetoPessoaIngresso.Location = new System.Drawing.Point(682, 48);
            this.dtpProjetoPessoaIngresso.Name = "dtpProjetoPessoaIngresso";
            this.dtpProjetoPessoaIngresso.Size = new System.Drawing.Size(164, 22);
            this.dtpProjetoPessoaIngresso.TabIndex = 6;
            // 
            // txtProjetoPessoaOcupacao
            // 
            this.txtProjetoPessoaOcupacao.Location = new System.Drawing.Point(105, 50);
            this.txtProjetoPessoaOcupacao.Name = "txtProjetoPessoaOcupacao";
            this.txtProjetoPessoaOcupacao.Size = new System.Drawing.Size(502, 22);
            this.txtProjetoPessoaOcupacao.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ocupação:";
            // 
            // txtProjetoPessoaNome
            // 
            this.txtProjetoPessoaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjetoPessoaNome.Location = new System.Drawing.Point(221, 21);
            this.txtProjetoPessoaNome.Name = "txtProjetoPessoaNome";
            this.txtProjetoPessoaNome.Size = new System.Drawing.Size(625, 22);
            this.txtProjetoPessoaNome.TabIndex = 3;
            // 
            // btnProjetoPessoaLocalizar
            // 
            this.btnProjetoPessoaLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjetoPessoaLocalizar.Location = new System.Drawing.Point(180, 20);
            this.btnProjetoPessoaLocalizar.Name = "btnProjetoPessoaLocalizar";
            this.btnProjetoPessoaLocalizar.Size = new System.Drawing.Size(35, 23);
            this.btnProjetoPessoaLocalizar.TabIndex = 2;
            this.btnProjetoPessoaLocalizar.Text = "...";
            this.btnProjetoPessoaLocalizar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Código:";
            // 
            // txtProjetoPessoaCodigo
            // 
            this.txtProjetoPessoaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjetoPessoaCodigo.Location = new System.Drawing.Point(105, 20);
            this.txtProjetoPessoaCodigo.Name = "txtProjetoPessoaCodigo";
            this.txtProjetoPessoaCodigo.Size = new System.Drawing.Size(69, 22);
            this.txtProjetoPessoaCodigo.TabIndex = 0;
            // 
            // grbProjetosPessoasAcoes
            // 
            this.grbProjetosPessoasAcoes.Controls.Add(this.btnProjetoPessoaExcluir);
            this.grbProjetosPessoasAcoes.Controls.Add(this.btnProjetoPessoaAlterar);
            this.grbProjetosPessoasAcoes.Controls.Add(this.btnPessoaProjetoIncluir);
            this.grbProjetosPessoasAcoes.Location = new System.Drawing.Point(8, 6);
            this.grbProjetosPessoasAcoes.Name = "grbProjetosPessoasAcoes";
            this.grbProjetosPessoasAcoes.Size = new System.Drawing.Size(126, 112);
            this.grbProjetosPessoasAcoes.TabIndex = 0;
            this.grbProjetosPessoasAcoes.TabStop = false;
            this.grbProjetosPessoasAcoes.Text = "Ações";
            // 
            // btnProjetoPessoaExcluir
            // 
            this.btnProjetoPessoaExcluir.Location = new System.Drawing.Point(6, 77);
            this.btnProjetoPessoaExcluir.Name = "btnProjetoPessoaExcluir";
            this.btnProjetoPessoaExcluir.Size = new System.Drawing.Size(114, 23);
            this.btnProjetoPessoaExcluir.TabIndex = 2;
            this.btnProjetoPessoaExcluir.Text = "Excluir";
            this.btnProjetoPessoaExcluir.UseVisualStyleBackColor = true;
            // 
            // btnProjetoPessoaAlterar
            // 
            this.btnProjetoPessoaAlterar.Location = new System.Drawing.Point(6, 48);
            this.btnProjetoPessoaAlterar.Name = "btnProjetoPessoaAlterar";
            this.btnProjetoPessoaAlterar.Size = new System.Drawing.Size(114, 23);
            this.btnProjetoPessoaAlterar.TabIndex = 1;
            this.btnProjetoPessoaAlterar.Text = "Alterar";
            this.btnProjetoPessoaAlterar.UseVisualStyleBackColor = true;
            // 
            // btnPessoaProjetoIncluir
            // 
            this.btnPessoaProjetoIncluir.Location = new System.Drawing.Point(6, 19);
            this.btnPessoaProjetoIncluir.Name = "btnPessoaProjetoIncluir";
            this.btnPessoaProjetoIncluir.Size = new System.Drawing.Size(114, 23);
            this.btnPessoaProjetoIncluir.TabIndex = 0;
            this.btnPessoaProjetoIncluir.Text = "Incluir";
            this.btnPessoaProjetoIncluir.UseVisualStyleBackColor = true;
            // 
            // tbpReceitasVariaveis
            // 
            this.tbpReceitasVariaveis.Location = new System.Drawing.Point(4, 28);
            this.tbpReceitasVariaveis.Name = "tbpReceitasVariaveis";
            this.tbpReceitasVariaveis.Size = new System.Drawing.Size(1000, 512);
            this.tbpReceitasVariaveis.TabIndex = 2;
            this.tbpReceitasVariaveis.Text = "Receitas Variáveis";
            this.tbpReceitasVariaveis.UseVisualStyleBackColor = true;
            // 
            // tbpReunioes
            // 
            this.tbpReunioes.Location = new System.Drawing.Point(4, 28);
            this.tbpReunioes.Name = "tbpReunioes";
            this.tbpReunioes.Size = new System.Drawing.Size(1000, 512);
            this.tbpReunioes.TabIndex = 3;
            this.tbpReunioes.Text = "Reuniões do Projeto";
            this.tbpReunioes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 22);
            this.button1.TabIndex = 28;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCadastroProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro - Projeto";
            this.Load += new System.EventHandler(this.FrmCadastroProjeto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpInformacoes.ResumeLayout(false);
            this.tbpInformacoes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevisaoConclusao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjeto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tbpPessoasProjetos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProjetoPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjetoPessoa)).EndInit();
            this.grbProjetosPessoasInformacoes.ResumeLayout(false);
            this.grbProjetosPessoasInformacoes.PerformLayout();
            this.grbProjetosPessoasAcoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnInativar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Localizar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpInformacoes;
        private System.Windows.Forms.TabPage tbpPessoasProjetos;
        private System.Windows.Forms.BindingSource bsProjeto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox txtDataCriacao;
        private System.Windows.Forms.Button btnLocalizarGerente;
        private System.Windows.Forms.TextBox txtIDGerente;
        private System.Windows.Forms.TextBox txtNomeGerente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox cblEsforcoAdicional;
        private System.Windows.Forms.CheckedListBox cblApoioSteakHolders;
        private System.Windows.Forms.CheckedListBox cblApoioAltaGestao;
        private System.Windows.Forms.CheckedListBox cblCapacidadeEntregaEquipe;
        private System.Windows.Forms.RadioButton rbtCrestimentoPercentual;
        private System.Windows.Forms.RadioButton rbtCrescimentoFixo;
        private System.Windows.Forms.TextBox txtCrescimentoFixo;
        private System.Windows.Forms.TextBox txtCrescimentoProporcional;
        private System.Windows.Forms.NumericUpDown nudPrevisaoConclusao;
        private System.Windows.Forms.TextBox txtReceitaFixa;
        private System.Windows.Forms.CheckBox ckbPermitirReceitasVariaveis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvestimentoPrevisto;
        private System.Windows.Forms.MaskedTextBox txtDataHoraAlteracao;
        private System.Windows.Forms.TabPage tbpReceitasVariaveis;
        private System.Windows.Forms.TabPage tbpReunioes;
        private System.Windows.Forms.GroupBox grbProjetosPessoasInformacoes;
        private System.Windows.Forms.GroupBox grbProjetosPessoasAcoes;
        private System.Windows.Forms.Button btnProjetoPessoaExcluir;
        private System.Windows.Forms.Button btnProjetoPessoaAlterar;
        private System.Windows.Forms.Button btnPessoaProjetoIncluir;
        private System.Windows.Forms.DataGridView dtgProjetoPessoa;
        private System.Windows.Forms.BindingSource bsProjetoPessoa;
        private System.Windows.Forms.TextBox txtProjetoPessoaObservacoes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpProjetoPessoaIngresso;
        private System.Windows.Forms.TextBox txtProjetoPessoaOcupacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProjetoPessoaNome;
        private System.Windows.Forms.Button btnProjetoPessoaLocalizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProjetoPessoaCodigo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dtgProjetoPessoabtnEditar;
        private System.Windows.Forms.DataGridViewImageColumn dtgProjetoPessoaBtnExcluir;
        private System.Windows.Forms.Button button1;
    }
}