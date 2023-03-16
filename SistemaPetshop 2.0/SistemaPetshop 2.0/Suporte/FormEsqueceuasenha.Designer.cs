
namespace SistemaPetshop_2._0.Suporte
{
    partial class FormEsqueceuasenha
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
            this.cbxEscolha = new System.Windows.Forms.ComboBox();
            this.lblselecao = new System.Windows.Forms.Label();
            this.grpcontrasenha = new System.Windows.Forms.GroupBox();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.painelnovasenha1 = new System.Windows.Forms.Panel();
            this.btnsalvardados = new System.Windows.Forms.Button();
            this.txtcnovasenhact2 = new System.Windows.Forms.TextBox();
            this.txtnovasenhact = new System.Windows.Forms.TextBox();
            this.lblconfirmnovasenha = new System.Windows.Forms.Label();
            this.lblNovasenha = new System.Windows.Forms.Label();
            this.txtusuarioct = new System.Windows.Forms.TextBox();
            this.txtcontrasenhact = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblContraSenha = new System.Windows.Forms.Label();
            this.grpemail = new System.Windows.Forms.GroupBox();
            this.btnenviaremail = new System.Windows.Forms.Button();
            this.btnvalidarem = new System.Windows.Forms.Button();
            this.pnredemail = new System.Windows.Forms.Panel();
            this.bnsalvarem = new System.Windows.Forms.Button();
            this.txtcnovasenhaem = new System.Windows.Forms.TextBox();
            this.txtnovasenhaem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuarioem = new System.Windows.Forms.TextBox();
            this.txtcodigoemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpcontrasenha.SuspendLayout();
            this.painelnovasenha1.SuspendLayout();
            this.grpemail.SuspendLayout();
            this.pnredemail.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxEscolha
            // 
            this.cbxEscolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEscolha.FormattingEnabled = true;
            this.cbxEscolha.Items.AddRange(new object[] {
            "Contra-Senha",
            "E-mail"});
            this.cbxEscolha.Location = new System.Drawing.Point(223, 17);
            this.cbxEscolha.Name = "cbxEscolha";
            this.cbxEscolha.Size = new System.Drawing.Size(132, 21);
            this.cbxEscolha.TabIndex = 0;
            this.cbxEscolha.SelectedIndexChanged += new System.EventHandler(this.cbxEscolha_SelectedIndexChanged);
            // 
            // lblselecao
            // 
            this.lblselecao.AutoSize = true;
            this.lblselecao.Location = new System.Drawing.Point(12, 20);
            this.lblselecao.Name = "lblselecao";
            this.lblselecao.Size = new System.Drawing.Size(196, 13);
            this.lblselecao.TabIndex = 1;
            this.lblselecao.Text = "Selecione a opção Para redefinir senha:";
            // 
            // grpcontrasenha
            // 
            this.grpcontrasenha.Controls.Add(this.btnvalidar);
            this.grpcontrasenha.Controls.Add(this.painelnovasenha1);
            this.grpcontrasenha.Controls.Add(this.txtusuarioct);
            this.grpcontrasenha.Controls.Add(this.txtcontrasenhact);
            this.grpcontrasenha.Controls.Add(this.lblusuario);
            this.grpcontrasenha.Controls.Add(this.lblContraSenha);
            this.grpcontrasenha.Enabled = false;
            this.grpcontrasenha.Location = new System.Drawing.Point(15, 44);
            this.grpcontrasenha.Name = "grpcontrasenha";
            this.grpcontrasenha.Size = new System.Drawing.Size(590, 155);
            this.grpcontrasenha.TabIndex = 2;
            this.grpcontrasenha.TabStop = false;
            this.grpcontrasenha.Text = "Redefinir pela Contra-Senha";
            // 
            // btnvalidar
            // 
            this.btnvalidar.Location = new System.Drawing.Point(208, 120);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(73, 23);
            this.btnvalidar.TabIndex = 6;
            this.btnvalidar.Text = "Validar ";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // painelnovasenha1
            // 
            this.painelnovasenha1.Controls.Add(this.btnsalvardados);
            this.painelnovasenha1.Controls.Add(this.txtcnovasenhact2);
            this.painelnovasenha1.Controls.Add(this.txtnovasenhact);
            this.painelnovasenha1.Controls.Add(this.lblconfirmnovasenha);
            this.painelnovasenha1.Controls.Add(this.lblNovasenha);
            this.painelnovasenha1.Enabled = false;
            this.painelnovasenha1.Location = new System.Drawing.Point(304, 28);
            this.painelnovasenha1.Name = "painelnovasenha1";
            this.painelnovasenha1.Size = new System.Drawing.Size(280, 121);
            this.painelnovasenha1.TabIndex = 5;
            // 
            // btnsalvardados
            // 
            this.btnsalvardados.Location = new System.Drawing.Point(193, 92);
            this.btnsalvardados.Name = "btnsalvardados";
            this.btnsalvardados.Size = new System.Drawing.Size(75, 23);
            this.btnsalvardados.TabIndex = 4;
            this.btnsalvardados.Text = "Salvar";
            this.btnsalvardados.UseVisualStyleBackColor = true;
            this.btnsalvardados.Click += new System.EventHandler(this.btnsalvardados_Click);
            // 
            // txtcnovasenhact2
            // 
            this.txtcnovasenhact2.Location = new System.Drawing.Point(130, 56);
            this.txtcnovasenhact2.Name = "txtcnovasenhact2";
            this.txtcnovasenhact2.Size = new System.Drawing.Size(138, 20);
            this.txtcnovasenhact2.TabIndex = 3;
            // 
            // txtnovasenhact
            // 
            this.txtnovasenhact.Location = new System.Drawing.Point(130, 17);
            this.txtnovasenhact.Name = "txtnovasenhact";
            this.txtnovasenhact.Size = new System.Drawing.Size(138, 20);
            this.txtnovasenhact.TabIndex = 2;
            // 
            // lblconfirmnovasenha
            // 
            this.lblconfirmnovasenha.AutoSize = true;
            this.lblconfirmnovasenha.Location = new System.Drawing.Point(3, 59);
            this.lblconfirmnovasenha.Name = "lblconfirmnovasenha";
            this.lblconfirmnovasenha.Size = new System.Drawing.Size(121, 13);
            this.lblconfirmnovasenha.TabIndex = 1;
            this.lblconfirmnovasenha.Text = "Confirme a nova Senha:";
            // 
            // lblNovasenha
            // 
            this.lblNovasenha.AutoSize = true;
            this.lblNovasenha.Location = new System.Drawing.Point(3, 17);
            this.lblNovasenha.Name = "lblNovasenha";
            this.lblNovasenha.Size = new System.Drawing.Size(109, 13);
            this.lblNovasenha.TabIndex = 0;
            this.lblNovasenha.Text = "Digite a Nova Senha:";
            // 
            // txtusuarioct
            // 
            this.txtusuarioct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuarioct.Location = new System.Drawing.Point(93, 42);
            this.txtusuarioct.Name = "txtusuarioct";
            this.txtusuarioct.Size = new System.Drawing.Size(188, 20);
            this.txtusuarioct.TabIndex = 3;
            // 
            // txtcontrasenhact
            // 
            this.txtcontrasenhact.Location = new System.Drawing.Point(93, 87);
            this.txtcontrasenhact.Name = "txtcontrasenhact";
            this.txtcontrasenhact.Size = new System.Drawing.Size(188, 20);
            this.txtcontrasenhact.TabIndex = 4;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(6, 42);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(46, 13);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblContraSenha
            // 
            this.lblContraSenha.AutoSize = true;
            this.lblContraSenha.Location = new System.Drawing.Point(6, 87);
            this.lblContraSenha.Name = "lblContraSenha";
            this.lblContraSenha.Size = new System.Drawing.Size(75, 13);
            this.lblContraSenha.TabIndex = 0;
            this.lblContraSenha.Text = "Contra-Senha:";
            // 
            // grpemail
            // 
            this.grpemail.Controls.Add(this.btnenviaremail);
            this.grpemail.Controls.Add(this.btnvalidarem);
            this.grpemail.Controls.Add(this.pnredemail);
            this.grpemail.Controls.Add(this.txtusuarioem);
            this.grpemail.Controls.Add(this.txtcodigoemail);
            this.grpemail.Controls.Add(this.label3);
            this.grpemail.Controls.Add(this.label4);
            this.grpemail.Enabled = false;
            this.grpemail.Location = new System.Drawing.Point(12, 46);
            this.grpemail.Name = "grpemail";
            this.grpemail.Size = new System.Drawing.Size(590, 155);
            this.grpemail.TabIndex = 7;
            this.grpemail.TabStop = false;
            this.grpemail.Text = "Redefinir pelo E-mail";
            // 
            // btnenviaremail
            // 
            this.btnenviaremail.Location = new System.Drawing.Point(128, 120);
            this.btnenviaremail.Name = "btnenviaremail";
            this.btnenviaremail.Size = new System.Drawing.Size(75, 23);
            this.btnenviaremail.TabIndex = 7;
            this.btnenviaremail.Text = "Enviar";
            this.btnenviaremail.UseVisualStyleBackColor = true;
            this.btnenviaremail.Click += new System.EventHandler(this.btnenviaremail_Click);
            // 
            // btnvalidarem
            // 
            this.btnvalidarem.Enabled = false;
            this.btnvalidarem.Location = new System.Drawing.Point(208, 120);
            this.btnvalidarem.Name = "btnvalidarem";
            this.btnvalidarem.Size = new System.Drawing.Size(73, 23);
            this.btnvalidarem.TabIndex = 6;
            this.btnvalidarem.Text = "Validar ";
            this.btnvalidarem.UseVisualStyleBackColor = true;
            this.btnvalidarem.Click += new System.EventHandler(this.btnvalidarem_Click);
            // 
            // pnredemail
            // 
            this.pnredemail.Controls.Add(this.bnsalvarem);
            this.pnredemail.Controls.Add(this.txtcnovasenhaem);
            this.pnredemail.Controls.Add(this.txtnovasenhaem);
            this.pnredemail.Controls.Add(this.label1);
            this.pnredemail.Controls.Add(this.label2);
            this.pnredemail.Enabled = false;
            this.pnredemail.Location = new System.Drawing.Point(304, 28);
            this.pnredemail.Name = "pnredemail";
            this.pnredemail.Size = new System.Drawing.Size(280, 121);
            this.pnredemail.TabIndex = 5;
            // 
            // bnsalvarem
            // 
            this.bnsalvarem.Location = new System.Drawing.Point(193, 92);
            this.bnsalvarem.Name = "bnsalvarem";
            this.bnsalvarem.Size = new System.Drawing.Size(75, 23);
            this.bnsalvarem.TabIndex = 4;
            this.bnsalvarem.Text = "Salvar";
            this.bnsalvarem.UseVisualStyleBackColor = true;
            this.bnsalvarem.Click += new System.EventHandler(this.bnsalvarem_Click);
            // 
            // txtcnovasenhaem
            // 
            this.txtcnovasenhaem.Location = new System.Drawing.Point(130, 56);
            this.txtcnovasenhaem.Name = "txtcnovasenhaem";
            this.txtcnovasenhaem.Size = new System.Drawing.Size(138, 20);
            this.txtcnovasenhaem.TabIndex = 3;
            // 
            // txtnovasenhaem
            // 
            this.txtnovasenhaem.Location = new System.Drawing.Point(130, 17);
            this.txtnovasenhaem.Name = "txtnovasenhaem";
            this.txtnovasenhaem.Size = new System.Drawing.Size(138, 20);
            this.txtnovasenhaem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirme a nova Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite a Nova Senha:";
            // 
            // txtusuarioem
            // 
            this.txtusuarioem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuarioem.Location = new System.Drawing.Point(93, 42);
            this.txtusuarioem.Name = "txtusuarioem";
            this.txtusuarioem.Size = new System.Drawing.Size(188, 20);
            this.txtusuarioem.TabIndex = 3;
            // 
            // txtcodigoemail
            // 
            this.txtcodigoemail.Location = new System.Drawing.Point(128, 84);
            this.txtcodigoemail.Name = "txtcodigoemail";
            this.txtcodigoemail.Size = new System.Drawing.Size(156, 20);
            this.txtcodigoemail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo Enviado E-mail:";
            // 
            // FormEsqueceuasenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 224);
            this.Controls.Add(this.grpemail);
            this.Controls.Add(this.grpcontrasenha);
            this.Controls.Add(this.lblselecao);
            this.Controls.Add(this.cbxEscolha);
            this.Name = "FormEsqueceuasenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redeinição de Senha";
            this.grpcontrasenha.ResumeLayout(false);
            this.grpcontrasenha.PerformLayout();
            this.painelnovasenha1.ResumeLayout(false);
            this.painelnovasenha1.PerformLayout();
            this.grpemail.ResumeLayout(false);
            this.grpemail.PerformLayout();
            this.pnredemail.ResumeLayout(false);
            this.pnredemail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEscolha;
        private System.Windows.Forms.Label lblselecao;
        private System.Windows.Forms.GroupBox grpcontrasenha;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.Panel painelnovasenha1;
        private System.Windows.Forms.Button btnsalvardados;
        private System.Windows.Forms.TextBox txtcnovasenhact2;
        private System.Windows.Forms.TextBox txtnovasenhact;
        private System.Windows.Forms.Label lblconfirmnovasenha;
        private System.Windows.Forms.Label lblNovasenha;
        private System.Windows.Forms.TextBox txtusuarioct;
        private System.Windows.Forms.TextBox txtcontrasenhact;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblContraSenha;
        private System.Windows.Forms.GroupBox grpemail;
        private System.Windows.Forms.Button btnvalidarem;
        private System.Windows.Forms.Panel pnredemail;
        private System.Windows.Forms.Button bnsalvarem;
        private System.Windows.Forms.TextBox txtcnovasenhaem;
        private System.Windows.Forms.TextBox txtnovasenhaem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuarioem;
        private System.Windows.Forms.TextBox txtcodigoemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnenviaremail;
    }
}