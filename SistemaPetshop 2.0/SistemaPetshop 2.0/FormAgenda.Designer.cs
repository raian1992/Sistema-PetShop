
namespace SistemaPetshop_2._0
{
    partial class FormAgenda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            this.btnconcluir = new System.Windows.Forms.Button();
            this.bneditarcompromisso = new System.Windows.Forms.Button();
            this.NovoCompromisso = new System.Windows.Forms.Button();
            this.CompromissosDoDia = new System.Windows.Forms.ListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHORA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDESCRICAO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnconcluir
            // 
            this.btnconcluir.Location = new System.Drawing.Point(46, 220);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(178, 23);
            this.btnconcluir.TabIndex = 12;
            this.btnconcluir.Text = "Concluir compromisso";
            this.btnconcluir.UseVisualStyleBackColor = true;
            this.btnconcluir.Click += new System.EventHandler(this.btnconcluir_Click);
            // 
            // bneditarcompromisso
            // 
            this.bneditarcompromisso.Location = new System.Drawing.Point(46, 249);
            this.bneditarcompromisso.Name = "bneditarcompromisso";
            this.bneditarcompromisso.Size = new System.Drawing.Size(178, 23);
            this.bneditarcompromisso.TabIndex = 11;
            this.bneditarcompromisso.Text = "Editar compromisso";
            this.bneditarcompromisso.UseVisualStyleBackColor = true;
            this.bneditarcompromisso.Click += new System.EventHandler(this.bneditarcompromisso_Click);
            // 
            // NovoCompromisso
            // 
            this.NovoCompromisso.Location = new System.Drawing.Point(46, 278);
            this.NovoCompromisso.Name = "NovoCompromisso";
            this.NovoCompromisso.Size = new System.Drawing.Size(178, 23);
            this.NovoCompromisso.TabIndex = 10;
            this.NovoCompromisso.Text = "Novo compromisso";
            this.NovoCompromisso.UseVisualStyleBackColor = true;
            this.NovoCompromisso.Click += new System.EventHandler(this.NovoCompromisso_Click);
            // 
            // CompromissosDoDia
            // 
            this.CompromissosDoDia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmHORA,
            this.clmDESCRICAO});
            this.CompromissosDoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompromissosDoDia.FullRowSelect = true;
            this.CompromissosDoDia.GridLines = true;
            this.CompromissosDoDia.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CompromissosDoDia.Location = new System.Drawing.Point(267, 18);
            this.CompromissosDoDia.Name = "CompromissosDoDia";
            this.CompromissosDoDia.Size = new System.Drawing.Size(400, 400);
            this.CompromissosDoDia.TabIndex = 9;
            this.CompromissosDoDia.UseCompatibleStateImageBehavior = false;
            this.CompromissosDoDia.View = System.Windows.Forms.View.Details;
            // 
            // clmID
            // 
            this.clmID.Text = "Id";
            this.clmID.Width = 50;
            // 
            // clmHORA
            // 
            this.clmHORA.Text = "Hora";
            this.clmHORA.Width = 80;
            // 
            // clmDESCRICAO
            // 
            this.clmDESCRICAO.Text = "Descrição";
            this.clmDESCRICAO.Width = 260;
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(30, 18);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 8;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // relogio
            // 
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.bneditarcompromisso);
            this.Controls.Add(this.NovoCompromisso);
            this.Controls.Add(this.CompromissosDoDia);
            this.Controls.Add(this.Calendario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Compromissos";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.Button bneditarcompromisso;
        private System.Windows.Forms.Button NovoCompromisso;
        private System.Windows.Forms.ListView CompromissosDoDia;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmHORA;
        private System.Windows.Forms.ColumnHeader clmDESCRICAO;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Timer relogio;
    }
}