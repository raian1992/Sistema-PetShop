
namespace SistemaPetshop_2._0
{
    partial class USCADPROP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblrazaosocial = new System.Windows.Forms.Label();
            this.grpinfprincipal = new System.Windows.Forms.GroupBox();
            this.btnbuscacorreios = new System.Windows.Forms.Button();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.mtxtcep = new System.Windows.Forms.MaskedTextBox();
            this.lblrua = new System.Windows.Forms.Label();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.lblres = new System.Windows.Forms.Label();
            this.lblcel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.mtxttelres = new System.Windows.Forms.MaskedTextBox();
            this.mtxtcel = new System.Windows.Forms.MaskedTextBox();
            this.grbContato = new System.Windows.Forms.GroupBox();
            this.grbEndereco = new System.Windows.Forms.GroupBox();
            this.grpinfprincipal.SuspendLayout();
            this.grbContato.SuspendLayout();
            this.grbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(488, 13);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 17;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(59, 27);
            this.txtnome.MaxLength = 100;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(443, 20);
            this.txtnome.TabIndex = 6;
            // 
            // lblrazaosocial
            // 
            this.lblrazaosocial.AutoSize = true;
            this.lblrazaosocial.Location = new System.Drawing.Point(15, 30);
            this.lblrazaosocial.Name = "lblrazaosocial";
            this.lblrazaosocial.Size = new System.Drawing.Size(38, 13);
            this.lblrazaosocial.TabIndex = 0;
            this.lblrazaosocial.Text = "Nome:";
            // 
            // grpinfprincipal
            // 
            this.grpinfprincipal.Controls.Add(this.txtnome);
            this.grpinfprincipal.Controls.Add(this.lblrazaosocial);
            this.grpinfprincipal.Location = new System.Drawing.Point(8, 36);
            this.grpinfprincipal.Name = "grpinfprincipal";
            this.grpinfprincipal.Size = new System.Drawing.Size(530, 61);
            this.grpinfprincipal.TabIndex = 12;
            this.grpinfprincipal.TabStop = false;
            this.grpinfprincipal.Text = "Informações Principais";
            // 
            // btnbuscacorreios
            // 
            this.btnbuscacorreios.Image = global::SistemaPetshop_2._0.Properties.Resources.correios2;
            this.btnbuscacorreios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscacorreios.Location = new System.Drawing.Point(99, 28);
            this.btnbuscacorreios.Name = "btnbuscacorreios";
            this.btnbuscacorreios.Size = new System.Drawing.Size(30, 23);
            this.btnbuscacorreios.TabIndex = 6;
            this.btnbuscacorreios.UseVisualStyleBackColor = true;
            this.btnbuscacorreios.Click += new System.EventHandler(this.btnbuscacorreios_Click);
            // 
            // txtcidade
            // 
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcidade.Location = new System.Drawing.Point(46, 91);
            this.txtcidade.MaxLength = 40;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(345, 20);
            this.txtcidade.TabIndex = 12;
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(442, 91);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(61, 20);
            this.txtEstado.TabIndex = 11;
            // 
            // mtxtcep
            // 
            this.mtxtcep.Location = new System.Drawing.Point(34, 30);
            this.mtxtcep.Mask = "00000-000";
            this.mtxtcep.Name = "mtxtcep";
            this.mtxtcep.Size = new System.Drawing.Size(59, 20);
            this.mtxtcep.TabIndex = 5;
            this.mtxtcep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtcep_KeyPress);
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.Location = new System.Drawing.Point(132, 34);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(30, 13);
            this.lblrua.TabIndex = 24;
            this.lblrua.Text = "Rua:";
            // 
            // txtrua
            // 
            this.txtrua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrua.Location = new System.Drawing.Point(167, 30);
            this.txtrua.MaxLength = 40;
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(268, 20);
            this.txtrua.TabIndex = 7;
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(9, 34);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(86, 13);
            this.lblres.TabIndex = 33;
            this.lblres.Text = "Tel. Residencial:";
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.Location = new System.Drawing.Point(253, 34);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(42, 13);
            this.lblcel.TabIndex = 35;
            this.lblcel.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nº:";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(463, 30);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(42, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(397, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Estado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Cidade:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Bairro:";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(6, 34);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(29, 13);
            this.lblcep.TabIndex = 31;
            this.lblcep.Text = "Cep:";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(45, 62);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(344, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtemail.Location = new System.Drawing.Point(53, 76);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(451, 20);
            this.txtemail.TabIndex = 49;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(9, 79);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(38, 13);
            this.lblemail.TabIndex = 48;
            this.lblemail.Text = "E-mail:";
            // 
            // mtxttelres
            // 
            this.mtxttelres.Location = new System.Drawing.Point(95, 31);
            this.mtxttelres.Mask = "(999) 0000-0000";
            this.mtxttelres.Name = "mtxttelres";
            this.mtxttelres.Size = new System.Drawing.Size(100, 20);
            this.mtxttelres.TabIndex = 14;
            // 
            // mtxtcel
            // 
            this.mtxtcel.Location = new System.Drawing.Point(301, 31);
            this.mtxtcel.Mask = "(999) 00000-0000";
            this.mtxtcel.Name = "mtxtcel";
            this.mtxtcel.Size = new System.Drawing.Size(94, 20);
            this.mtxtcel.TabIndex = 15;
            // 
            // grbContato
            // 
            this.grbContato.Controls.Add(this.txtemail);
            this.grbContato.Controls.Add(this.lblemail);
            this.grbContato.Controls.Add(this.mtxttelres);
            this.grbContato.Controls.Add(this.mtxtcel);
            this.grbContato.Controls.Add(this.lblres);
            this.grbContato.Controls.Add(this.lblcel);
            this.grbContato.Location = new System.Drawing.Point(8, 268);
            this.grbContato.Name = "grbContato";
            this.grbContato.Size = new System.Drawing.Size(530, 120);
            this.grbContato.TabIndex = 14;
            this.grbContato.TabStop = false;
            this.grbContato.Text = "Contato";
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
            this.grbEndereco.Location = new System.Drawing.Point(8, 118);
            this.grbEndereco.Name = "grbEndereco";
            this.grbEndereco.Size = new System.Drawing.Size(530, 130);
            this.grbEndereco.TabIndex = 13;
            this.grbEndereco.TabStop = false;
            this.grbEndereco.Text = "Endereço";
            // 
            // USCADPROP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.grpinfprincipal);
            this.Controls.Add(this.grbContato);
            this.Controls.Add(this.grbEndereco);
            this.MinimumSize = new System.Drawing.Size(548, 399);
            this.Name = "USCADPROP";
            this.Size = new System.Drawing.Size(548, 399);
            this.Load += new System.EventHandler(this.USCADPROP_Load);
            this.grpinfprincipal.ResumeLayout(false);
            this.grpinfprincipal.PerformLayout();
            this.grbContato.ResumeLayout(false);
            this.grbContato.PerformLayout();
            this.grbEndereco.ResumeLayout(false);
            this.grbEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblrazaosocial;
        private System.Windows.Forms.GroupBox grpinfprincipal;
        private System.Windows.Forms.Button btnbuscacorreios;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox mtxtcep;
        private System.Windows.Forms.Label lblrua;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.MaskedTextBox mtxttelres;
        private System.Windows.Forms.MaskedTextBox mtxtcel;
        private System.Windows.Forms.GroupBox grbContato;
        private System.Windows.Forms.GroupBox grbEndereco;
    }
}
