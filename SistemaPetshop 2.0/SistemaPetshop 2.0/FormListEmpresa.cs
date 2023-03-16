using SistemaPetshop_2._0.Adicionais;
using SistemaPetshop_2._0.ClasseConsultas;
using SistemaPetshop_2._0.Suporte;
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
    public partial class FormListEmpresa : Form
    {
        public FormListEmpresa()
        {
            InitializeComponent();
            dgvlistempresa.AutoGenerateColumns = false;
        }

        private void FormListEmpresa_Load(object sender, EventArgs e)
        {
            Dados_iniciais();

        }

        private void Dados_iniciais()
        {
            DataTable dados = ClassEmpresa.BuscaEmpresaListagem();
            dgvlistempresa.DataSource = new BindingSource(dados, null);
            if (ClassSerial.qtdecnpj == 1)
            {
                btnInativar.Enabled = false;
                btnIncluir.Enabled = false;
            }
            if (ClassUSUARIO.ID_USUARIO > 0 && ClassSerial.qtdecnpj > 1)
            {
                DataTable temp = ClassEmpresa.BuscaEmpresaUSUARIO();
                if (temp.Rows.Count == 1)
                {
                    btnInativar.Enabled = false;
                    btnIncluir.Enabled = true;
                }
                if (temp.Rows.Count > 1)
                {
                    btnInativar.Enabled = true;
                    btnIncluir.Enabled = true;
                }

            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FormEmpresa empresa = new FormEmpresa();
            empresa.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ALTERARINFORMACOES();
        }

        private void ALTERARINFORMACOES()
        {
            int codigo = (int)dgvlistempresa.CurrentRow.Cells[0].Value;
            FormEmpresa empresa = new FormEmpresa();
            empresa.codigo = codigo;
            empresa.ShowDialog();
            Dados_iniciais();
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {

            using (var bd = new LOJA_PETEntities())
            {
                if (Suporte.ClassSerial.qtdecnpj > 1)
                {
                    int codigo = (int)dgvlistempresa.CurrentRow.Cells[0].Value;
                    var temp = bd.EMPRESA.FirstOrDefault(x => x.ID_EMPRESA == codigo && x.TIPO_EMPRESA != 1);
                    if (codigo == temp.ID_EMPRESA)
                    {
                        temp.ATIVO = false;
                        bd.SaveChanges();
                    }

                }
            }

        }

        private void dgvlistempresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ALTERARINFORMACOES();
        }

        private void FormListEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClassInfTemp.listempresa = false;
        }
    }
}
