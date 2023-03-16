namespace SistemaPetshop_2._0
{
    partial class FormListProprietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListProprietario));
            this.DGVLISTPROPRI = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.grbcliente = new System.Windows.Forms.GroupBox();
            this.btnbusca = new System.Windows.Forms.Button();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.lblcampo = new System.Windows.Forms.Label();
            this.cbxcampobusca = new System.Windows.Forms.ComboBox();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHKATIVO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BTNEDITAR = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLISTPROPRI)).BeginInit();
            this.grbcliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVLISTPROPRI
            // 
            this.DGVLISTPROPRI.AllowUserToAddRows = false;
            this.DGVLISTPROPRI.AllowUserToDeleteRows = false;
            this.DGVLISTPROPRI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLISTPROPRI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD,
            this.DESCRICAO,
            this.Column1,
            this.TELEFONE,
            this.CELULAR,
            this.CIDADE,
            this.ESTADO,
            this.CHKATIVO,
            this.BTNEDITAR});
            this.DGVLISTPROPRI.Location = new System.Drawing.Point(12, 53);
            this.DGVLISTPROPRI.Name = "DGVLISTPROPRI";
            this.DGVLISTPROPRI.ReadOnly = true;
            this.DGVLISTPROPRI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVLISTPROPRI.Size = new System.Drawing.Size(972, 551);
            this.DGVLISTPROPRI.TabIndex = 0;
            this.DGVLISTPROPRI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLISTPROPRI_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(611, 628);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncluir.Location = new System.Drawing.Point(301, 628);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Adicionar";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // grbcliente
            // 
            this.grbcliente.Controls.Add(this.btnbusca);
            this.grbcliente.Controls.Add(this.txtbusca);
            this.grbcliente.Controls.Add(this.lblcampo);
            this.grbcliente.Controls.Add(this.cbxcampobusca);
            this.grbcliente.Location = new System.Drawing.Point(12, 4);
            this.grbcliente.Name = "grbcliente";
            this.grbcliente.Size = new System.Drawing.Size(740, 43);
            this.grbcliente.TabIndex = 7;
            this.grbcliente.TabStop = false;
            this.grbcliente.Text = "Buscar Proprietario:";
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
            "NOME",
            "TELEFONE",
            "CELULAR",
            "NOME DO PET"});
            this.cbxcampobusca.Location = new System.Drawing.Point(94, 14);
            this.cbxcampobusca.Name = "cbxcampobusca";
            this.cbxcampobusca.Size = new System.Drawing.Size(121, 21);
            this.cbxcampobusca.TabIndex = 0;
            // 
            // COD
            // 
            this.COD.DataPropertyName = "ID_PROPRIETARIO";
            this.COD.Frozen = true;
            this.COD.HeaderText = "CODIGO";
            this.COD.Name = "COD";
            this.COD.ReadOnly = true;
            this.COD.Visible = false;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "NOME_PROPRIETARIO";
            this.DESCRICAO.Frozen = true;
            this.DESCRICAO.HeaderText = "DESCRICAO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 300;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "FIXO";
            this.TELEFONE.Frozen = true;
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            // 
            // CELULAR
            // 
            this.CELULAR.DataPropertyName = "CELULAR";
            this.CELULAR.Frozen = true;
            this.CELULAR.HeaderText = "CELULAR";
            this.CELULAR.Name = "CELULAR";
            this.CELULAR.ReadOnly = true;
            // 
            // CIDADE
            // 
            this.CIDADE.DataPropertyName = "CIDADE";
            this.CIDADE.Frozen = true;
            this.CIDADE.HeaderText = "CIDADE";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.Frozen = true;
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // CHKATIVO
            // 
            this.CHKATIVO.DataPropertyName = "ATIVO";
            this.CHKATIVO.Frozen = true;
            this.CHKATIVO.HeaderText = "ATIVO";
            this.CHKATIVO.Name = "CHKATIVO";
            this.CHKATIVO.ReadOnly = true;
            this.CHKATIVO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHKATIVO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BTNEDITAR
            // 
            this.BTNEDITAR.Frozen = true;
            this.BTNEDITAR.HeaderText = "EDITAR";
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.ReadOnly = true;
            this.BTNEDITAR.Text = "EDITAR";
            this.BTNEDITAR.UseColumnTextForButtonValue = true;
            // 
            // FormListProprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.grbcliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.DGVLISTPROPRI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 726);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormListProprietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Proprietarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListProprietario_FormClosing);
            this.Load += new System.EventHandler(this.FormListProprietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLISTPROPRI)).EndInit();
            this.grbcliente.ResumeLayout(false);
            this.grbcliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVLISTPROPRI;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox grbcliente;
        private System.Windows.Forms.Button btnbusca;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.ComboBox cbxcampobusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHKATIVO;
        private System.Windows.Forms.DataGridViewButtonColumn BTNEDITAR;
    }
}