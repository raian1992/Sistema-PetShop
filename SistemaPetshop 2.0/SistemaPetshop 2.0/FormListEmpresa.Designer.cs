namespace SistemaPetshop_2._0
{
    partial class FormListEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListEmpresa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvlistempresa = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_FANTASIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInativar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistempresa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvlistempresa);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 201);
            this.panel1.TabIndex = 0;
            // 
            // dgvlistempresa
            // 
            this.dgvlistempresa.AllowUserToAddRows = false;
            this.dgvlistempresa.AllowUserToDeleteRows = false;
            this.dgvlistempresa.AllowUserToResizeColumns = false;
            this.dgvlistempresa.AllowUserToResizeRows = false;
            this.dgvlistempresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlistempresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvlistempresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME_FANTASIA,
            this.CNPJCPF,
            this.STATUS});
            this.dgvlistempresa.Location = new System.Drawing.Point(0, 0);
            this.dgvlistempresa.MultiSelect = false;
            this.dgvlistempresa.Name = "dgvlistempresa";
            this.dgvlistempresa.ReadOnly = true;
            this.dgvlistempresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlistempresa.Size = new System.Drawing.Size(764, 201);
            this.dgvlistempresa.TabIndex = 0;
            this.dgvlistempresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistempresa_CellContentClick);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "ID_EMPRESA";
            this.CODIGO.Frozen = true;
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 120;
            // 
            // NOME_FANTASIA
            // 
            this.NOME_FANTASIA.DataPropertyName = "FANTASIA";
            this.NOME_FANTASIA.Frozen = true;
            this.NOME_FANTASIA.HeaderText = "NOME FANTASIA";
            this.NOME_FANTASIA.Name = "NOME_FANTASIA";
            this.NOME_FANTASIA.ReadOnly = true;
            this.NOME_FANTASIA.Width = 400;
            // 
            // CNPJCPF
            // 
            this.CNPJCPF.DataPropertyName = "CNPJ_CPF";
            this.CNPJCPF.Frozen = true;
            this.CNPJCPF.HeaderText = "CNPJ/CPF";
            this.CNPJCPF.Name = "CNPJCPF";
            this.CNPJCPF.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.Frozen = true;
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.Location = new System.Drawing.Point(178, 240);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Adicionar";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(334, 240);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInativar
            // 
            this.btnInativar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInativar.Location = new System.Drawing.Point(488, 240);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(75, 23);
            this.btnInativar.TabIndex = 3;
            this.btnInativar.Text = "Inativar";
            this.btnInativar.UseVisualStyleBackColor = true;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // FormListEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 292);
            this.Controls.Add(this.btnInativar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(787, 331);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(787, 331);
            this.Name = "FormListEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Empresas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListEmpresa_FormClosing);
            this.Load += new System.EventHandler(this.FormListEmpresa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistempresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvlistempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_FANTASIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInativar;
    }
}