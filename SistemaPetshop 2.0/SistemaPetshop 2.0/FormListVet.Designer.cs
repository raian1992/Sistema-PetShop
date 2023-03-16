namespace SistemaPetshop_2._0
{
    partial class FormListVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListVet));
            this.dgvlistvet = new System.Windows.Forms.DataGridView();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_VET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRMV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btneditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistvet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistvet
            // 
            this.dgvlistvet.AllowUserToAddRows = false;
            this.dgvlistvet.AllowUserToDeleteRows = false;
            this.dgvlistvet.AllowUserToResizeColumns = false;
            this.dgvlistvet.AllowUserToResizeRows = false;
            this.dgvlistvet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvlistvet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME_VET,
            this.CRMV,
            this.chkativo,
            this.btneditar});
            this.dgvlistvet.Location = new System.Drawing.Point(12, 12);
            this.dgvlistvet.MultiSelect = false;
            this.dgvlistvet.Name = "dgvlistvet";
            this.dgvlistvet.ReadOnly = true;
            this.dgvlistvet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvlistvet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvlistvet.ShowRowErrors = false;
            this.dgvlistvet.Size = new System.Drawing.Size(766, 201);
            this.dgvlistvet.TabIndex = 4;
            this.dgvlistvet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistvet_CellContentClick);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(416, 226);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(98, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(233, 226);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(98, 23);
            this.btnadicionar.TabIndex = 8;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "ID_VET";
            this.CODIGO.Frozen = true;
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 60;
            // 
            // NOME_VET
            // 
            this.NOME_VET.DataPropertyName = "NOME_VET";
            this.NOME_VET.Frozen = true;
            this.NOME_VET.HeaderText = "VETERINARIOS(AS)";
            this.NOME_VET.Name = "NOME_VET";
            this.NOME_VET.ReadOnly = true;
            this.NOME_VET.Width = 380;
            // 
            // CRMV
            // 
            this.CRMV.DataPropertyName = "CRMV";
            this.CRMV.Frozen = true;
            this.CRMV.HeaderText = "CRMV";
            this.CRMV.Name = "CRMV";
            this.CRMV.ReadOnly = true;
            // 
            // chkativo
            // 
            this.chkativo.DataPropertyName = "ATIVO";
            this.chkativo.Frozen = true;
            this.chkativo.HeaderText = "Ativo";
            this.chkativo.Name = "chkativo";
            this.chkativo.ReadOnly = true;
            this.chkativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btneditar
            // 
            this.btneditar.Frozen = true;
            this.btneditar.HeaderText = "Editar";
            this.btneditar.Name = "btneditar";
            this.btneditar.ReadOnly = true;
            this.btneditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneditar.Text = "Editar";
            this.btneditar.UseColumnTextForButtonValue = true;
            this.btneditar.Width = 80;
            // 
            // FormListVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.dgvlistvet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(753, 300);
            this.Name = "FormListVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Veterinarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListVet_FormClosing);
            this.Load += new System.EventHandler(this.FormListVet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistvet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvlistvet;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_VET;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRMV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkativo;
        private System.Windows.Forms.DataGridViewButtonColumn btneditar;
    }
}