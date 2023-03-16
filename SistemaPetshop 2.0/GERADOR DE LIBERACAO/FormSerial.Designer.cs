namespace GERADOR_DE_LIBERACAO
{
    partial class FormSerial
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
            this.grpdados = new System.Windows.Forms.GroupBox();
            this.lblserialold = new System.Windows.Forms.Label();
            this.painelqtdecnpj = new System.Windows.Forms.Panel();
            this.lblqtdecnpj = new System.Windows.Forms.Label();
            this.chkbskatualizacnpj = new System.Windows.Forms.CheckBox();
            this.lblserialnovo = new System.Windows.Forms.Label();
            this.txtserieantiga = new System.Windows.Forms.TextBox();
            this.txtserienova = new System.Windows.Forms.TextBox();
            this.lbldataliberacao = new System.Windows.Forms.Label();
            this.dtpproximovencimento = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtqtdecnpj = new System.Windows.Forms.TextBox();
            this.btngerarserial = new System.Windows.Forms.Button();
            this.Btncopiar = new System.Windows.Forms.Button();
            this.buscarpastas = new System.Windows.Forms.FolderBrowserDialog();
            this.buscararquivos = new System.Windows.Forms.OpenFileDialog();
            this.grpdados.SuspendLayout();
            this.painelqtdecnpj.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpdados
            // 
            this.grpdados.Controls.Add(this.Btncopiar);
            this.grpdados.Controls.Add(this.btngerarserial);
            this.grpdados.Controls.Add(this.button1);
            this.grpdados.Controls.Add(this.dtpproximovencimento);
            this.grpdados.Controls.Add(this.lbldataliberacao);
            this.grpdados.Controls.Add(this.txtserienova);
            this.grpdados.Controls.Add(this.txtserieantiga);
            this.grpdados.Controls.Add(this.lblserialnovo);
            this.grpdados.Controls.Add(this.chkbskatualizacnpj);
            this.grpdados.Controls.Add(this.painelqtdecnpj);
            this.grpdados.Controls.Add(this.lblserialold);
            this.grpdados.Location = new System.Drawing.Point(12, 12);
            this.grpdados.Name = "grpdados";
            this.grpdados.Size = new System.Drawing.Size(574, 194);
            this.grpdados.TabIndex = 0;
            this.grpdados.TabStop = false;
            this.grpdados.Text = "Dados Necessarios";
            // 
            // lblserialold
            // 
            this.lblserialold.AutoSize = true;
            this.lblserialold.Location = new System.Drawing.Point(6, 30);
            this.lblserialold.Name = "lblserialold";
            this.lblserialold.Size = new System.Drawing.Size(69, 13);
            this.lblserialold.TabIndex = 0;
            this.lblserialold.Text = "Serial Antigo:";
            // 
            // painelqtdecnpj
            // 
            this.painelqtdecnpj.Controls.Add(this.txtqtdecnpj);
            this.painelqtdecnpj.Controls.Add(this.lblqtdecnpj);
            this.painelqtdecnpj.Location = new System.Drawing.Point(245, 65);
            this.painelqtdecnpj.Name = "painelqtdecnpj";
            this.painelqtdecnpj.Size = new System.Drawing.Size(216, 26);
            this.painelqtdecnpj.TabIndex = 1;
            this.painelqtdecnpj.Visible = false;
            // 
            // lblqtdecnpj
            // 
            this.lblqtdecnpj.AutoSize = true;
            this.lblqtdecnpj.Location = new System.Drawing.Point(8, 6);
            this.lblqtdecnpj.Name = "lblqtdecnpj";
            this.lblqtdecnpj.Size = new System.Drawing.Size(95, 13);
            this.lblqtdecnpj.TabIndex = 0;
            this.lblqtdecnpj.Text = "Quantidade CNPJ:";
            // 
            // chkbskatualizacnpj
            // 
            this.chkbskatualizacnpj.AutoSize = true;
            this.chkbskatualizacnpj.Location = new System.Drawing.Point(9, 72);
            this.chkbskatualizacnpj.Name = "chkbskatualizacnpj";
            this.chkbskatualizacnpj.Size = new System.Drawing.Size(213, 17);
            this.chkbskatualizacnpj.TabIndex = 2;
            this.chkbskatualizacnpj.Text = "Alterar Quantidade de Filiais no Cliente?";
            this.chkbskatualizacnpj.UseVisualStyleBackColor = true;
            this.chkbskatualizacnpj.CheckedChanged += new System.EventHandler(this.chkbskatualizacnpj_CheckedChanged);
            // 
            // lblserialnovo
            // 
            this.lblserialnovo.AutoSize = true;
            this.lblserialnovo.Location = new System.Drawing.Point(6, 146);
            this.lblserialnovo.Name = "lblserialnovo";
            this.lblserialnovo.Size = new System.Drawing.Size(65, 13);
            this.lblserialnovo.TabIndex = 3;
            this.lblserialnovo.Text = "Serial Novo:";
            // 
            // txtserieantiga
            // 
            this.txtserieantiga.Location = new System.Drawing.Point(81, 27);
            this.txtserieantiga.Name = "txtserieantiga";
            this.txtserieantiga.Size = new System.Drawing.Size(378, 20);
            this.txtserieantiga.TabIndex = 0;
            // 
            // txtserienova
            // 
            this.txtserienova.Enabled = false;
            this.txtserienova.Location = new System.Drawing.Point(81, 146);
            this.txtserienova.Name = "txtserienova";
            this.txtserienova.Size = new System.Drawing.Size(378, 20);
            this.txtserienova.TabIndex = 5;
            // 
            // lbldataliberacao
            // 
            this.lbldataliberacao.AutoSize = true;
            this.lbldataliberacao.Location = new System.Drawing.Point(6, 105);
            this.lbldataliberacao.Name = "lbldataliberacao";
            this.lbldataliberacao.Size = new System.Drawing.Size(106, 13);
            this.lbldataliberacao.TabIndex = 6;
            this.lbldataliberacao.Text = "Proximo Vencimento:";
            // 
            // dtpproximovencimento
            // 
            this.dtpproximovencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpproximovencimento.Location = new System.Drawing.Point(119, 105);
            this.dtpproximovencimento.Name = "dtpproximovencimento";
            this.dtpproximovencimento.Size = new System.Drawing.Size(103, 20);
            this.dtpproximovencimento.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtqtdecnpj
            // 
            this.txtqtdecnpj.Location = new System.Drawing.Point(110, 4);
            this.txtqtdecnpj.MaxLength = 2;
            this.txtqtdecnpj.Name = "txtqtdecnpj";
            this.txtqtdecnpj.Size = new System.Drawing.Size(88, 20);
            this.txtqtdecnpj.TabIndex = 3;
            this.txtqtdecnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqtdecnpj_KeyPress);
            // 
            // btngerarserial
            // 
            this.btngerarserial.Location = new System.Drawing.Point(256, 101);
            this.btngerarserial.Name = "btngerarserial";
            this.btngerarserial.Size = new System.Drawing.Size(75, 23);
            this.btngerarserial.TabIndex = 7;
            this.btngerarserial.Text = "Gerar";
            this.btngerarserial.UseVisualStyleBackColor = true;
            this.btngerarserial.Click += new System.EventHandler(this.btngerarserial_Click);
            // 
            // Btncopiar
            // 
            this.Btncopiar.Location = new System.Drawing.Point(465, 146);
            this.Btncopiar.Name = "Btncopiar";
            this.Btncopiar.Size = new System.Drawing.Size(75, 23);
            this.Btncopiar.TabIndex = 8;
            this.Btncopiar.Text = "Copiar";
            this.Btncopiar.UseVisualStyleBackColor = true;
            this.Btncopiar.Click += new System.EventHandler(this.Btncopiar_Click);
            // 
            // buscararquivos
            // 
            this.buscararquivos.FileName = "Buscar novo serial";
            // 
            // FormSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpdados);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormSerial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Licensas";
            this.Load += new System.EventHandler(this.FormSerial_Load);
            this.grpdados.ResumeLayout(false);
            this.grpdados.PerformLayout();
            this.painelqtdecnpj.ResumeLayout(false);
            this.painelqtdecnpj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpdados;
        private System.Windows.Forms.Label lblserialnovo;
        private System.Windows.Forms.CheckBox chkbskatualizacnpj;
        private System.Windows.Forms.Panel painelqtdecnpj;
        private System.Windows.Forms.Label lblqtdecnpj;
        private System.Windows.Forms.Label lblserialold;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpproximovencimento;
        private System.Windows.Forms.Label lbldataliberacao;
        private System.Windows.Forms.TextBox txtserienova;
        private System.Windows.Forms.TextBox txtserieantiga;
        private System.Windows.Forms.TextBox txtqtdecnpj;
        private System.Windows.Forms.Button btngerarserial;
        private System.Windows.Forms.Button Btncopiar;
        private System.Windows.Forms.FolderBrowserDialog buscarpastas;
        private System.Windows.Forms.OpenFileDialog buscararquivos;
    }
}

