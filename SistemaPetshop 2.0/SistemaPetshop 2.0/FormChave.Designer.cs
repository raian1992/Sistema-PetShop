namespace SistemaPetshop_2._0
{
    partial class FormChave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChave));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblserialold = new System.Windows.Forms.Label();
            this.lblserialnovo = new System.Windows.Forms.Label();
            this.txtserialold = new System.Windows.Forms.TextBox();
            this.txtserienova = new System.Windows.Forms.TextBox();
            this.btncopiar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.buscarpastas = new System.Windows.Forms.FolderBrowserDialog();
            this.buscararquivos = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarArquivoToolStripMenuItem,
            this.carregarArquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(0, 200);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerarArquivoToolStripMenuItem
            // 
            this.gerarArquivoToolStripMenuItem.Image = global::SistemaPetshop_2._0.Properties.Resources.imagem_carregar;
            this.gerarArquivoToolStripMenuItem.Name = "gerarArquivoToolStripMenuItem";
            this.gerarArquivoToolStripMenuItem.Size = new System.Drawing.Size(198, 20);
            this.gerarArquivoToolStripMenuItem.Text = "Gerar Arquivo Para Atualizacao";
            this.gerarArquivoToolStripMenuItem.Click += new System.EventHandler(this.gerarArquivoToolStripMenuItem_Click);
            // 
            // carregarArquivoToolStripMenuItem
            // 
            this.carregarArquivoToolStripMenuItem.Image = global::SistemaPetshop_2._0.Properties.Resources.imagem_salvar;
            this.carregarArquivoToolStripMenuItem.Name = "carregarArquivoToolStripMenuItem";
            this.carregarArquivoToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.carregarArquivoToolStripMenuItem.Text = "Buscar Arquivo Atualizado";
            this.carregarArquivoToolStripMenuItem.Click += new System.EventHandler(this.carregarArquivoToolStripMenuItem_Click);
            // 
            // lblserialold
            // 
            this.lblserialold.AutoSize = true;
            this.lblserialold.Location = new System.Drawing.Point(12, 47);
            this.lblserialold.Name = "lblserialold";
            this.lblserialold.Size = new System.Drawing.Size(69, 13);
            this.lblserialold.TabIndex = 9999;
            this.lblserialold.Text = "Serial Antigo:";
            // 
            // lblserialnovo
            // 
            this.lblserialnovo.AutoSize = true;
            this.lblserialnovo.Location = new System.Drawing.Point(12, 88);
            this.lblserialnovo.Name = "lblserialnovo";
            this.lblserialnovo.Size = new System.Drawing.Size(65, 13);
            this.lblserialnovo.TabIndex = 2;
            this.lblserialnovo.Text = "Serial Novo:";
            // 
            // txtserialold
            // 
            this.txtserialold.Enabled = false;
            this.txtserialold.Location = new System.Drawing.Point(83, 44);
            this.txtserialold.Name = "txtserialold";
            this.txtserialold.Size = new System.Drawing.Size(371, 20);
            this.txtserialold.TabIndex = 9998;
            // 
            // txtserienova
            // 
            this.txtserienova.Location = new System.Drawing.Point(83, 85);
            this.txtserienova.Name = "txtserienova";
            this.txtserienova.Size = new System.Drawing.Size(371, 20);
            this.txtserienova.TabIndex = 2;
            // 
            // btncopiar
            // 
            this.btncopiar.Location = new System.Drawing.Point(474, 44);
            this.btncopiar.Name = "btncopiar";
            this.btncopiar.Size = new System.Drawing.Size(75, 23);
            this.btncopiar.TabIndex = 1;
            this.btncopiar.Text = "Copiar";
            this.btncopiar.UseVisualStyleBackColor = true;
            this.btncopiar.Click += new System.EventHandler(this.btncopiar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(474, 126);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // buscararquivos
            // 
            this.buscararquivos.FileName = "Buscar novo serial";
            // 
            // FormChave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.btncopiar);
            this.Controls.Add(this.txtserienova);
            this.Controls.Add(this.txtserialold);
            this.Controls.Add(this.lblserialnovo);
            this.Controls.Add(this.lblserialold);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "FormChave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chave de Liberação";
            this.Load += new System.EventHandler(this.FormChave_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarArquivoToolStripMenuItem;
        private System.Windows.Forms.Label lblserialold;
        private System.Windows.Forms.Label lblserialnovo;
        private System.Windows.Forms.TextBox txtserialold;
        private System.Windows.Forms.TextBox txtserienova;
        private System.Windows.Forms.Button btncopiar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.FolderBrowserDialog buscarpastas;
        private System.Windows.Forms.OpenFileDialog buscararquivos;
    }
}