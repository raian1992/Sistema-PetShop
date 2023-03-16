
namespace SistemaPetshop_2._0
{
    partial class FormListPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPagamento));
            this.dgvPagamento = new System.Windows.Forms.DataGridView();
            this.brnCancelar = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.ClmIdPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTipoPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTaxas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPagamento
            // 
            this.dgvPagamento.AllowUserToAddRows = false;
            this.dgvPagamento.AllowUserToDeleteRows = false;
            this.dgvPagamento.AllowUserToResizeColumns = false;
            this.dgvPagamento.AllowUserToResizeRows = false;
            this.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmIdPag,
            this.ClmNome,
            this.ClmTipoPag,
            this.ClmTaxas,
            this.ClmAtivo,
            this.ClmEditar});
            this.dgvPagamento.Location = new System.Drawing.Point(7, 9);
            this.dgvPagamento.Name = "dgvPagamento";
            this.dgvPagamento.ReadOnly = true;
            this.dgvPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPagamento.Size = new System.Drawing.Size(640, 180);
            this.dgvPagamento.TabIndex = 0;
            this.dgvPagamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamento_CellContentClick);
            // 
            // brnCancelar
            // 
            this.brnCancelar.Location = new System.Drawing.Point(378, 211);
            this.brnCancelar.Name = "brnCancelar";
            this.brnCancelar.Size = new System.Drawing.Size(75, 23);
            this.brnCancelar.TabIndex = 4;
            this.brnCancelar.Text = "Cancelar";
            this.brnCancelar.UseVisualStyleBackColor = true;
            this.brnCancelar.Click += new System.EventHandler(this.brnCancelar_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(176, 211);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 3;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // ClmIdPag
            // 
            this.ClmIdPag.DataPropertyName = "ID_PAGAMENTOS";
            this.ClmIdPag.Frozen = true;
            this.ClmIdPag.HeaderText = "Codigo";
            this.ClmIdPag.Name = "ClmIdPag";
            this.ClmIdPag.ReadOnly = true;
            this.ClmIdPag.Width = 70;
            // 
            // ClmNome
            // 
            this.ClmNome.DataPropertyName = "NOME";
            this.ClmNome.Frozen = true;
            this.ClmNome.HeaderText = "Descrição";
            this.ClmNome.Name = "ClmNome";
            this.ClmNome.ReadOnly = true;
            this.ClmNome.Width = 130;
            // 
            // ClmTipoPag
            // 
            this.ClmTipoPag.DataPropertyName = "Pagamentos";
            this.ClmTipoPag.Frozen = true;
            this.ClmTipoPag.HeaderText = "Tipo do Pagamento";
            this.ClmTipoPag.Name = "ClmTipoPag";
            this.ClmTipoPag.ReadOnly = true;
            this.ClmTipoPag.Width = 120;
            // 
            // ClmTaxas
            // 
            this.ClmTaxas.DataPropertyName = "TAXA";
            this.ClmTaxas.Frozen = true;
            this.ClmTaxas.HeaderText = "Tipo de Taxa";
            this.ClmTaxas.Name = "ClmTaxas";
            this.ClmTaxas.ReadOnly = true;
            this.ClmTaxas.Width = 120;
            // 
            // ClmAtivo
            // 
            this.ClmAtivo.DataPropertyName = "ATIVO";
            this.ClmAtivo.Frozen = true;
            this.ClmAtivo.HeaderText = "Ativo";
            this.ClmAtivo.Name = "ClmAtivo";
            this.ClmAtivo.ReadOnly = true;
            this.ClmAtivo.Width = 80;
            // 
            // ClmEditar
            // 
            this.ClmEditar.Frozen = true;
            this.ClmEditar.HeaderText = "Editar";
            this.ClmEditar.Name = "ClmEditar";
            this.ClmEditar.ReadOnly = true;
            this.ClmEditar.Text = "Editar";
            this.ClmEditar.UseColumnTextForButtonValue = true;
            this.ClmEditar.Width = 80;
            // 
            // FormListPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 254);
            this.Controls.Add(this.brnCancelar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.dgvPagamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(673, 293);
            this.Name = "FormListPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Pagamentos";
            this.Load += new System.EventHandler(this.FormListPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagamento;
        private System.Windows.Forms.Button brnCancelar;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmIdPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTipoPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTaxas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmAtivo;
        private System.Windows.Forms.DataGridViewButtonColumn ClmEditar;
    }
}