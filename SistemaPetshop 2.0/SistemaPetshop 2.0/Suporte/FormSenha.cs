using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0.Suporte
{
    public partial class FormSenha : Form
    {
        public FormSenha()
        {
            InitializeComponent();
        }
        public bool liberado = false;
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (txtsenha.Text == "090184")
            {
                liberado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("A senha informada esta incorreta.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtsenha.Text = "";
                txtsenha.Focus();
            }
        }

        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                btnConfirma.Focus();

            }
        }
    }
}
