namespace SistemaPetshop_2._0
{
    partial class FormVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVet));
            this.lblnomeVet = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblCRMV = new System.Windows.Forms.Label();
            this.mtxttelres = new System.Windows.Forms.MaskedTextBox();
            this.mtxtcel = new System.Windows.Forms.MaskedTextBox();
            this.lblres = new System.Windows.Forms.Label();
            this.lblcel = new System.Windows.Forms.Label();
            this.txtnomvet = new System.Windows.Forms.TextBox();
            this.txtcpfvet = new System.Windows.Forms.TextBox();
            this.txtcrmv = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblnomeVet
            // 
            this.lblnomeVet.AutoSize = true;
            this.lblnomeVet.Location = new System.Drawing.Point(23, 59);
            this.lblnomeVet.Name = "lblnomeVet";
            this.lblnomeVet.Size = new System.Drawing.Size(72, 13);
            this.lblnomeVet.TabIndex = 0;
            this.lblnomeVet.Text = "Veterinario(a):";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(65, 82);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 13);
            this.lblcpf.TabIndex = 1;
            this.lblcpf.Text = "CPF:";
            // 
            // lblCRMV
            // 
            this.lblCRMV.AutoSize = true;
            this.lblCRMV.Location = new System.Drawing.Point(317, 82);
            this.lblCRMV.Name = "lblCRMV";
            this.lblCRMV.Size = new System.Drawing.Size(41, 13);
            this.lblCRMV.TabIndex = 2;
            this.lblCRMV.Text = "CRMV:";
            // 
            // mtxttelres
            // 
            this.mtxttelres.Location = new System.Drawing.Point(101, 116);
            this.mtxttelres.Mask = "(999) 0000-0000";
            this.mtxttelres.Name = "mtxttelres";
            this.mtxttelres.Size = new System.Drawing.Size(113, 20);
            this.mtxttelres.TabIndex = 4;
            this.mtxttelres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxttelres_KeyPress);
            // 
            // mtxtcel
            // 
            this.mtxtcel.Location = new System.Drawing.Point(388, 116);
            this.mtxtcel.Mask = "(999) 00000-0000";
            this.mtxtcel.Name = "mtxtcel";
            this.mtxtcel.Size = new System.Drawing.Size(140, 20);
            this.mtxtcel.TabIndex = 5;
            this.mtxtcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtcel_KeyPress);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(9, 119);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(86, 13);
            this.lblres.TabIndex = 38;
            this.lblres.Text = "Tel. Residencial:";
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.Location = new System.Drawing.Point(317, 119);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(42, 13);
            this.lblcel.TabIndex = 39;
            this.lblcel.Text = "Celular:";
            // 
            // txtnomvet
            // 
            this.txtnomvet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomvet.Location = new System.Drawing.Point(101, 56);
            this.txtnomvet.MaxLength = 40;
            this.txtnomvet.Name = "txtnomvet";
            this.txtnomvet.Size = new System.Drawing.Size(427, 20);
            this.txtnomvet.TabIndex = 0;
            // 
            // txtcpfvet
            // 
            this.txtcpfvet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcpfvet.Location = new System.Drawing.Point(101, 82);
            this.txtcpfvet.MaxLength = 11;
            this.txtcpfvet.Name = "txtcpfvet";
            this.txtcpfvet.Size = new System.Drawing.Size(163, 20);
            this.txtcpfvet.TabIndex = 1;
            this.txtcpfvet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtcrmv
            // 
            this.txtcrmv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcrmv.Location = new System.Drawing.Point(388, 82);
            this.txtcrmv.MaxLength = 20;
            this.txtcrmv.Name = "txtcrmv";
            this.txtcrmv.Size = new System.Drawing.Size(140, 20);
            this.txtcrmv.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(342, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(172, 206);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(470, 23);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(58, 17);
            this.chkAtivo.TabIndex = 8;
            this.chkAtivo.Text = "ATIVO";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // FormVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtcrmv);
            this.Controls.Add(this.txtcpfvet);
            this.Controls.Add(this.txtnomvet);
            this.Controls.Add(this.mtxttelres);
            this.Controls.Add(this.mtxtcel);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lblcel);
            this.Controls.Add(this.lblCRMV);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblnomeVet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "FormVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações dos Veterinarios (as)";
            this.Load += new System.EventHandler(this.FormVet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnomeVet;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblCRMV;
        private System.Windows.Forms.MaskedTextBox mtxttelres;
        private System.Windows.Forms.MaskedTextBox mtxtcel;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.TextBox txtnomvet;
        private System.Windows.Forms.TextBox txtcpfvet;
        private System.Windows.Forms.TextBox txtcrmv;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox chkAtivo;
    }
}