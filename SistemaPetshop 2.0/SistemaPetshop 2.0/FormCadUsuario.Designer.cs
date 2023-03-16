
namespace SistemaPetshop_2._0
{
    partial class FormCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadUsuario));
            this.lblnome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblcontrasenha = new System.Windows.Forms.Label();
            this.lblconfirm = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtconfirmsenha = new System.Windows.Forms.TextBox();
            this.txtcontrasenha = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cbxperfil = new System.Windows.Forms.ComboBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.brnsalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.chkativo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(92, 48);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(94, 76);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login:";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(89, 104);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(41, 13);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "Senha:";
            // 
            // lblcontrasenha
            // 
            this.lblcontrasenha.AutoSize = true;
            this.lblcontrasenha.Location = new System.Drawing.Point(49, 157);
            this.lblcontrasenha.Name = "lblcontrasenha";
            this.lblcontrasenha.Size = new System.Drawing.Size(81, 13);
            this.lblcontrasenha.TabIndex = 3;
            this.lblcontrasenha.Text = "Contra - Senha:";
            // 
            // lblconfirm
            // 
            this.lblconfirm.AutoSize = true;
            this.lblconfirm.Location = new System.Drawing.Point(12, 127);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(118, 13);
            this.lblconfirm.TabIndex = 4;
            this.lblconfirm.Text = "Confirmação de Senha:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(92, 178);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(38, 13);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "E-mail:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(45, 210);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(85, 13);
            this.lblPerfil.TabIndex = 6;
            this.lblPerfil.Text = "Perfil de acesso:";
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(136, 44);
            this.txtnome.MaxLength = 40;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(307, 20);
            this.txtnome.TabIndex = 1;
            // 
            // txtlogin
            // 
            this.txtlogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlogin.Location = new System.Drawing.Point(137, 72);
            this.txtlogin.MaxLength = 20;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(307, 20);
            this.txtlogin.TabIndex = 2;
            // 
            // txtconfirmsenha
            // 
            this.txtconfirmsenha.Location = new System.Drawing.Point(136, 127);
            this.txtconfirmsenha.MaxLength = 20;
            this.txtconfirmsenha.Name = "txtconfirmsenha";
            this.txtconfirmsenha.Size = new System.Drawing.Size(307, 20);
            this.txtconfirmsenha.TabIndex = 4;
            this.txtconfirmsenha.UseSystemPasswordChar = true;
            this.txtconfirmsenha.Leave += new System.EventHandler(this.txtconfirmsenha_Leave);
            // 
            // txtcontrasenha
            // 
            this.txtcontrasenha.Location = new System.Drawing.Point(136, 153);
            this.txtcontrasenha.MaxLength = 20;
            this.txtcontrasenha.Name = "txtcontrasenha";
            this.txtcontrasenha.Size = new System.Drawing.Size(307, 20);
            this.txtcontrasenha.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(137, 178);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(306, 20);
            this.txtemail.TabIndex = 6;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // cbxperfil
            // 
            this.cbxperfil.DisplayMember = "DESCRICAO";
            this.cbxperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxperfil.FormattingEnabled = true;
            this.cbxperfil.Location = new System.Drawing.Point(137, 207);
            this.cbxperfil.Name = "cbxperfil";
            this.cbxperfil.Size = new System.Drawing.Size(307, 21);
            this.cbxperfil.TabIndex = 7;
            this.cbxperfil.ValueMember = "ID_PERFIL";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(136, 100);
            this.txtsenha.MaxLength = 20;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(307, 20);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // brnsalvar
            // 
            this.brnsalvar.Location = new System.Drawing.Point(153, 258);
            this.brnsalvar.Name = "brnsalvar";
            this.brnsalvar.Size = new System.Drawing.Size(75, 23);
            this.brnsalvar.TabIndex = 7;
            this.brnsalvar.Text = "Salvar";
            this.brnsalvar.UseVisualStyleBackColor = true;
            this.brnsalvar.Click += new System.EventHandler(this.brnsalvar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(319, 258);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // chkativo
            // 
            this.chkativo.AutoSize = true;
            this.chkativo.Location = new System.Drawing.Point(355, 16);
            this.chkativo.Name = "chkativo";
            this.chkativo.Size = new System.Drawing.Size(89, 17);
            this.chkativo.TabIndex = 9;
            this.chkativo.Text = "Usuario Ativo";
            this.chkativo.UseVisualStyleBackColor = true;
            // 
            // FormCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 318);
            this.Controls.Add(this.chkativo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.brnsalvar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.cbxperfil);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcontrasenha);
            this.Controls.Add(this.txtconfirmsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblconfirm);
            this.Controls.Add(this.lblcontrasenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblnome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuario";
            this.Load += new System.EventHandler(this.FormCadUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblcontrasenha;
        private System.Windows.Forms.Label lblconfirm;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtconfirmsenha;
        private System.Windows.Forms.TextBox txtcontrasenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cbxperfil;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button brnsalvar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.CheckBox chkativo;
    }
}