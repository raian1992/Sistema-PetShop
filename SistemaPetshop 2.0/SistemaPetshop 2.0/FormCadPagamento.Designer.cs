
namespace SistemaPetshop_2._0
{
    partial class FormCadPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadPagamento));
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTipopag = new System.Windows.Forms.Label();
            this.lbltaxas = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.cbxpag = new System.Windows.Forms.ComboBox();
            this.cbxtaxas = new System.Windows.Forms.ComboBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.chkgerfin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(65, 42);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(38, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Nome:";
            // 
            // lblTipopag
            // 
            this.lblTipopag.AutoSize = true;
            this.lblTipopag.Location = new System.Drawing.Point(12, 77);
            this.lblTipopag.Name = "lblTipopag";
            this.lblTipopag.Size = new System.Drawing.Size(91, 13);
            this.lblTipopag.TabIndex = 1;
            this.lblTipopag.Text = "Tipo_Pagamento:";
            // 
            // lbltaxas
            // 
            this.lbltaxas.AutoSize = true;
            this.lbltaxas.Location = new System.Drawing.Point(64, 115);
            this.lbltaxas.Name = "lbltaxas";
            this.lbltaxas.Size = new System.Drawing.Size(39, 13);
            this.lbltaxas.TabIndex = 2;
            this.lbltaxas.Text = "Taxas:";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(316, 12);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 3;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(109, 39);
            this.txtnome.MaxLength = 40;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(257, 20);
            this.txtnome.TabIndex = 4;
            // 
            // cbxpag
            // 
            this.cbxpag.DisplayMember = "NOME_PAG";
            this.cbxpag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxpag.FormattingEnabled = true;
            this.cbxpag.Location = new System.Drawing.Point(109, 74);
            this.cbxpag.Name = "cbxpag";
            this.cbxpag.Size = new System.Drawing.Size(257, 21);
            this.cbxpag.TabIndex = 5;
            this.cbxpag.ValueMember = "ID_PAG";
            // 
            // cbxtaxas
            // 
            this.cbxtaxas.DisplayMember = "DESCRICAOTX";
            this.cbxtaxas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtaxas.FormattingEnabled = true;
            this.cbxtaxas.Location = new System.Drawing.Point(109, 112);
            this.cbxtaxas.Name = "cbxtaxas";
            this.cbxtaxas.Size = new System.Drawing.Size(257, 21);
            this.cbxtaxas.TabIndex = 6;
            this.cbxtaxas.ValueMember = "ID_TAXAS";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(109, 190);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 7;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(250, 190);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // chkgerfin
            // 
            this.chkgerfin.AutoSize = true;
            this.chkgerfin.Location = new System.Drawing.Point(109, 150);
            this.chkgerfin.Name = "chkgerfin";
            this.chkgerfin.Size = new System.Drawing.Size(101, 17);
            this.chkgerfin.TabIndex = 9;
            this.chkgerfin.Text = "Gera Financeiro";
            this.chkgerfin.UseVisualStyleBackColor = true;
            // 
            // FormCadPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 233);
            this.Controls.Add(this.chkgerfin);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.cbxtaxas);
            this.Controls.Add(this.cbxpag);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.lbltaxas);
            this.Controls.Add(this.lblTipopag);
            this.Controls.Add(this.lblDescricao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCadPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.FormCadPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTipopag;
        private System.Windows.Forms.Label lbltaxas;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.ComboBox cbxpag;
        private System.Windows.Forms.ComboBox cbxtaxas;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.CheckBox chkgerfin;
    }
}