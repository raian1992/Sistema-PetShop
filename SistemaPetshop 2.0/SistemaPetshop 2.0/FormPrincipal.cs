using SistemaPetshop_2._0.Adicionais;
using SistemaPetshop_2._0.ClasseConsultas;
using SistemaPetshop_2._0.Suporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            ClassInfTemp.listveterinario = false;
            ClassInfTemp.listempresa = false;
            ClassInfTemp.listpet = false;
            ClassInfTemp.listproprietario = false;
            lblusuarioconectado.Text = "Usuario: " + ClassUSUARIO.NomeLogin;
            using (var bd = new LOJA_PETEntities())

            {
                if (ClassUSUARIO.ID_USUARIO > 0)
                {

                    cbxempresa.DataSource = new BindingSource(ClassEmpresa.BuscaEmpresaUSUARIO(), null);
                    ClassEmpresa.ID_EMPRESA = Convert.ToInt32(cbxempresa.SelectedValue);
                }
                else
                {
                    var temp = bd.EMPRESA.ToList();
                    cbxempresa.DataSource = new BindingSource(temp, null);
                    ClassEmpresa.ID_EMPRESA = Convert.ToInt32(cbxempresa.SelectedValue);
                }
                int comp = ClassCompromissos.quantidadecomp(DateTime.Now.Date);
                if (comp == 1)
                {
                    MessageBox.Show(" Voce possui " + comp + " compomisso pendete para o dia de hoje", "Compromisso Pendente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (comp > 1)
                {
                    MessageBox.Show(" Voce possui " + comp + " compomissos pendetes para o dia de hoje", "Compromissos Pendentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            int result = (int)(ClassSerial.datainfinal.Date - DateTime.Now.Date).TotalDays;
            lbldiaslib.Parent = pictureBox1;

            lbldiaslib.BackColor = Color.Transparent;
            if (result == 1)
            {
                lbldiaslib.Text = ("Falta " + result + " dia para expirar o sistema entre em contato com o suporte do sistema ").ToUpper();
            }
            if (result > 1)
            {
                lbldiaslib.Text = ("Faltam " + result + " dias para expirar o sistema ").ToUpper();
            }
            if (result == 0)
            {
                lbldiaslib.Text = ("O sistema expira hoje, para continuar usando o sistema entre em contato com o suporte").ToUpper();
            }
            if (result <= 10)
            {
                lbldiaslib.ForeColor = Color.Red;

            }

            lblversion.Text = "Versão: " + AssemblyVersion.ToString();

        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("LISTEMPRESA");
        }

        private void cbxempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassEmpresa.ID_EMPRESA = Convert.ToInt32(cbxempresa.SelectedValue);
        }

        private void veterinariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("LISTVET");
        }

        private void proprietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("LISTPROPRIETARIO");
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("LISTPET");
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("LISTSERVICO");
        }

        private void veterinariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("LISTVET");
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("SOBRE");

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("LISTUSUARIO");
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("AGENDA");
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("LISTPAGAMENTO");
        }

        private void taxasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("LISTTAXAS");
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClassComandoSQL.backup_banco() == true)
            {
                MessageBox.Show("Backup do Banco de dados Realizado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao realizar o Backup", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void atenidmentoVeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfTemp.control_open("ATENDIMENTOVET");
        }

        private void proprietarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.FormREL_PROP _PROP = new Relatorios.FormREL_PROP();
            _PROP.ShowDialog();
        }

        private void petsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.FormREL_PET _PET= new Relatorios.FormREL_PET();
            _PET.ShowDialog();
        }
    }
}
