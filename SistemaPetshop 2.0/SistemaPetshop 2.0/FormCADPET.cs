using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
{
    public partial class FormCADPET : Form
    {
        public FormCADPET()
        {
            InitializeComponent();
        }
        public int codigo = 0;
        public int codigo_cliente = 0;

       

        private void FormCADPET_Load(object sender, EventArgs e)
        {
            cadpet.codigo = codigo;
            cadpet.codigo_cliente = codigo_cliente;
            cadpet.carregar_informacoes();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cadpet.salvardados();
            MessageBox.Show("PET Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
