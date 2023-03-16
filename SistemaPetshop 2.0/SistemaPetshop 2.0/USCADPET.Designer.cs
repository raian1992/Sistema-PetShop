
namespace SistemaPetshop_2._0
{
    partial class USCADPET
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtracapet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.dtpnascimento = new System.Windows.Forms.DateTimePicker();
            this.lbldatanasc = new System.Windows.Forms.Label();
            this.cbxtipopet = new System.Windows.Forms.ComboBox();
            this.lbltipopet = new System.Windows.Forms.Label();
            this.cbxsexopet = new System.Windows.Forms.ComboBox();
            this.lblsexopet = new System.Windows.Forms.Label();
            this.txtnomepet = new System.Windows.Forms.TextBox();
            this.lblnomepet = new System.Windows.Forms.Label();
            this.grbcliente = new System.Windows.Forms.GroupBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnbusca = new System.Windows.Forms.Button();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.lblcampo = new System.Windows.Forms.Label();
            this.grbcliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtracapet
            // 
            this.txtracapet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtracapet.Location = new System.Drawing.Point(135, 138);
            this.txtracapet.Name = "txtracapet";
            this.txtracapet.Size = new System.Drawing.Size(367, 20);
            this.txtracapet.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Raça:";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(518, 98);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 37;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtidade
            // 
            this.txtidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtidade.Location = new System.Drawing.Point(381, 220);
            this.txtidade.MaxLength = 20;
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(121, 20);
            this.txtidade.TabIndex = 30;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(295, 223);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(43, 13);
            this.lblIdade.TabIndex = 36;
            this.lblIdade.Text = "IDADE:";
            // 
            // dtpnascimento
            // 
            this.dtpnascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnascimento.Location = new System.Drawing.Point(135, 217);
            this.dtpnascimento.Name = "dtpnascimento";
            this.dtpnascimento.Size = new System.Drawing.Size(107, 20);
            this.dtpnascimento.TabIndex = 29;
            // 
            // lbldatanasc
            // 
            this.lbldatanasc.AutoSize = true;
            this.lbldatanasc.Location = new System.Drawing.Point(9, 223);
            this.lbldatanasc.Name = "lbldatanasc";
            this.lbldatanasc.Size = new System.Drawing.Size(107, 13);
            this.lbldatanasc.TabIndex = 35;
            this.lbldatanasc.Text = "Data de Nascimento:";
            // 
            // cbxtipopet
            // 
            this.cbxtipopet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipopet.FormattingEnabled = true;
            this.cbxtipopet.ItemHeight = 13;
            this.cbxtipopet.Items.AddRange(new object[] {
            "CACHORRO",
            "GATO"});
            this.cbxtipopet.Location = new System.Drawing.Point(135, 173);
            this.cbxtipopet.MaxDropDownItems = 3;
            this.cbxtipopet.Name = "cbxtipopet";
            this.cbxtipopet.Size = new System.Drawing.Size(107, 21);
            this.cbxtipopet.TabIndex = 27;
            // 
            // lbltipopet
            // 
            this.lbltipopet.AutoSize = true;
            this.lbltipopet.Location = new System.Drawing.Point(52, 173);
            this.lbltipopet.Name = "lbltipopet";
            this.lbltipopet.Size = new System.Drawing.Size(48, 13);
            this.lbltipopet.TabIndex = 34;
            this.lbltipopet.Text = "Especie:";
            // 
            // cbxsexopet
            // 
            this.cbxsexopet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsexopet.FormattingEnabled = true;
            this.cbxsexopet.ItemHeight = 13;
            this.cbxsexopet.Items.AddRange(new object[] {
            "FEMEA",
            "MACHO"});
            this.cbxsexopet.Location = new System.Drawing.Point(381, 170);
            this.cbxsexopet.MaxDropDownItems = 4;
            this.cbxsexopet.Name = "cbxsexopet";
            this.cbxsexopet.Size = new System.Drawing.Size(121, 21);
            this.cbxsexopet.TabIndex = 28;
            // 
            // lblsexopet
            // 
            this.lblsexopet.AutoSize = true;
            this.lblsexopet.Location = new System.Drawing.Point(304, 176);
            this.lblsexopet.Name = "lblsexopet";
            this.lblsexopet.Size = new System.Drawing.Size(34, 13);
            this.lblsexopet.TabIndex = 33;
            this.lblsexopet.Text = "Sexo:";
            // 
            // txtnomepet
            // 
            this.txtnomepet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomepet.Location = new System.Drawing.Point(135, 99);
            this.txtnomepet.MaxLength = 40;
            this.txtnomepet.Name = "txtnomepet";
            this.txtnomepet.Size = new System.Drawing.Size(367, 20);
            this.txtnomepet.TabIndex = 25;
            // 
            // lblnomepet
            // 
            this.lblnomepet.AutoSize = true;
            this.lblnomepet.Location = new System.Drawing.Point(28, 99);
            this.lblnomepet.Name = "lblnomepet";
            this.lblnomepet.Size = new System.Drawing.Size(72, 13);
            this.lblnomepet.TabIndex = 32;
            this.lblnomepet.Text = "Nome do Pet:";
            // 
            // grbcliente
            // 
            this.grbcliente.Controls.Add(this.lblcodigo);
            this.grbcliente.Controls.Add(this.btnbusca);
            this.grbcliente.Controls.Add(this.txtbusca);
            this.grbcliente.Controls.Add(this.lblcampo);
            this.grbcliente.Location = new System.Drawing.Point(16, 16);
            this.grbcliente.Name = "grbcliente";
            this.grbcliente.Size = new System.Drawing.Size(613, 52);
            this.grbcliente.TabIndex = 31;
            this.grbcliente.TabStop = false;
            this.grbcliente.Text = "Buscar Proprietario:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(90, 19);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(10, 13);
            this.lblcodigo.TabIndex = 4;
            this.lblcodigo.Text = ".";
            // 
            // btnbusca
            // 
            this.btnbusca.Location = new System.Drawing.Point(502, 16);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(75, 23);
            this.btnbusca.TabIndex = 0;
            this.btnbusca.Text = "Buscar";
            this.btnbusca.UseVisualStyleBackColor = true;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
            // 
            // txtbusca
            // 
            this.txtbusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbusca.Enabled = false;
            this.txtbusca.Location = new System.Drawing.Point(119, 16);
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
            this.lblcampo.Size = new System.Drawing.Size(63, 13);
            this.lblcampo.TabIndex = 1;
            this.lblcampo.Text = "Proprietario:";
            // 
            // USCADPET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtracapet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.dtpnascimento);
            this.Controls.Add(this.lbldatanasc);
            this.Controls.Add(this.cbxtipopet);
            this.Controls.Add(this.lbltipopet);
            this.Controls.Add(this.cbxsexopet);
            this.Controls.Add(this.lblsexopet);
            this.Controls.Add(this.txtnomepet);
            this.Controls.Add(this.lblnomepet);
            this.Controls.Add(this.grbcliente);
            this.Name = "USCADPET";
            this.Size = new System.Drawing.Size(638, 255);
            this.grbcliente.ResumeLayout(false);
            this.grbcliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtracapet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.DateTimePicker dtpnascimento;
        private System.Windows.Forms.Label lbldatanasc;
        private System.Windows.Forms.ComboBox cbxtipopet;
        private System.Windows.Forms.Label lbltipopet;
        private System.Windows.Forms.ComboBox cbxsexopet;
        private System.Windows.Forms.Label lblsexopet;
        private System.Windows.Forms.TextBox txtnomepet;
        private System.Windows.Forms.Label lblnomepet;
        private System.Windows.Forms.GroupBox grbcliente;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnbusca;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Label lblcampo;
    }
}
