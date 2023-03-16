
namespace SistemaPetshop_2._0
{
    partial class FormCompromissos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompromissos));
            this.ckbconcluido = new System.Windows.Forms.CheckBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxusuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ckbconcluido
            // 
            this.ckbconcluido.AutoSize = true;
            this.ckbconcluido.Location = new System.Drawing.Point(331, 11);
            this.ckbconcluido.Name = "ckbconcluido";
            this.ckbconcluido.Size = new System.Drawing.Size(79, 17);
            this.ckbconcluido.TabIndex = 22;
            this.ckbconcluido.Text = "Concluido?";
            this.ckbconcluido.UseVisualStyleBackColor = true;
            this.ckbconcluido.Visible = false;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(134, 27);
            this.txtHora.Mask = "90:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(34, 20);
            this.txtHora.TabIndex = 16;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(229, 140);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(337, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(15, 62);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(400, 20);
            this.txtDescricao.TabIndex = 17;
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(12, 27);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vincular a um Usuario:";
            // 
            // cbxusuario
            // 
            this.cbxusuario.DisplayMember = "NOME";
            this.cbxusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxusuario.FormattingEnabled = true;
            this.cbxusuario.Items.AddRange(new object[] {
            "NENHUM"});
            this.cbxusuario.Location = new System.Drawing.Point(126, 103);
            this.cbxusuario.Name = "cbxusuario";
            this.cbxusuario.Size = new System.Drawing.Size(286, 21);
            this.cbxusuario.TabIndex = 24;
            this.cbxusuario.ValueMember = "ID_USUARIO";
            // 
            // FormCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 178);
            this.Controls.Add(this.cbxusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckbconcluido);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCompromissos";
            this.Text = "Compromissos";
            this.Load += new System.EventHandler(this.FormCompromissos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbconcluido;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxusuario;
    }
}