namespace SistemaPetshop_2._0
{
    partial class FormCadServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadServico));
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.chkbativo = new System.Windows.Forms.CheckBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.mtxtvalor = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Location = new System.Drawing.Point(12, 35);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(58, 13);
            this.lbldescricao.TabIndex = 0;
            this.lbldescricao.Text = "Descricao:";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(12, 75);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(34, 13);
            this.lblvalor.TabIndex = 1;
            this.lblvalor.Text = "Valor:";
            // 
            // chkbativo
            // 
            this.chkbativo.AutoSize = true;
            this.chkbativo.Location = new System.Drawing.Point(367, 12);
            this.chkbativo.Name = "chkbativo";
            this.chkbativo.Size = new System.Drawing.Size(50, 17);
            this.chkbativo.TabIndex = 2;
            this.chkbativo.Text = "Ativo";
            this.chkbativo.UseVisualStyleBackColor = true;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(76, 32);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(341, 20);
            this.txtdescricao.TabIndex = 3;
            // 
            // mtxtvalor
            // 
            this.mtxtvalor.Location = new System.Drawing.Point(76, 75);
            this.mtxtvalor.Name = "mtxtvalor";
            this.mtxtvalor.Size = new System.Drawing.Size(75, 20);
            this.mtxtvalor.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(133, 133);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(245, 133);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // FormCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 186);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mtxtvalor);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.chkbativo);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lbldescricao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Serviços";
            this.Load += new System.EventHandler(this.FormCadServico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.CheckBox chkbativo;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.MaskedTextBox mtxtvalor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btncancelar;
    }
}