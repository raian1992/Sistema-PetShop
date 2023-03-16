using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
{
    public partial class FormcadProp : Form
    {
        public FormcadProp()
        {
            InitializeComponent();
        }
        public int codigo = 0;

        private void FormcadProp_Load(object sender, EventArgs e)
        {
            cadprop.codigo = codigo;
            cadprop.form = "FormcadProp";
            cadprop.carregar_dados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cadprop.btnSalvar_Click();
            this.Close();
        }
    }
}
