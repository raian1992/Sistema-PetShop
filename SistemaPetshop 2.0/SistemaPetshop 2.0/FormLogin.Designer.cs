namespace SistemaPetshop_2._0
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btnconectar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblesqueceusenha = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(17, 23);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(46, 13);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuario.Location = new System.Drawing.Point(69, 20);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(177, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            this.txtusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusuario_KeyDown);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(17, 67);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(41, 13);
            this.lblsenha.TabIndex = 2;
            this.lblsenha.Text = "Senha:";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(69, 60);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(177, 20);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.UseSystemPasswordChar = true;
            this.txtsenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsenha_KeyPress);
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(262, 37);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(75, 23);
            this.btnconectar.TabIndex = 4;
            this.btnconectar.Text = "Entrar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblesqueceusenha);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.btnconectar);
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Controls.Add(this.txtsenha);
            this.panel1.Controls.Add(this.lblsenha);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 116);
            this.panel1.TabIndex = 5;
            // 
            // lblesqueceusenha
            // 
            this.lblesqueceusenha.AutoSize = true;
            this.lblesqueceusenha.Location = new System.Drawing.Point(66, 92);
            this.lblesqueceusenha.Name = "lblesqueceusenha";
            this.lblesqueceusenha.Size = new System.Drawing.Size(101, 13);
            this.lblesqueceusenha.TabIndex = 5;
            this.lblesqueceusenha.TabStop = true;
            this.lblesqueceusenha.Text = "Esqueceu  a Senha";
            this.lblesqueceusenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblesqueceusenha_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 140);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormLogin_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblesqueceusenha;
    }
}

