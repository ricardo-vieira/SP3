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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProjeto));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label dESCRICAOLabel;
            System.Windows.Forms.Label dATACRIACAOLabel;
            System.Windows.Forms.Label iDGERENTELabel;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnInativar = new System.Windows.Forms.ToolStripButton();
            this.Localizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpInformacoes = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.projetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.dATACRIACAOMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.iDGERENTETextBox = new System.Windows.Forms.TextBox();
            this.btnGerente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            dESCRICAOLabel = new System.Windows.Forms.Label();
            dATACRIACAOLabel = new System.Windows.Forms.Label();
            iDGERENTELabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 57);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tbpInformacoes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.tbpInformacoes.Controls.Add(this.textBox1);
            this.tbpInformacoes.Controls.Add(this.btnGerente);
            this.tbpInformacoes.Controls.Add(iDGERENTELabel);
            this.tbpInformacoes.Controls.Add(this.iDGERENTETextBox);
            this.tbpInformacoes.Controls.Add(this.dATACRIACAOMaskedTextBox);
            this.tbpInformacoes.Controls.Add(dATACRIACAOLabel);
            this.tbpInformacoes.Controls.Add(dESCRICAOLabel);
            this.tbpInformacoes.Controls.Add(this.dESCRICAOTextBox);
            this.tbpInformacoes.Controls.Add(iDLabel);
            this.tbpInformacoes.Controls.Add(this.txtID);
            this.tbpInformacoes.Controls.Add(nOMELabel);
            this.tbpInformacoes.Controls.Add(this.nOMETextBox);
            this.tbpInformacoes.Location = new System.Drawing.Point(4, 25);
            this.tbpInformacoes.Name = "tbpInformacoes";
            this.tbpInformacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInformacoes.Size = new System.Drawing.Size(1000, 515);
            this.tbpInformacoes.TabIndex = 0;
            this.tbpInformacoes.Text = "Informações";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // projetoBindingSource
            // 
            this.projetoBindingSource.DataSource = typeof(SP3Model.Projeto);
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetoBindingSource, "NOME", true));
            this.nOMETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOMETextBox.Location = new System.Drawing.Point(87, 44);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(905, 22);
            this.nOMETextBox.TabIndex = 1;
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
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetoBindingSource, "ID", true));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(87, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(106, 22);
            this.txtID.TabIndex = 3;
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
            // dESCRICAOTextBox
            // 
            this.dESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetoBindingSource, "DESCRICAO", true));
            this.dESCRICAOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCRICAOTextBox.Location = new System.Drawing.Point(87, 72);
            this.dESCRICAOTextBox.Multiline = true;
            this.dESCRICAOTextBox.Name = "dESCRICAOTextBox";
            this.dESCRICAOTextBox.Size = new System.Drawing.Size(905, 114);
            this.dESCRICAOTextBox.TabIndex = 5;
            // 
            // dATACRIACAOLabel
            // 
            dATACRIACAOLabel.AutoSize = true;
            dATACRIACAOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dATACRIACAOLabel.Location = new System.Drawing.Point(662, 19);
            dATACRIACAOLabel.Name = "dATACRIACAOLabel";
            dATACRIACAOLabel.Size = new System.Drawing.Size(124, 16);
            dATACRIACAOLabel.TabIndex = 6;
            dATACRIACAOLabel.Text = "Data/Hora Criação:";
            // 
            // dATACRIACAOMaskedTextBox
            // 
            this.dATACRIACAOMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetoBindingSource, "DATACRIACAO", true));
            this.dATACRIACAOMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dATACRIACAOMaskedTextBox.Location = new System.Drawing.Point(792, 18);
            this.dATACRIACAOMaskedTextBox.Name = "dATACRIACAOMaskedTextBox";
            this.dATACRIACAOMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.dATACRIACAOMaskedTextBox.TabIndex = 8;
            // 
            // iDGERENTETextBox
            // 
            this.iDGERENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetoBindingSource, "IDGERENTE", true));
            this.iDGERENTETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDGERENTETextBox.Location = new System.Drawing.Point(87, 192);
            this.iDGERENTETextBox.Name = "iDGERENTETextBox";
            this.iDGERENTETextBox.Size = new System.Drawing.Size(68, 22);
            this.iDGERENTETextBox.TabIndex = 9;
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
            // btnGerente
            // 
            this.btnGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerente.Location = new System.Drawing.Point(161, 192);
            this.btnGerente.Name = "btnGerente";
            this.btnGerente.Size = new System.Drawing.Size(32, 22);
            this.btnGerente.TabIndex = 10;
            this.btnGerente.Text = "...";
            this.btnGerente.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(200, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(792, 22);
            this.textBox1.TabIndex = 11;
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpInformacoes.ResumeLayout(false);
            this.tbpInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoBindingSource)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource projetoBindingSource;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox dESCRICAOTextBox;
        private System.Windows.Forms.MaskedTextBox dATACRIACAOMaskedTextBox;
        private System.Windows.Forms.Button btnGerente;
        private System.Windows.Forms.TextBox iDGERENTETextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}