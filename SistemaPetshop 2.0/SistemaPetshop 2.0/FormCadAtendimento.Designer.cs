
namespace SistemaPetshop_2._0
{
    partial class FormCadAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadAtendimento));
            this.tabCadastro = new System.Windows.Forms.TabControl();
            this.atendimento = new System.Windows.Forms.TabPage();
            this.tabcadatendimento = new System.Windows.Forms.TabControl();
            this.tabprop = new System.Windows.Forms.TabPage();
            this.btnproximo = new System.Windows.Forms.Button();
            this.btnnovoprop = new System.Windows.Forms.Button();
            this.btnbuscarprop = new System.Windows.Forms.Button();
            this.cadprop = new SistemaPetshop_2._0.USCADPROP();
            this.pnprop = new System.Windows.Forms.Panel();
            this.tabpet = new System.Windows.Forms.TabPage();
            this.pnpet = new System.Windows.Forms.Panel();
            this.btnavançarpet = new System.Windows.Forms.Button();
            this.btnnovopet = new System.Windows.Forms.Button();
            this.btnbuscarpet = new System.Windows.Forms.Button();
            this.cadpet = new SistemaPetshop_2._0.USCADPET();
            this.tabnovoatendimento = new System.Windows.Forms.TabPage();
            this.pnnovoatendimento = new System.Windows.Forms.Panel();
            this.tabListagem = new System.Windows.Forms.TabPage();
            this.tabCadastro.SuspendLayout();
            this.atendimento.SuspendLayout();
            this.tabcadatendimento.SuspendLayout();
            this.tabprop.SuspendLayout();
            this.tabpet.SuspendLayout();
            this.pnpet.SuspendLayout();
            this.tabnovoatendimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCadastro
            // 
            this.tabCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCadastro.Controls.Add(this.atendimento);
            this.tabCadastro.Controls.Add(this.tabListagem);
            this.tabCadastro.Location = new System.Drawing.Point(0, 0);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.SelectedIndex = 0;
            this.tabCadastro.Size = new System.Drawing.Size(788, 549);
            this.tabCadastro.TabIndex = 0;
            // 
            // atendimento
            // 
            this.atendimento.Controls.Add(this.tabcadatendimento);
            this.atendimento.Location = new System.Drawing.Point(4, 22);
            this.atendimento.Name = "atendimento";
            this.atendimento.Padding = new System.Windows.Forms.Padding(3);
            this.atendimento.Size = new System.Drawing.Size(780, 523);
            this.atendimento.TabIndex = 1;
            this.atendimento.Text = "Atendimento";
            this.atendimento.UseVisualStyleBackColor = true;
            // 
            // tabcadatendimento
            // 
            this.tabcadatendimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcadatendimento.Controls.Add(this.tabprop);
            this.tabcadatendimento.Controls.Add(this.tabpet);
            this.tabcadatendimento.Controls.Add(this.tabnovoatendimento);
            this.tabcadatendimento.Location = new System.Drawing.Point(8, 6);
            this.tabcadatendimento.Name = "tabcadatendimento";
            this.tabcadatendimento.SelectedIndex = 0;
            this.tabcadatendimento.Size = new System.Drawing.Size(769, 508);
            this.tabcadatendimento.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabcadatendimento.TabIndex = 0;
            // 
            // tabprop
            // 
            this.tabprop.Controls.Add(this.btnproximo);
            this.tabprop.Controls.Add(this.btnnovoprop);
            this.tabprop.Controls.Add(this.btnbuscarprop);
            this.tabprop.Controls.Add(this.cadprop);
            this.tabprop.Controls.Add(this.pnprop);
            this.tabprop.Location = new System.Drawing.Point(4, 22);
            this.tabprop.Name = "tabprop";
            this.tabprop.Padding = new System.Windows.Forms.Padding(3);
            this.tabprop.Size = new System.Drawing.Size(761, 482);
            this.tabprop.TabIndex = 0;
            this.tabprop.Text = "Proprietario";
            this.tabprop.UseVisualStyleBackColor = true;
            // 
            // btnproximo
            // 
            this.btnproximo.Location = new System.Drawing.Point(620, 444);
            this.btnproximo.Name = "btnproximo";
            this.btnproximo.Size = new System.Drawing.Size(75, 23);
            this.btnproximo.TabIndex = 1;
            this.btnproximo.Text = "Continuar";
            this.btnproximo.UseVisualStyleBackColor = true;
            this.btnproximo.Click += new System.EventHandler(this.btnproximo_Click);
            // 
            // btnnovoprop
            // 
            this.btnnovoprop.Location = new System.Drawing.Point(277, 39);
            this.btnnovoprop.Name = "btnnovoprop";
            this.btnnovoprop.Size = new System.Drawing.Size(75, 23);
            this.btnnovoprop.TabIndex = 2;
            this.btnnovoprop.Text = "Novo";
            this.btnnovoprop.UseVisualStyleBackColor = true;
            this.btnnovoprop.Click += new System.EventHandler(this.btnnovoprop_Click);
            // 
            // btnbuscarprop
            // 
            this.btnbuscarprop.Location = new System.Drawing.Point(185, 39);
            this.btnbuscarprop.Name = "btnbuscarprop";
            this.btnbuscarprop.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarprop.TabIndex = 1;
            this.btnbuscarprop.Text = "Buscar";
            this.btnbuscarprop.UseVisualStyleBackColor = true;
            this.btnbuscarprop.Click += new System.EventHandler(this.btnbuscarprop_Click);
            // 
            // cadprop
            // 
            this.cadprop.Location = new System.Drawing.Point(79, 39);
            this.cadprop.MinimumSize = new System.Drawing.Size(548, 399);
            this.cadprop.Name = "cadprop";
            this.cadprop.Size = new System.Drawing.Size(548, 399);
            this.cadprop.TabIndex = 0;
            // 
            // pnprop
            // 
            this.pnprop.Location = new System.Drawing.Point(34, 19);
            this.pnprop.Name = "pnprop";
            this.pnprop.Size = new System.Drawing.Size(679, 457);
            this.pnprop.TabIndex = 3;
            // 
            // tabpet
            // 
            this.tabpet.Controls.Add(this.pnpet);
            this.tabpet.Location = new System.Drawing.Point(4, 22);
            this.tabpet.Name = "tabpet";
            this.tabpet.Padding = new System.Windows.Forms.Padding(3);
            this.tabpet.Size = new System.Drawing.Size(761, 482);
            this.tabpet.TabIndex = 1;
            this.tabpet.Text = "Pet";
            this.tabpet.UseVisualStyleBackColor = true;
            // 
            // pnpet
            // 
            this.pnpet.Controls.Add(this.btnavançarpet);
            this.pnpet.Controls.Add(this.btnnovopet);
            this.pnpet.Controls.Add(this.btnbuscarpet);
            this.pnpet.Controls.Add(this.cadpet);
            this.pnpet.Location = new System.Drawing.Point(18, 6);
            this.pnpet.Name = "pnpet";
            this.pnpet.Size = new System.Drawing.Size(724, 418);
            this.pnpet.TabIndex = 6;
            // 
            // btnavançarpet
            // 
            this.btnavançarpet.Location = new System.Drawing.Point(505, 378);
            this.btnavançarpet.Name = "btnavançarpet";
            this.btnavançarpet.Size = new System.Drawing.Size(75, 23);
            this.btnavançarpet.TabIndex = 7;
            this.btnavançarpet.Text = "Continuar";
            this.btnavançarpet.UseVisualStyleBackColor = true;
            this.btnavançarpet.Click += new System.EventHandler(this.btnavançarpet_Click);
            // 
            // btnnovopet
            // 
            this.btnnovopet.Location = new System.Drawing.Point(250, 18);
            this.btnnovopet.Name = "btnnovopet";
            this.btnnovopet.Size = new System.Drawing.Size(75, 23);
            this.btnnovopet.TabIndex = 9;
            this.btnnovopet.Text = "Novo";
            this.btnnovopet.UseVisualStyleBackColor = true;
            this.btnnovopet.Click += new System.EventHandler(this.btnnovopet_Click_1);
            // 
            // btnbuscarpet
            // 
            this.btnbuscarpet.Location = new System.Drawing.Point(158, 18);
            this.btnbuscarpet.Name = "btnbuscarpet";
            this.btnbuscarpet.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarpet.TabIndex = 8;
            this.btnbuscarpet.Text = "Buscar";
            this.btnbuscarpet.UseVisualStyleBackColor = true;
            this.btnbuscarpet.Click += new System.EventHandler(this.btnbuscarpet_Click_1);
            // 
            // cadpet
            // 
            this.cadpet.Location = new System.Drawing.Point(22, 47);
            this.cadpet.Name = "cadpet";
            this.cadpet.Size = new System.Drawing.Size(680, 306);
            this.cadpet.TabIndex = 6;
            // 
            // tabnovoatendimento
            // 
            this.tabnovoatendimento.Controls.Add(this.pnnovoatendimento);
            this.tabnovoatendimento.Location = new System.Drawing.Point(4, 22);
            this.tabnovoatendimento.Name = "tabnovoatendimento";
            this.tabnovoatendimento.Size = new System.Drawing.Size(761, 482);
            this.tabnovoatendimento.TabIndex = 2;
            this.tabnovoatendimento.Text = "Dados do Atendimento";
            this.tabnovoatendimento.UseVisualStyleBackColor = true;
            // 
            // pnnovoatendimento
            // 
            this.pnnovoatendimento.Location = new System.Drawing.Point(0, 0);
            this.pnnovoatendimento.Name = "pnnovoatendimento";
            this.pnnovoatendimento.Size = new System.Drawing.Size(758, 479);
            this.pnnovoatendimento.TabIndex = 0;
            // 
            // tabListagem
            // 
            this.tabListagem.Location = new System.Drawing.Point(4, 22);
            this.tabListagem.Name = "tabListagem";
            this.tabListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tabListagem.Size = new System.Drawing.Size(780, 523);
            this.tabListagem.TabIndex = 0;
            this.tabListagem.Text = "Listagem de Atendimentos";
            this.tabListagem.UseVisualStyleBackColor = true;
            // 
            // FormCadAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.tabCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.FormCadAtendimento_Load);
            this.tabCadastro.ResumeLayout(false);
            this.atendimento.ResumeLayout(false);
            this.tabcadatendimento.ResumeLayout(false);
            this.tabprop.ResumeLayout(false);
            this.tabpet.ResumeLayout(false);
            this.pnpet.ResumeLayout(false);
            this.tabnovoatendimento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCadastro;
        private System.Windows.Forms.TabPage tabListagem;
        private System.Windows.Forms.TabPage atendimento;
        private System.Windows.Forms.TabControl tabcadatendimento;
        private System.Windows.Forms.TabPage tabprop;
        private USCADPROP cadprop;
        private System.Windows.Forms.TabPage tabpet;
        private System.Windows.Forms.TabPage tabnovoatendimento;
        private System.Windows.Forms.Button btnnovoprop;
        private System.Windows.Forms.Button btnbuscarprop;
        private System.Windows.Forms.Button btnproximo;
        private System.Windows.Forms.Panel pnprop;
        private System.Windows.Forms.Panel pnpet;
        private System.Windows.Forms.Button btnavançarpet;
        private System.Windows.Forms.Button btnnovopet;
        private System.Windows.Forms.Button btnbuscarpet;
        private USCADPET cadpet;
        private System.Windows.Forms.Panel pnnovoatendimento;
    }
}