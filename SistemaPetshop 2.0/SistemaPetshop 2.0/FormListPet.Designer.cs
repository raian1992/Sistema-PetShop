namespace SistemaPetshop_2._0
{
    partial class FormListPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPet));
            this.grbcliente = new System.Windows.Forms.GroupBox();
            this.btnbusca = new System.Windows.Forms.Button();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.lblcampo = new System.Windows.Forms.Label();
            this.cbxcampobusca = new System.Windows.Forms.ComboBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClmAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ESPECIE_PET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROPRIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVLISTPET = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.grbcliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLISTPET)).BeginInit();
            this.SuspendLayout();
            // 
            // grbcliente
            // 
            this.grbcliente.Controls.Add(this.btnbusca);
            this.grbcliente.Controls.Add(this.txtbusca);
            this.grbcliente.Controls.Add(this.lblcampo);
            this.grbcliente.Controls.Add(this.cbxcampobusca);
            this.grbcliente.Location = new System.Drawing.Point(25, 12);
            this.grbcliente.Name = "grbcliente";
            this.grbcliente.Size = new System.Drawing.Size(740, 43);
            this.grbcliente.TabIndex = 8;
            this.grbcliente.TabStop = false;
            this.grbcliente.Text = "Buscar Pets:";
            // 
            // btnbusca
            // 
            this.btnbusca.Location = new System.Drawing.Point(640, 12);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(75, 23);
            this.btnbusca.TabIndex = 3;
            this.btnbusca.Text = "Buscar";
            this.btnbusca.UseVisualStyleBackColor = true;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
            // 
            // txtbusca
            // 
            this.txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbusca.Location = new System.Drawing.Point(248, 15);
            this.txtbusca.MaxLength = 40;
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(367, 20);
            this.txtbusca.TabIndex = 2;
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(8, 19);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(76, 13);
            this.lblcampo.TabIndex = 1;
            this.lblcampo.Text = "Campo Busca:";
            // 
            // cbxcampobusca
            // 
            this.cbxcampobusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcampobusca.FormattingEnabled = true;
            this.cbxcampobusca.Items.AddRange(new object[] {
            "NOME_PET",
            "NOME_PROPRIETARIO",
            "ESPECIE"});
            this.cbxcampobusca.Location = new System.Drawing.Point(94, 14);
            this.cbxcampobusca.Name = "cbxcampobusca";
            this.cbxcampobusca.Size = new System.Drawing.Size(121, 21);
            this.cbxcampobusca.TabIndex = 0;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncluir.Location = new System.Drawing.Point(195, 405);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 10;
            this.btnIncluir.Text = "Adicionar";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Frozen = true;
            this.BtnEditar.HeaderText = "Editar";
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.ReadOnly = true;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseColumnTextForButtonValue = true;
            this.BtnEditar.Width = 80;
            // 
            // ClmAtivo
            // 
            this.ClmAtivo.DataPropertyName = "ATIVO";
            this.ClmAtivo.Frozen = true;
            this.ClmAtivo.HeaderText = "SITUAÇÃO PET";
            this.ClmAtivo.Name = "ClmAtivo";
            this.ClmAtivo.ReadOnly = true;
            this.ClmAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmAtivo.Width = 120;
            // 
            // ESPECIE_PET
            // 
            this.ESPECIE_PET.DataPropertyName = "ESPECIE_PET";
            this.ESPECIE_PET.Frozen = true;
            this.ESPECIE_PET.HeaderText = "ESPECIE PET";
            this.ESPECIE_PET.Name = "ESPECIE_PET";
            this.ESPECIE_PET.ReadOnly = true;
            // 
            // PROPRIETARIO
            // 
            this.PROPRIETARIO.DataPropertyName = "NOME_PROPRIETARIO";
            this.PROPRIETARIO.Frozen = true;
            this.PROPRIETARIO.HeaderText = "PROPRIETARIO";
            this.PROPRIETARIO.Name = "PROPRIETARIO";
            this.PROPRIETARIO.ReadOnly = true;
            this.PROPRIETARIO.Width = 200;
            // 
            // NOME_PET
            // 
            this.NOME_PET.DataPropertyName = "NOME_PET";
            this.NOME_PET.Frozen = true;
            this.NOME_PET.HeaderText = "NOME PET";
            this.NOME_PET.Name = "NOME_PET";
            this.NOME_PET.ReadOnly = true;
            this.NOME_PET.Width = 150;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "ID_PET";
            this.CODIGO.Frozen = true;
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // DGVLISTPET
            // 
            this.DGVLISTPET.AllowUserToAddRows = false;
            this.DGVLISTPET.AllowUserToDeleteRows = false;
            this.DGVLISTPET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLISTPET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME_PET,
            this.PROPRIETARIO,
            this.ESPECIE_PET,
            this.ClmAtivo,
            this.BtnEditar});
            this.DGVLISTPET.Location = new System.Drawing.Point(7, 64);
            this.DGVLISTPET.Name = "DGVLISTPET";
            this.DGVLISTPET.ReadOnly = true;
            this.DGVLISTPET.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVLISTPET.Size = new System.Drawing.Size(787, 322);
            this.DGVLISTPET.TabIndex = 9;
            this.DGVLISTPET.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLISTPET_CellContentClick);
            this.DGVLISTPET.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLISTPET_CellDoubleClick);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(491, 405);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FormListPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.DGVLISTPET);
            this.Controls.Add(this.grbcliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormListPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem dos Pets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListPet_FormClosing);
            this.Load += new System.EventHandler(this.FormListPet_Load);
            this.grbcliente.ResumeLayout(false);
            this.grbcliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLISTPET)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbcliente;
        private System.Windows.Forms.Button btnbusca;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.ComboBox cbxcampobusca;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESPECIE_PET;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROPRIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PET;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridView DGVLISTPET;
        private System.Windows.Forms.Button BtnCancelar;
    }
}