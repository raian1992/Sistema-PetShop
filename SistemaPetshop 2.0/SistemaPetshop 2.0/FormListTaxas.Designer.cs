
namespace SistemaPetshop_2._0
{
    partial class FormListTaxas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListTaxas));
            this.dgvTaxas = new System.Windows.Forms.DataGridView();
            this.ClmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmP_DIVIDIR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClmAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.brnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaxas
            // 
            this.dgvTaxas.AllowUserToAddRows = false;
            this.dgvTaxas.AllowUserToDeleteRows = false;
            this.dgvTaxas.AllowUserToResizeColumns = false;
            this.dgvTaxas.AllowUserToResizeRows = false;
            this.dgvTaxas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaxas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCodigo,
            this.Descricao,
            this.ClmP_DIVIDIR,
            this.ClmAtivo,
            this.BtnEditar});
            this.dgvTaxas.Location = new System.Drawing.Point(5, 4);
            this.dgvTaxas.Name = "dgvTaxas";
            this.dgvTaxas.ReadOnly = true;
            this.dgvTaxas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTaxas.Size = new System.Drawing.Size(601, 177);
            this.dgvTaxas.TabIndex = 0;
            this.dgvTaxas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaxas_CellContentClick);
            // 
            // ClmCodigo
            // 
            this.ClmCodigo.DataPropertyName = "ID_TAXAS";
            this.ClmCodigo.Frozen = true;
            this.ClmCodigo.HeaderText = "Codigo";
            this.ClmCodigo.Name = "ClmCodigo";
            this.ClmCodigo.ReadOnly = true;
            this.ClmCodigo.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "DESCRICAOTX";
            this.Descricao.Frozen = true;
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 180;
            // 
            // ClmP_DIVIDIR
            // 
            this.ClmP_DIVIDIR.DataPropertyName = "P_DIV";
            this.ClmP_DIVIDIR.Frozen = true;
            this.ClmP_DIVIDIR.HeaderText = "Permite Dividir ?";
            this.ClmP_DIVIDIR.Name = "ClmP_DIVIDIR";
            this.ClmP_DIVIDIR.ReadOnly = true;
            // 
            // ClmAtivo
            // 
            this.ClmAtivo.DataPropertyName = "ATIVO";
            this.ClmAtivo.Frozen = true;
            this.ClmAtivo.HeaderText = "Ativo";
            this.ClmAtivo.Name = "ClmAtivo";
            this.ClmAtivo.ReadOnly = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Frozen = true;
            this.BtnEditar.HeaderText = "Editar";
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.ReadOnly = true;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(160, 199);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 1;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // brnCancelar
            // 
            this.brnCancelar.Location = new System.Drawing.Point(362, 199);
            this.brnCancelar.Name = "brnCancelar";
            this.brnCancelar.Size = new System.Drawing.Size(75, 23);
            this.brnCancelar.TabIndex = 2;
            this.brnCancelar.Text = "Cancelar";
            this.brnCancelar.UseVisualStyleBackColor = true;
            this.brnCancelar.Click += new System.EventHandler(this.brnCancelar_Click);
            // 
            // FormListTaxas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 234);
            this.Controls.Add(this.brnCancelar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.dgvTaxas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(627, 273);
            this.Name = "FormListTaxas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Taxas";
            this.Load += new System.EventHandler(this.FormListTaxas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaxas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaxas;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button brnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmP_DIVIDIR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmAtivo;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
    }
}