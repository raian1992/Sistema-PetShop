
namespace SistemaPetshop_2._0.Relatorios
{
    partial class FormREL_PROP
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Report1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Rel_cad_prop1 = new SistemaPetshop_2._0.Relatorios.Rel_cad_prop();
            this.SuspendLayout();
            // 
            // Report1
            // 
            this.Report1.ActiveViewIndex = 0;
            this.Report1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Report1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Report1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report1.Location = new System.Drawing.Point(0, 0);
            this.Report1.Name = "Report1";
            this.Report1.ReportSource = this.Rel_cad_prop1;
            this.Report1.Size = new System.Drawing.Size(800, 450);
            this.Report1.TabIndex = 0;
            // 
            // FormREL_PROP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Report1);
            this.Name = "FormREL_PROP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Proprietarios";
            this.Load += new System.EventHandler(this.FormREL_PROP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Report1;
        private Rel_cad_prop Rel_cad_prop1;
    }
}