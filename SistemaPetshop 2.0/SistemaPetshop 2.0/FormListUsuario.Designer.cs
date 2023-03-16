
namespace SistemaPetshop_2._0
{
    partial class FormListUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListUsuario));
            this.dgvlistusuario = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.Codgio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistusuario
            // 
            this.dgvlistusuario.AllowUserToAddRows = false;
            this.dgvlistusuario.AllowUserToDeleteRows = false;
            this.dgvlistusuario.AllowUserToResizeColumns = false;
            this.dgvlistusuario.AllowUserToResizeRows = false;
            this.dgvlistusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvlistusuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codgio,
            this.Descrição,
            this.Login,
            this.Email,
            this.ClmAtivo,
            this.BtnEditar});
            this.dgvlistusuario.Location = new System.Drawing.Point(0, 0);
            this.dgvlistusuario.Name = "dgvlistusuario";
            this.dgvlistusuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvlistusuario.Size = new System.Drawing.Size(642, 244);
            this.dgvlistusuario.TabIndex = 0;
            this.dgvlistusuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistusuario_CellContentClick);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(417, 255);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncluir.Location = new System.Drawing.Point(160, 255);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 12;
            this.btnIncluir.Text = "Adicionar";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // Codgio
            // 
            this.Codgio.DataPropertyName = "id_usuario";
            this.Codgio.Frozen = true;
            this.Codgio.HeaderText = "Codigo";
            this.Codgio.Name = "Codgio";
            this.Codgio.ReadOnly = true;
            this.Codgio.Width = 70;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "NOME";
            this.Descrição.Frozen = true;
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 130;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "LOGIN";
            this.Login.Frozen = true;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.Frozen = true;
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 120;
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
            this.BtnEditar.Width = 80;
            // 
            // FormListUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 290);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvlistusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListUsuario";
            this.Text = "Listagem de Usuario";
            this.Load += new System.EventHandler(this.FormListUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistusuario;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codgio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmAtivo;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
    }
}