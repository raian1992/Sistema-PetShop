namespace SistemaPetshop_2._0
{
    partial class FormEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresa));
            this.tabcomplem = new System.Windows.Forms.TabPage();
            this.grpEmail = new System.Windows.Forms.GroupBox();
            this.txtsalvar = new System.Windows.Forms.Button();
            this.txtesteemail = new System.Windows.Forms.Button();
            this.txtporta = new System.Windows.Forms.TextBox();
            this.lblporta = new System.Windows.Forms.Label();
            this.chkssl = new System.Windows.Forms.CheckBox();
            this.chkAut = new System.Windows.Forms.CheckBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtemail2 = new System.Windows.Forms.TextBox();
            this.lblemail2 = new System.Windows.Forms.Label();
            this.txtsmtp = new System.Windows.Forms.TextBox();
            this.lblsmtp = new System.Windows.Forms.Label();
            this.tabempresa = new System.Windows.Forms.TabPage();
            this.grbContato = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.mtxttelres = new System.Windows.Forms.MaskedTextBox();
            this.mtxtcel = new System.Windows.Forms.MaskedTextBox();
            this.lblres = new System.Windows.Forms.Label();
            this.lblcel = new System.Windows.Forms.Label();
            this.grbEndereco = new System.Windows.Forms.GroupBox();
            this.btnbuscacorreios = new System.Windows.Forms.Button();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.mtxtcep = new System.Windows.Forms.MaskedTextBox();
            this.lblrua = new System.Windows.Forms.Label();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.grpinfprincipal = new System.Windows.Forms.GroupBox();
            this.txtrgie = new System.Windows.Forms.TextBox();
            this.txtcnpjcpf = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.cbxtipoEmpresa = new System.Windows.Forms.ComboBox();
            this.cbxstatus = new System.Windows.Forms.ComboBox();
            this.txtnomefantasia = new System.Windows.Forms.TextBox();
            this.txtrazaosocial = new System.Windows.Forms.TextBox();
            this.lblrgie = new System.Windows.Forms.Label();
            this.lblcnpjcpf = new System.Windows.Forms.Label();
            this.lbltipoempresa = new System.Windows.Forms.Label();
            this.lblnomefant = new System.Windows.Forms.Label();
            this.lblrazaosocial = new System.Windows.Forms.Label();
            this.tabcomplemento = new System.Windows.Forms.TabControl();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpFinanceiro = new System.Windows.Forms.GroupBox();
            this.pntipojuros = new System.Windows.Forms.Panel();
            this.rdbjurosdiarios = new System.Windows.Forms.RadioButton();
            this.rdbjurosmensal = new System.Windows.Forms.RadioButton();
            this.txtmulta = new System.Windows.Forms.TextBox();
            this.lblMulta = new System.Windows.Forms.Label();
            this.txtjuros = new System.Windows.Forms.TextBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.rdbSimples = new System.Windows.Forms.RadioButton();
            this.rdbComposto = new System.Windows.Forms.RadioButton();
            this.tabcomplem.SuspendLayout();
            this.grpEmail.SuspendLayout();
            this.tabempresa.SuspendLayout();
            this.grbContato.SuspendLayout();
            this.grbEndereco.SuspendLayout();
            this.grpinfprincipal.SuspendLayout();
            this.tabcomplemento.SuspendLayout();
            this.grpFinanceiro.SuspendLayout();
            this.pntipojuros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcomplem
            // 
            this.tabcomplem.Controls.Add(this.grpFinanceiro);
            this.tabcomplem.Controls.Add(this.grpEmail);
            this.tabcomplem.Location = new System.Drawing.Point(4, 22);
            this.tabcomplem.Name = "tabcomplem";
            this.tabcomplem.Padding = new System.Windows.Forms.Padding(3);
            this.tabcomplem.Size = new System.Drawing.Size(1003, 557);
            this.tabcomplem.TabIndex = 1;
            this.tabcomplem.Text = "Complemento";
            this.tabcomplem.UseVisualStyleBackColor = true;
            // 
            // grpEmail
            // 
            this.grpEmail.Controls.Add(this.txtsalvar);
            this.grpEmail.Controls.Add(this.txtesteemail);
            this.grpEmail.Controls.Add(this.txtporta);
            this.grpEmail.Controls.Add(this.lblporta);
            this.grpEmail.Controls.Add(this.chkssl);
            this.grpEmail.Controls.Add(this.chkAut);
            this.grpEmail.Controls.Add(this.txtsenha);
            this.grpEmail.Controls.Add(this.lblsenha);
            this.grpEmail.Controls.Add(this.txtemail2);
            this.grpEmail.Controls.Add(this.lblemail2);
            this.grpEmail.Controls.Add(this.txtsmtp);
            this.grpEmail.Controls.Add(this.lblsmtp);
            this.grpEmail.Location = new System.Drawing.Point(13, 17);
            this.grpEmail.Name = "grpEmail";
            this.grpEmail.Size = new System.Drawing.Size(386, 200);
            this.grpEmail.TabIndex = 0;
            this.grpEmail.TabStop = false;
            this.grpEmail.Text = "Configuração de  E-mail";
            // 
            // txtsalvar
            // 
            this.txtsalvar.Location = new System.Drawing.Point(181, 171);
            this.txtsalvar.Name = "txtsalvar";
            this.txtsalvar.Size = new System.Drawing.Size(75, 23);
            this.txtsalvar.TabIndex = 16;
            this.txtsalvar.Text = "Salvar";
            this.txtsalvar.UseVisualStyleBackColor = true;
            this.txtsalvar.Click += new System.EventHandler(this.txtsalvar_Click);
            // 
            // txtesteemail
            // 
            this.txtesteemail.Location = new System.Drawing.Point(52, 171);
            this.txtesteemail.Name = "txtesteemail";
            this.txtesteemail.Size = new System.Drawing.Size(75, 23);
            this.txtesteemail.TabIndex = 7;
            this.txtesteemail.Text = "Envio Teste";
            this.txtesteemail.UseVisualStyleBackColor = true;
            this.txtesteemail.Click += new System.EventHandler(this.txtesteemail_Click);
            // 
            // txtporta
            // 
            this.txtporta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtporta.Location = new System.Drawing.Point(52, 52);
            this.txtporta.MaxLength = 3;
            this.txtporta.Name = "txtporta";
            this.txtporta.Size = new System.Drawing.Size(60, 20);
            this.txtporta.TabIndex = 2;
            // 
            // lblporta
            // 
            this.lblporta.AutoSize = true;
            this.lblporta.Location = new System.Drawing.Point(6, 55);
            this.lblporta.Name = "lblporta";
            this.lblporta.Size = new System.Drawing.Size(35, 13);
            this.lblporta.TabIndex = 15;
            this.lblporta.Text = "Porta:";
            // 
            // chkssl
            // 
            this.chkssl.AutoSize = true;
            this.chkssl.Location = new System.Drawing.Point(157, 130);
            this.chkssl.Name = "chkssl";
            this.chkssl.Size = new System.Drawing.Size(84, 17);
            this.chkssl.TabIndex = 6;
            this.chkssl.Text = "Requer SSL";
            this.chkssl.UseVisualStyleBackColor = true;
            // 
            // chkAut
            // 
            this.chkAut.AutoSize = true;
            this.chkAut.Location = new System.Drawing.Point(6, 130);
            this.chkAut.Name = "chkAut";
            this.chkAut.Size = new System.Drawing.Size(127, 17);
            this.chkAut.TabIndex = 5;
            this.chkAut.Text = "Requer Autenticação";
            this.chkAut.UseVisualStyleBackColor = true;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(52, 104);
            this.txtsenha.MaxLength = 100;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(204, 20);
            this.txtsenha.TabIndex = 4;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(6, 107);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(41, 13);
            this.lblsenha.TabIndex = 11;
            this.lblsenha.Text = "Senha:";
            // 
            // txtemail2
            // 
            this.txtemail2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtemail2.Location = new System.Drawing.Point(52, 78);
            this.txtemail2.MaxLength = 100;
            this.txtemail2.Name = "txtemail2";
            this.txtemail2.Size = new System.Drawing.Size(204, 20);
            this.txtemail2.TabIndex = 3;
            // 
            // lblemail2
            // 
            this.lblemail2.AutoSize = true;
            this.lblemail2.Location = new System.Drawing.Point(6, 81);
            this.lblemail2.Name = "lblemail2";
            this.lblemail2.Size = new System.Drawing.Size(38, 13);
            this.lblemail2.TabIndex = 9;
            this.lblemail2.Text = "E-mail:";
            // 
            // txtsmtp
            // 
            this.txtsmtp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsmtp.Location = new System.Drawing.Point(52, 26);
            this.txtsmtp.MaxLength = 100;
            this.txtsmtp.Name = "txtsmtp";
            this.txtsmtp.Size = new System.Drawing.Size(204, 20);
            this.txtsmtp.TabIndex = 1;
            // 
            // lblsmtp
            // 
            this.lblsmtp.AutoSize = true;
            this.lblsmtp.Location = new System.Drawing.Point(6, 29);
            this.lblsmtp.Name = "lblsmtp";
            this.lblsmtp.Size = new System.Drawing.Size(40, 13);
            this.lblsmtp.TabIndex = 7;
            this.lblsmtp.Text = "SMTP:";
            // 
            // tabempresa
            // 
            this.tabempresa.Controls.Add(this.grbContato);
            this.tabempresa.Controls.Add(this.grbEndereco);
            this.tabempresa.Controls.Add(this.grpinfprincipal);
            this.tabempresa.Location = new System.Drawing.Point(4, 22);
            this.tabempresa.Name = "tabempresa";
            this.tabempresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabempresa.Size = new System.Drawing.Size(1003, 557);
            this.tabempresa.TabIndex = 0;
            this.tabempresa.Text = "Principal";
            this.tabempresa.UseVisualStyleBackColor = true;
            // 
            // grbContato
            // 
            this.grbContato.Controls.Add(this.txtemail);
            this.grbContato.Controls.Add(this.lblemail);
            this.grbContato.Controls.Add(this.mtxttelres);
            this.grbContato.Controls.Add(this.mtxtcel);
            this.grbContato.Controls.Add(this.lblres);
            this.grbContato.Controls.Add(this.lblcel);
            this.grbContato.Location = new System.Drawing.Point(9, 377);
            this.grbContato.Name = "grbContato";
            this.grbContato.Size = new System.Drawing.Size(530, 150);
            this.grbContato.TabIndex = 5;
            this.grbContato.TabStop = false;
            this.grbContato.Text = "Contato";
            // 
            // txtemail
            // 
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtemail.Location = new System.Drawing.Point(51, 60);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(453, 20);
            this.txtemail.TabIndex = 49;
            this.txtemail.Leave += new System.EventHandler(this.Txtemail_Leave);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(7, 67);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(38, 13);
            this.lblemail.TabIndex = 48;
            this.lblemail.Text = "E-mail:";
            // 
            // mtxttelres
            // 
            this.mtxttelres.Location = new System.Drawing.Point(93, 19);
            this.mtxttelres.Mask = "(999) 0000-0000";
            this.mtxttelres.Name = "mtxttelres";
            this.mtxttelres.Size = new System.Drawing.Size(100, 20);
            this.mtxttelres.TabIndex = 14;
            this.mtxttelres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // mtxtcel
            // 
            this.mtxtcel.Location = new System.Drawing.Point(299, 19);
            this.mtxtcel.Mask = "(999) 00000-0000";
            this.mtxtcel.Name = "mtxtcel";
            this.mtxtcel.Size = new System.Drawing.Size(94, 20);
            this.mtxtcel.TabIndex = 15;
            this.mtxtcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(7, 22);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(86, 13);
            this.lblres.TabIndex = 33;
            this.lblres.Text = "Tel. Residencial:";
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.Location = new System.Drawing.Point(251, 22);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(42, 13);
            this.lblcel.TabIndex = 35;
            this.lblcel.Text = "Celular:";
            // 
            // grbEndereco
            // 
            this.grbEndereco.Controls.Add(this.btnbuscacorreios);
            this.grbEndereco.Controls.Add(this.txtcidade);
            this.grbEndereco.Controls.Add(this.txtEstado);
            this.grbEndereco.Controls.Add(this.mtxtcep);
            this.grbEndereco.Controls.Add(this.lblrua);
            this.grbEndereco.Controls.Add(this.txtrua);
            this.grbEndereco.Controls.Add(this.label4);
            this.grbEndereco.Controls.Add(this.txtNumero);
            this.grbEndereco.Controls.Add(this.label12);
            this.grbEndereco.Controls.Add(this.label13);
            this.grbEndereco.Controls.Add(this.label14);
            this.grbEndereco.Controls.Add(this.lblcep);
            this.grbEndereco.Controls.Add(this.txtBairro);
            this.grbEndereco.Location = new System.Drawing.Point(9, 227);
            this.grbEndereco.Name = "grbEndereco";
            this.grbEndereco.Size = new System.Drawing.Size(530, 130);
            this.grbEndereco.TabIndex = 4;
            this.grbEndereco.TabStop = false;
            this.grbEndereco.Text = "Endereço";
            // 
            // btnbuscacorreios
            // 
            this.btnbuscacorreios.Image = global::SistemaPetshop_2._0.Properties.Resources.correios2;
            this.btnbuscacorreios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscacorreios.Location = new System.Drawing.Point(96, 18);
            this.btnbuscacorreios.Name = "btnbuscacorreios";
            this.btnbuscacorreios.Size = new System.Drawing.Size(30, 23);
            this.btnbuscacorreios.TabIndex = 6;
            this.btnbuscacorreios.UseVisualStyleBackColor = true;
            this.btnbuscacorreios.Click += new System.EventHandler(this.btnbuscacorreios_Click);
            // 
            // txtcidade
            // 
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcidade.Location = new System.Drawing.Point(41, 81);
            this.txtcidade.MaxLength = 40;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(345, 20);
            this.txtcidade.TabIndex = 12;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(437, 81);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(67, 20);
            this.txtEstado.TabIndex = 11;
            // 
            // mtxtcep
            // 
            this.mtxtcep.Location = new System.Drawing.Point(31, 20);
            this.mtxtcep.Mask = "00000-000";
            this.mtxtcep.Name = "mtxtcep";
            this.mtxtcep.Size = new System.Drawing.Size(59, 20);
            this.mtxtcep.TabIndex = 5;
            this.mtxtcep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.Location = new System.Drawing.Point(129, 24);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(30, 13);
            this.lblrua.TabIndex = 24;
            this.lblrua.Text = "Rua:";
            // 
            // txtrua
            // 
            this.txtrua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrua.Location = new System.Drawing.Point(164, 20);
            this.txtrua.MaxLength = 40;
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(268, 20);
            this.txtrua.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nº:";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(456, 19);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(48, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(392, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Estado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-3, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Cidade:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Bairro:";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(3, 24);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(29, 13);
            this.lblcep.TabIndex = 31;
            this.lblcep.Text = "Cep:";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(42, 52);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(344, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // grpinfprincipal
            // 
            this.grpinfprincipal.Controls.Add(this.txtrgie);
            this.grpinfprincipal.Controls.Add(this.txtcnpjcpf);
            this.grpinfprincipal.Controls.Add(this.lblstatus);
            this.grpinfprincipal.Controls.Add(this.cbxtipoEmpresa);
            this.grpinfprincipal.Controls.Add(this.cbxstatus);
            this.grpinfprincipal.Controls.Add(this.txtnomefantasia);
            this.grpinfprincipal.Controls.Add(this.txtrazaosocial);
            this.grpinfprincipal.Controls.Add(this.lblrgie);
            this.grpinfprincipal.Controls.Add(this.lblcnpjcpf);
            this.grpinfprincipal.Controls.Add(this.lbltipoempresa);
            this.grpinfprincipal.Controls.Add(this.lblnomefant);
            this.grpinfprincipal.Controls.Add(this.lblrazaosocial);
            this.grpinfprincipal.Location = new System.Drawing.Point(9, 6);
            this.grpinfprincipal.Name = "grpinfprincipal";
            this.grpinfprincipal.Size = new System.Drawing.Size(530, 212);
            this.grpinfprincipal.TabIndex = 1;
            this.grpinfprincipal.TabStop = false;
            this.grpinfprincipal.Text = "Informações Principais";
            // 
            // txtrgie
            // 
            this.txtrgie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrgie.Location = new System.Drawing.Point(379, 175);
            this.txtrgie.MaxLength = 20;
            this.txtrgie.Name = "txtrgie";
            this.txtrgie.Size = new System.Drawing.Size(125, 20);
            this.txtrgie.TabIndex = 10;
            // 
            // txtcnpjcpf
            // 
            this.txtcnpjcpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcnpjcpf.Location = new System.Drawing.Point(92, 175);
            this.txtcnpjcpf.MaxLength = 14;
            this.txtcnpjcpf.Name = "txtcnpjcpf";
            this.txtcnpjcpf.Size = new System.Drawing.Size(178, 20);
            this.txtcnpjcpf.TabIndex = 9;
            this.txtcnpjcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.txtcnpjcpf.Leave += new System.EventHandler(this.txtcnpjcpf_Leave);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(337, 23);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(40, 13);
            this.lblstatus.TabIndex = 3;
            this.lblstatus.Text = "Status:";
            // 
            // cbxtipoEmpresa
            // 
            this.cbxtipoEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipoEmpresa.FormattingEnabled = true;
            this.cbxtipoEmpresa.Items.AddRange(new object[] {
            "FISICA",
            "JURIDICA"});
            this.cbxtipoEmpresa.Location = new System.Drawing.Point(92, 142);
            this.cbxtipoEmpresa.Name = "cbxtipoEmpresa";
            this.cbxtipoEmpresa.Size = new System.Drawing.Size(105, 21);
            this.cbxtipoEmpresa.TabIndex = 8;
            this.cbxtipoEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbxtipoEmpresa_SelectedIndexChanged);
            // 
            // cbxstatus
            // 
            this.cbxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxstatus.FormattingEnabled = true;
            this.cbxstatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbxstatus.Location = new System.Drawing.Point(383, 19);
            this.cbxstatus.Name = "cbxstatus";
            this.cbxstatus.Size = new System.Drawing.Size(121, 21);
            this.cbxstatus.TabIndex = 2;
            // 
            // txtnomefantasia
            // 
            this.txtnomefantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomefantasia.Location = new System.Drawing.Point(92, 106);
            this.txtnomefantasia.MaxLength = 100;
            this.txtnomefantasia.Name = "txtnomefantasia";
            this.txtnomefantasia.Size = new System.Drawing.Size(412, 20);
            this.txtnomefantasia.TabIndex = 7;
            // 
            // txtrazaosocial
            // 
            this.txtrazaosocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrazaosocial.Location = new System.Drawing.Point(92, 66);
            this.txtrazaosocial.MaxLength = 100;
            this.txtrazaosocial.Name = "txtrazaosocial";
            this.txtrazaosocial.Size = new System.Drawing.Size(412, 20);
            this.txtrazaosocial.TabIndex = 6;
            // 
            // lblrgie
            // 
            this.lblrgie.AutoSize = true;
            this.lblrgie.Location = new System.Drawing.Point(276, 178);
            this.lblrgie.Name = "lblrgie";
            this.lblrgie.Size = new System.Drawing.Size(97, 13);
            this.lblrgie.TabIndex = 4;
            this.lblrgie.Text = "Inscricao Estadual:";
            // 
            // lblcnpjcpf
            // 
            this.lblcnpjcpf.AutoSize = true;
            this.lblcnpjcpf.Location = new System.Drawing.Point(43, 178);
            this.lblcnpjcpf.Name = "lblcnpjcpf";
            this.lblcnpjcpf.Size = new System.Drawing.Size(37, 13);
            this.lblcnpjcpf.TabIndex = 3;
            this.lblcnpjcpf.Text = "CNPJ:";
            // 
            // lbltipoempresa
            // 
            this.lbltipoempresa.AutoSize = true;
            this.lbltipoempresa.Location = new System.Drawing.Point(7, 142);
            this.lbltipoempresa.Name = "lbltipoempresa";
            this.lbltipoempresa.Size = new System.Drawing.Size(75, 13);
            this.lbltipoempresa.TabIndex = 2;
            this.lbltipoempresa.Text = "Tipo Empresa:";
            // 
            // lblnomefant
            // 
            this.lblnomefant.AutoSize = true;
            this.lblnomefant.Location = new System.Drawing.Point(-1, 109);
            this.lblnomefant.Name = "lblnomefant";
            this.lblnomefant.Size = new System.Drawing.Size(81, 13);
            this.lblnomefant.TabIndex = 1;
            this.lblnomefant.Text = "Nome Fantasia:";
            // 
            // lblrazaosocial
            // 
            this.lblrazaosocial.AutoSize = true;
            this.lblrazaosocial.Location = new System.Drawing.Point(7, 69);
            this.lblrazaosocial.Name = "lblrazaosocial";
            this.lblrazaosocial.Size = new System.Drawing.Size(73, 13);
            this.lblrazaosocial.TabIndex = 0;
            this.lblrazaosocial.Text = "Razão Social:";
            // 
            // tabcomplemento
            // 
            this.tabcomplemento.Controls.Add(this.tabempresa);
            this.tabcomplemento.Controls.Add(this.tabcomplem);
            this.tabcomplemento.Location = new System.Drawing.Point(-1, 2);
            this.tabcomplemento.Name = "tabcomplemento";
            this.tabcomplemento.SelectedIndex = 0;
            this.tabcomplemento.Size = new System.Drawing.Size(1011, 583);
            this.tabcomplemento.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(141, 601);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(311, 601);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpFinanceiro
            // 
            this.grpFinanceiro.Controls.Add(this.pntipojuros);
            this.grpFinanceiro.Controls.Add(this.txtmulta);
            this.grpFinanceiro.Controls.Add(this.lblMulta);
            this.grpFinanceiro.Controls.Add(this.txtjuros);
            this.grpFinanceiro.Controls.Add(this.lblJuros);
            this.grpFinanceiro.Controls.Add(this.rdbSimples);
            this.grpFinanceiro.Controls.Add(this.rdbComposto);
            this.grpFinanceiro.Location = new System.Drawing.Point(414, 17);
            this.grpFinanceiro.Name = "grpFinanceiro";
            this.grpFinanceiro.Size = new System.Drawing.Size(212, 118);
            this.grpFinanceiro.TabIndex = 8;
            this.grpFinanceiro.TabStop = false;
            this.grpFinanceiro.Text = "Financeiro";
            // 
            // pntipojuros
            // 
            this.pntipojuros.Controls.Add(this.rdbjurosdiarios);
            this.pntipojuros.Controls.Add(this.rdbjurosmensal);
            this.pntipojuros.Location = new System.Drawing.Point(6, 36);
            this.pntipojuros.Name = "pntipojuros";
            this.pntipojuros.Size = new System.Drawing.Size(200, 28);
            this.pntipojuros.TabIndex = 10;
            // 
            // rdbjurosdiarios
            // 
            this.rdbjurosdiarios.AutoSize = true;
            this.rdbjurosdiarios.Location = new System.Drawing.Point(0, 6);
            this.rdbjurosdiarios.Name = "rdbjurosdiarios";
            this.rdbjurosdiarios.Size = new System.Drawing.Size(85, 17);
            this.rdbjurosdiarios.TabIndex = 8;
            this.rdbjurosdiarios.TabStop = true;
            this.rdbjurosdiarios.Text = "Juros Diarios";
            this.rdbjurosdiarios.UseVisualStyleBackColor = true;
            // 
            // rdbjurosmensal
            // 
            this.rdbjurosmensal.AutoSize = true;
            this.rdbjurosmensal.Location = new System.Drawing.Point(100, 6);
            this.rdbjurosmensal.Name = "rdbjurosmensal";
            this.rdbjurosmensal.Size = new System.Drawing.Size(87, 17);
            this.rdbjurosmensal.TabIndex = 9;
            this.rdbjurosmensal.TabStop = true;
            this.rdbjurosmensal.Text = "Juros Mensal";
            this.rdbjurosmensal.UseVisualStyleBackColor = true;
            // 
            // txtmulta
            // 
            this.txtmulta.Location = new System.Drawing.Point(140, 69);
            this.txtmulta.Name = "txtmulta";
            this.txtmulta.Size = new System.Drawing.Size(57, 20);
            this.txtmulta.TabIndex = 14;
            this.txtmulta.Leave += new System.EventHandler(this.txtmulta_Leave);
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(101, 73);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(36, 13);
            this.lblMulta.TabIndex = 13;
            this.lblMulta.Text = "Multa:";
            // 
            // txtjuros
            // 
            this.txtjuros.Location = new System.Drawing.Point(41, 70);
            this.txtjuros.Name = "txtjuros";
            this.txtjuros.Size = new System.Drawing.Size(55, 20);
            this.txtjuros.TabIndex = 12;
            this.txtjuros.Leave += new System.EventHandler(this.txtjuros_Leave);
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(3, 73);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(35, 13);
            this.lblJuros.TabIndex = 11;
            this.lblJuros.Text = "Juros:";
            // 
            // rdbSimples
            // 
            this.rdbSimples.AutoSize = true;
            this.rdbSimples.Location = new System.Drawing.Point(6, 19);
            this.rdbSimples.Name = "rdbSimples";
            this.rdbSimples.Size = new System.Drawing.Size(89, 17);
            this.rdbSimples.TabIndex = 9;
            this.rdbSimples.TabStop = true;
            this.rdbSimples.Text = "Juros Simples";
            this.rdbSimples.UseVisualStyleBackColor = true;
            // 
            // rdbComposto
            // 
            this.rdbComposto.AutoSize = true;
            this.rdbComposto.Location = new System.Drawing.Point(105, 19);
            this.rdbComposto.Name = "rdbComposto";
            this.rdbComposto.Size = new System.Drawing.Size(100, 17);
            this.rdbComposto.TabIndex = 10;
            this.rdbComposto.TabStop = true;
            this.rdbComposto.Text = "Juros Composto";
            this.rdbComposto.UseVisualStyleBackColor = true;
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tabcomplemento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações da Empresa";
            this.Load += new System.EventHandler(this.FormEmpresa_Load);
            this.tabcomplem.ResumeLayout(false);
            this.grpEmail.ResumeLayout(false);
            this.grpEmail.PerformLayout();
            this.tabempresa.ResumeLayout(false);
            this.grbContato.ResumeLayout(false);
            this.grbContato.PerformLayout();
            this.grbEndereco.ResumeLayout(false);
            this.grbEndereco.PerformLayout();
            this.grpinfprincipal.ResumeLayout(false);
            this.grpinfprincipal.PerformLayout();
            this.tabcomplemento.ResumeLayout(false);
            this.grpFinanceiro.ResumeLayout(false);
            this.grpFinanceiro.PerformLayout();
            this.pntipojuros.ResumeLayout(false);
            this.pntipojuros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabcomplem;
        private System.Windows.Forms.TabPage tabempresa;
        private System.Windows.Forms.GroupBox grpinfprincipal;
        private System.Windows.Forms.TextBox txtrgie;
        private System.Windows.Forms.TextBox txtcnpjcpf;
        private System.Windows.Forms.ComboBox cbxtipoEmpresa;
        private System.Windows.Forms.TextBox txtnomefantasia;
        private System.Windows.Forms.TextBox txtrazaosocial;
        private System.Windows.Forms.Label lblrgie;
        private System.Windows.Forms.Label lblcnpjcpf;
        private System.Windows.Forms.Label lbltipoempresa;
        private System.Windows.Forms.Label lblnomefant;
        private System.Windows.Forms.Label lblrazaosocial;
        private System.Windows.Forms.TabControl tabcomplemento;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ComboBox cbxstatus;
        private System.Windows.Forms.GroupBox grbEndereco;
        private System.Windows.Forms.Button btnbuscacorreios;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox mtxtcep;
        private System.Windows.Forms.Label lblrua;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.GroupBox grbContato;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.MaskedTextBox mtxttelres;
        private System.Windows.Forms.MaskedTextBox mtxtcel;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpEmail;
        private System.Windows.Forms.Button txtesteemail;
        private System.Windows.Forms.TextBox txtporta;
        private System.Windows.Forms.Label lblporta;
        private System.Windows.Forms.CheckBox chkssl;
        private System.Windows.Forms.CheckBox chkAut;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtemail2;
        private System.Windows.Forms.Label lblemail2;
        private System.Windows.Forms.TextBox txtsmtp;
        private System.Windows.Forms.Label lblsmtp;
        private System.Windows.Forms.Button txtsalvar;
        private System.Windows.Forms.GroupBox grpFinanceiro;
        private System.Windows.Forms.Panel pntipojuros;
        private System.Windows.Forms.RadioButton rdbjurosdiarios;
        private System.Windows.Forms.RadioButton rdbjurosmensal;
        private System.Windows.Forms.TextBox txtmulta;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.TextBox txtjuros;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.RadioButton rdbSimples;
        private System.Windows.Forms.RadioButton rdbComposto;
    }
}