namespace SistemaPetshop_2._0
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblversion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusuarioconectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atenidmentoVeterinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.petsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbldiaslib = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxempresa = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblversion,
            this.lblusuarioconectado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblversion
            // 
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(118, 17);
            this.lblversion.Text = "toolStripStatusLabel1";
            // 
            // lblusuarioconectado
            // 
            this.lblusuarioconectado.Name = "lblusuarioconectado";
            this.lblusuarioconectado.Size = new System.Drawing.Size(118, 17);
            this.lblusuarioconectado.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.comercialToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proprietariosToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // proprietariosToolStripMenuItem
            // 
            this.proprietariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proprietarioToolStripMenuItem,
            this.animalToolStripMenuItem});
            this.proprietariosToolStripMenuItem.Name = "proprietariosToolStripMenuItem";
            this.proprietariosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.proprietariosToolStripMenuItem.Text = "Proprietarios";
            // 
            // proprietarioToolStripMenuItem
            // 
            this.proprietarioToolStripMenuItem.Name = "proprietarioToolStripMenuItem";
            this.proprietarioToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.proprietarioToolStripMenuItem.Text = "Proprietario";
            this.proprietarioToolStripMenuItem.Click += new System.EventHandler(this.proprietarioToolStripMenuItem_Click);
            // 
            // animalToolStripMenuItem
            // 
            this.animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            this.animalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.animalToolStripMenuItem.Text = "Pet";
            this.animalToolStripMenuItem.Click += new System.EventHandler(this.animalToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.agendaToolStripMenuItem.Text = "Agenda de Compromissos";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosToolStripMenuItem,
            this.veterinariosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // veterinariosToolStripMenuItem
            // 
            this.veterinariosToolStripMenuItem.Name = "veterinariosToolStripMenuItem";
            this.veterinariosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.veterinariosToolStripMenuItem.Text = "Veterinarios";
            this.veterinariosToolStripMenuItem.Click += new System.EventHandler(this.veterinariosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // comercialToolStripMenuItem
            // 
            this.comercialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atenidmentoVeterinarioToolStripMenuItem});
            this.comercialToolStripMenuItem.Name = "comercialToolStripMenuItem";
            this.comercialToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.comercialToolStripMenuItem.Text = "Comercial";
            // 
            // atenidmentoVeterinarioToolStripMenuItem
            // 
            this.atenidmentoVeterinarioToolStripMenuItem.Name = "atenidmentoVeterinarioToolStripMenuItem";
            this.atenidmentoVeterinarioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.atenidmentoVeterinarioToolStripMenuItem.Text = "Atenidmento Veterinario";
            this.atenidmentoVeterinarioToolStripMenuItem.Click += new System.EventHandler(this.atenidmentoVeterinarioToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formasDePagamentoToolStripMenuItem,
            this.taxasToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "&Financeiro";
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            this.formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            this.formasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.formasDePagamentoToolStripMenuItem.Text = "Formas de Pagamento";
            this.formasDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formasDePagamentoToolStripMenuItem_Click);
            // 
            // taxasToolStripMenuItem
            // 
            this.taxasToolStripMenuItem.Name = "taxasToolStripMenuItem";
            this.taxasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.taxasToolStripMenuItem.Text = "Taxas";
            this.taxasToolStripMenuItem.Click += new System.EventHandler(this.taxasToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem1});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // cadastrosToolStripMenuItem1
            // 
            this.cadastrosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proprietarioToolStripMenuItem1,
            this.petsToolStripMenuItem});
            this.cadastrosToolStripMenuItem1.Name = "cadastrosToolStripMenuItem1";
            this.cadastrosToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.cadastrosToolStripMenuItem1.Text = "Cadastros";
            // 
            // proprietarioToolStripMenuItem1
            // 
            this.proprietarioToolStripMenuItem1.Name = "proprietarioToolStripMenuItem1";
            this.proprietarioToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.proprietarioToolStripMenuItem1.Text = "Proprietario";
            this.proprietarioToolStripMenuItem1.Click += new System.EventHandler(this.proprietarioToolStripMenuItem1_Click);
            // 
            // petsToolStripMenuItem
            // 
            this.petsToolStripMenuItem.Name = "petsToolStripMenuItem";
            this.petsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.petsToolStripMenuItem.Text = "Pet\'s";
            this.petsToolStripMenuItem.Click += new System.EventHandler(this.petsToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sobreToolStripMenuItem.Text = "A&juda";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // lbldiaslib
            // 
            this.lbldiaslib.AutoSize = true;
            this.lbldiaslib.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbldiaslib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiaslib.Location = new System.Drawing.Point(0, 649);
            this.lbldiaslib.Name = "lbldiaslib";
            this.lbldiaslib.Size = new System.Drawing.Size(51, 16);
            this.lbldiaslib.TabIndex = 3;
            this.lbldiaslib.Text = "label1";
            this.lbldiaslib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxempresa);
            this.groupBox1.Location = new System.Drawing.Point(614, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filial:";
            // 
            // cbxempresa
            // 
            this.cbxempresa.BackColor = System.Drawing.Color.White;
            this.cbxempresa.DisplayMember = "FANTASIA";
            this.cbxempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxempresa.FormattingEnabled = true;
            this.cbxempresa.Location = new System.Drawing.Point(44, 15);
            this.cbxempresa.Name = "cbxempresa";
            this.cbxempresa.Size = new System.Drawing.Size(250, 21);
            this.cbxempresa.TabIndex = 0;
            this.cbxempresa.ValueMember = "ID_EMPRESA";
            this.cbxempresa.SelectedIndexChanged += new System.EventHandler(this.cbxempresa_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SistemaPetshop_2._0.Properties.Resources.imagem_cachorro_com_estetoscopio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1031, 641);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldiaslib);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblversion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbldiaslib;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxempresa;
        private System.Windows.Forms.ToolStripStatusLabel lblusuarioconectado;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atenidmentoVeterinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proprietarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem petsToolStripMenuItem;
    }
}