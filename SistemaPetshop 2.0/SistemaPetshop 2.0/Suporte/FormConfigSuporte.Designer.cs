namespace SistemaPetshop_2._0.Suporte
{
    partial class FormConfigSuporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigSuporte));
            this.grpconfigbd = new System.Windows.Forms.GroupBox();
            this.cbxbanco = new System.Windows.Forms.ComboBox();
            this.btnCriarBanco = new System.Windows.Forms.Button();
            this.btnTestar = new System.Windows.Forms.Button();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtbanco = new System.Windows.Forms.TextBox();
            this.txtservidor = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblbanco = new System.Windows.Forms.Label();
            this.lblservidor = new System.Windows.Forms.Label();
            this.grplicensa = new System.Windows.Forms.GroupBox();
            this.rdbdemonstracao = new System.Windows.Forms.RadioButton();
            this.rdbatualizacaoanual = new System.Windows.Forms.RadioButton();
            this.rdbatualizacaosemestral = new System.Windows.Forms.RadioButton();
            this.rdbatmensal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpval = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpinstalacao = new System.Windows.Forms.DateTimePicker();
            this.chkmovestoque = new System.Windows.Forms.CheckBox();
            this.chkfinanceiro = new System.Windows.Forms.CheckBox();
            this.chkbanhoetosa = new System.Windows.Forms.CheckBox();
            this.chkmenuvenda = new System.Windows.Forms.CheckBox();
            this.grpControles = new System.Windows.Forms.GroupBox();
            this.validacpfcnpj = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblidconfig = new System.Windows.Forms.Label();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.grpconfigbd.SuspendLayout();
            this.grplicensa.SuspendLayout();
            this.grpControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpconfigbd
            // 
            this.grpconfigbd.Controls.Add(this.cbxbanco);
            this.grpconfigbd.Controls.Add(this.btnCriarBanco);
            this.grpconfigbd.Controls.Add(this.btnTestar);
            this.grpconfigbd.Controls.Add(this.txtsenha);
            this.grpconfigbd.Controls.Add(this.txtusuario);
            this.grpconfigbd.Controls.Add(this.txtbanco);
            this.grpconfigbd.Controls.Add(this.txtservidor);
            this.grpconfigbd.Controls.Add(this.lblsenha);
            this.grpconfigbd.Controls.Add(this.lblusuario);
            this.grpconfigbd.Controls.Add(this.lblbanco);
            this.grpconfigbd.Controls.Add(this.lblservidor);
            this.grpconfigbd.Location = new System.Drawing.Point(12, 33);
            this.grpconfigbd.Name = "grpconfigbd";
            this.grpconfigbd.Size = new System.Drawing.Size(377, 228);
            this.grpconfigbd.TabIndex = 1;
            this.grpconfigbd.TabStop = false;
            this.grpconfigbd.Text = "Configuração do Banco";
            // 
            // cbxbanco
            // 
            this.cbxbanco.FormattingEnabled = true;
            this.cbxbanco.Items.AddRange(new object[] {
            "Padrao",
            "Atual"});
            this.cbxbanco.Location = new System.Drawing.Point(257, 28);
            this.cbxbanco.Name = "cbxbanco";
            this.cbxbanco.Size = new System.Drawing.Size(102, 21);
            this.cbxbanco.TabIndex = 11;
            this.cbxbanco.SelectedIndexChanged += new System.EventHandler(this.cbxbanco_SelectedIndexChanged);
            // 
            // btnCriarBanco
            // 
            this.btnCriarBanco.Location = new System.Drawing.Point(85, 174);
            this.btnCriarBanco.Name = "btnCriarBanco";
            this.btnCriarBanco.Size = new System.Drawing.Size(75, 23);
            this.btnCriarBanco.TabIndex = 10;
            this.btnCriarBanco.Text = "Criar Banco";
            this.btnCriarBanco.UseVisualStyleBackColor = true;
            this.btnCriarBanco.Visible = false;
            this.btnCriarBanco.Click += new System.EventHandler(this.btnCriarBanco_Click);
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(174, 174);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(75, 23);
            this.btnTestar.TabIndex = 9;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(76, 129);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(173, 20);
            this.txtsenha.TabIndex = 7;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(76, 100);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(173, 20);
            this.txtusuario.TabIndex = 6;
            // 
            // txtbanco
            // 
            this.txtbanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbanco.Location = new System.Drawing.Point(76, 64);
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.Size = new System.Drawing.Size(173, 20);
            this.txtbanco.TabIndex = 5;
            // 
            // txtservidor
            // 
            this.txtservidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtservidor.Location = new System.Drawing.Point(76, 29);
            this.txtservidor.Name = "txtservidor";
            this.txtservidor.Size = new System.Drawing.Size(173, 20);
            this.txtservidor.TabIndex = 4;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(12, 129);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(41, 13);
            this.lblsenha.TabIndex = 3;
            this.lblsenha.Text = "Senha:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(12, 100);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(46, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblbanco
            // 
            this.lblbanco.AutoSize = true;
            this.lblbanco.Location = new System.Drawing.Point(12, 67);
            this.lblbanco.Name = "lblbanco";
            this.lblbanco.Size = new System.Drawing.Size(41, 13);
            this.lblbanco.TabIndex = 1;
            this.lblbanco.Text = "Banco:";
            // 
            // lblservidor
            // 
            this.lblservidor.AutoSize = true;
            this.lblservidor.Location = new System.Drawing.Point(12, 32);
            this.lblservidor.Name = "lblservidor";
            this.lblservidor.Size = new System.Drawing.Size(49, 13);
            this.lblservidor.TabIndex = 0;
            this.lblservidor.Text = "Servidor:";
            // 
            // grplicensa
            // 
            this.grplicensa.Controls.Add(this.rdbdemonstracao);
            this.grplicensa.Controls.Add(this.rdbatualizacaoanual);
            this.grplicensa.Controls.Add(this.rdbatualizacaosemestral);
            this.grplicensa.Controls.Add(this.rdbatmensal);
            this.grplicensa.Controls.Add(this.label2);
            this.grplicensa.Controls.Add(this.dtpval);
            this.grplicensa.Controls.Add(this.label1);
            this.grplicensa.Controls.Add(this.dtpinstalacao);
            this.grplicensa.Location = new System.Drawing.Point(396, 33);
            this.grplicensa.Name = "grplicensa";
            this.grplicensa.Size = new System.Drawing.Size(382, 118);
            this.grplicensa.TabIndex = 2;
            this.grplicensa.TabStop = false;
            this.grplicensa.Text = "Configuração  de Licensa";
            // 
            // rdbdemonstracao
            // 
            this.rdbdemonstracao.AutoSize = true;
            this.rdbdemonstracao.Location = new System.Drawing.Point(16, 19);
            this.rdbdemonstracao.Name = "rdbdemonstracao";
            this.rdbdemonstracao.Size = new System.Drawing.Size(124, 17);
            this.rdbdemonstracao.TabIndex = 11;
            this.rdbdemonstracao.TabStop = true;
            this.rdbdemonstracao.Text = "Versao Demostracao";
            this.rdbdemonstracao.UseVisualStyleBackColor = true;
            // 
            // rdbatualizacaoanual
            // 
            this.rdbatualizacaoanual.AutoSize = true;
            this.rdbatualizacaoanual.Location = new System.Drawing.Point(16, 87);
            this.rdbatualizacaoanual.Name = "rdbatualizacaoanual";
            this.rdbatualizacaoanual.Size = new System.Drawing.Size(110, 17);
            this.rdbatualizacaoanual.TabIndex = 10;
            this.rdbatualizacaoanual.TabStop = true;
            this.rdbatualizacaoanual.Text = "Atualização Anual";
            this.rdbatualizacaoanual.UseVisualStyleBackColor = true;
            // 
            // rdbatualizacaosemestral
            // 
            this.rdbatualizacaosemestral.AutoSize = true;
            this.rdbatualizacaosemestral.Location = new System.Drawing.Point(16, 65);
            this.rdbatualizacaosemestral.Name = "rdbatualizacaosemestral";
            this.rdbatualizacaosemestral.Size = new System.Drawing.Size(129, 17);
            this.rdbatualizacaosemestral.TabIndex = 9;
            this.rdbatualizacaosemestral.TabStop = true;
            this.rdbatualizacaosemestral.Text = "Atualização Semestral";
            this.rdbatualizacaosemestral.UseVisualStyleBackColor = true;
            // 
            // rdbatmensal
            // 
            this.rdbatmensal.AutoSize = true;
            this.rdbatmensal.Location = new System.Drawing.Point(16, 43);
            this.rdbatmensal.Name = "rdbatmensal";
            this.rdbatmensal.Size = new System.Drawing.Size(117, 17);
            this.rdbatmensal.TabIndex = 8;
            this.rdbatmensal.TabStop = true;
            this.rdbatmensal.Text = "Atualização Mensal";
            this.rdbatmensal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Validade:";
            // 
            // dtpval
            // 
            this.dtpval.Enabled = false;
            this.dtpval.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpval.Location = new System.Drawing.Point(282, 55);
            this.dtpval.Name = "dtpval";
            this.dtpval.Size = new System.Drawing.Size(94, 20);
            this.dtpval.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Instalação:";
            // 
            // dtpinstalacao
            // 
            this.dtpinstalacao.Enabled = false;
            this.dtpinstalacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinstalacao.Location = new System.Drawing.Point(282, 21);
            this.dtpinstalacao.Name = "dtpinstalacao";
            this.dtpinstalacao.Size = new System.Drawing.Size(94, 20);
            this.dtpinstalacao.TabIndex = 3;
            // 
            // chkmovestoque
            // 
            this.chkmovestoque.AutoSize = true;
            this.chkmovestoque.Location = new System.Drawing.Point(9, 30);
            this.chkmovestoque.Name = "chkmovestoque";
            this.chkmovestoque.Size = new System.Drawing.Size(120, 17);
            this.chkmovestoque.TabIndex = 0;
            this.chkmovestoque.Text = "Movimenta Estoque";
            this.chkmovestoque.UseVisualStyleBackColor = true;
            // 
            // chkfinanceiro
            // 
            this.chkfinanceiro.AutoSize = true;
            this.chkfinanceiro.Location = new System.Drawing.Point(9, 53);
            this.chkfinanceiro.Name = "chkfinanceiro";
            this.chkfinanceiro.Size = new System.Drawing.Size(106, 17);
            this.chkfinanceiro.TabIndex = 1;
            this.chkfinanceiro.Text = "Utiliza Financeiro";
            this.chkfinanceiro.UseVisualStyleBackColor = true;
            this.chkfinanceiro.CheckedChanged += new System.EventHandler(this.chkfinanceiro_CheckedChanged);
            // 
            // chkbanhoetosa
            // 
            this.chkbanhoetosa.AutoSize = true;
            this.chkbanhoetosa.Location = new System.Drawing.Point(165, 30);
            this.chkbanhoetosa.Name = "chkbanhoetosa";
            this.chkbanhoetosa.Size = new System.Drawing.Size(120, 17);
            this.chkbanhoetosa.TabIndex = 2;
            this.chkbanhoetosa.Text = "Utiliza Banho e tosa";
            this.chkbanhoetosa.UseVisualStyleBackColor = true;
            // 
            // chkmenuvenda
            // 
            this.chkmenuvenda.AutoSize = true;
            this.chkmenuvenda.Location = new System.Drawing.Point(165, 53);
            this.chkmenuvenda.Name = "chkmenuvenda";
            this.chkmenuvenda.Size = new System.Drawing.Size(118, 17);
            this.chkmenuvenda.TabIndex = 7;
            this.chkmenuvenda.Text = "Utiliza Menu Venda";
            this.chkmenuvenda.UseVisualStyleBackColor = true;
            // 
            // grpControles
            // 
            this.grpControles.Controls.Add(this.validacpfcnpj);
            this.grpControles.Controls.Add(this.chkmovestoque);
            this.grpControles.Controls.Add(this.chkfinanceiro);
            this.grpControles.Controls.Add(this.chkbanhoetosa);
            this.grpControles.Controls.Add(this.chkmenuvenda);
            this.grpControles.Location = new System.Drawing.Point(396, 154);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(382, 107);
            this.grpControles.TabIndex = 3;
            this.grpControles.TabStop = false;
            this.grpControles.Text = "Configurações de Controles";
            // 
            // validacpfcnpj
            // 
            this.validacpfcnpj.AutoSize = true;
            this.validacpfcnpj.Location = new System.Drawing.Point(9, 76);
            this.validacpfcnpj.Name = "validacpfcnpj";
            this.validacpfcnpj.Size = new System.Drawing.Size(123, 17);
            this.validacpfcnpj.TabIndex = 8;
            this.validacpfcnpj.Text = "Valida CPF ou CNPJ";
            this.validacpfcnpj.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(859, 614);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(117, 46);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblidconfig
            // 
            this.lblidconfig.AutoSize = true;
            this.lblidconfig.Location = new System.Drawing.Point(17, 13);
            this.lblidconfig.Name = "lblidconfig";
            this.lblidconfig.Size = new System.Drawing.Size(160, 13);
            this.lblidconfig.TabIndex = 5;
            this.lblidconfig.Text = "Selecione o ID da configuração:";
            // 
            // cbxID
            // 
            this.cbxID.DisplayMember = "ID_CONFIG";
            this.cbxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(183, 10);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(51, 21);
            this.cbxID.TabIndex = 6;
            this.cbxID.ValueMember = "ID_CONFIG";
            this.cbxID.SelectedIndexChanged += new System.EventHandler(this.cbxID_SelectedIndexChanged);
            // 
            // FormConfigSuporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.cbxID);
            this.Controls.Add(this.lblidconfig);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpControles);
            this.Controls.Add(this.grplicensa);
            this.Controls.Add(this.grpconfigbd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormConfigSuporte";
            this.Text = "Configurações do Suporte";
            this.Load += new System.EventHandler(this.FormConfigSuporte_Load);
            this.grpconfigbd.ResumeLayout(false);
            this.grpconfigbd.PerformLayout();
            this.grplicensa.ResumeLayout(false);
            this.grplicensa.PerformLayout();
            this.grpControles.ResumeLayout(false);
            this.grpControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpconfigbd;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtbanco;
        private System.Windows.Forms.TextBox txtservidor;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblbanco;
        private System.Windows.Forms.Label lblservidor;
        private System.Windows.Forms.Button btnCriarBanco;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.GroupBox grplicensa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpinstalacao;
        private System.Windows.Forms.CheckBox chkbanhoetosa;
        private System.Windows.Forms.CheckBox chkfinanceiro;
        private System.Windows.Forms.CheckBox chkmovestoque;
        private System.Windows.Forms.CheckBox chkmenuvenda;
        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.RadioButton rdbatmensal;
        private System.Windows.Forms.RadioButton rdbatualizacaosemestral;
        private System.Windows.Forms.RadioButton rdbdemonstracao;
        private System.Windows.Forms.RadioButton rdbatualizacaoanual;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox validacpfcnpj;
        private System.Windows.Forms.ComboBox cbxbanco;
        private System.Windows.Forms.Label lblidconfig;
        private System.Windows.Forms.ComboBox cbxID;
    }
}