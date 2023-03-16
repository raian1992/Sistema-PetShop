namespace SistemaPetshop_2._0
{
    partial class FormListServico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListServico));
            this.dgvlistservico = new System.Windows.Forms.DataGridView();
            this.ClmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistservico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistservico
            // 
            this.dgvlistservico.AllowUserToAddRows = false;
            this.dgvlistservico.AllowUserToDeleteRows = false;
            this.dgvlistservico.AllowUserToResizeColumns = false;
            this.dgvlistservico.AllowUserToResizeRows = false;
            this.dgvlistservico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistservico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCodigo,
            this.ClmDescricao,
            this.ClmValor,
            this.ClmAtivo,
            this.btnEditar});
            this.dgvlistservico.Location = new System.Drawing.Point(7, 4);
            this.dgvlistservico.Name = "dgvlistservico";
            this.dgvlistservico.ReadOnly = true;
            this.dgvlistservico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvlistservico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvlistservico.Size = new System.Drawing.Size(662, 155);
            this.dgvlistservico.TabIndex = 0;
            this.dgvlistservico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistservico_CellContentClick);
            // 
            // ClmCodigo
            // 
            this.ClmCodigo.DataPropertyName = "ID_SERVICO";
            this.ClmCodigo.Frozen = true;
            this.ClmCodigo.HeaderText = "Codigo";
            this.ClmCodigo.Name = "ClmCodigo";
            this.ClmCodigo.ReadOnly = true;
            // 
            // ClmDescricao
            // 
            this.ClmDescricao.DataPropertyName = "Nome_Servico";
            this.ClmDescricao.Frozen = true;
            this.ClmDescricao.HeaderText = "Descrição do Servico";
            this.ClmDescricao.Name = "ClmDescricao";
            this.ClmDescricao.ReadOnly = true;
            this.ClmDescricao.Width = 200;
            // 
            // ClmValor
            // 
            this.ClmValor.DataPropertyName = "Valor_Servico";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.ClmValor.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClmValor.Frozen = true;
            this.ClmValor.HeaderText = "Valor do Serviço";
            this.ClmValor.Name = "ClmValor";
            this.ClmValor.ReadOnly = true;
            this.ClmValor.Width = 120;
            // 
            // ClmAtivo
            // 
            this.ClmAtivo.DataPropertyName = "Ativo";
            this.ClmAtivo.Frozen = true;
            this.ClmAtivo.HeaderText = "ATIVO";
            this.ClmAtivo.Name = "ClmAtivo";
            this.ClmAtivo.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Frozen = true;
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(223, 179);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(379, 179);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // FormListServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 214);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvlistservico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Serviço";
            this.Load += new System.EventHandler(this.FormListServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistservico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistservico;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmValor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmAtivo;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
    }
}