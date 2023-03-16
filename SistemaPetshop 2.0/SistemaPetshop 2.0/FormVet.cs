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
    public partial class FormVet : Form
    {
        public FormVet()
        {
            InitializeComponent();
        }
        public int codigo = 0;
        private void FormVet_Load(object sender, EventArgs e)
        {

            if (codigo > 0)
            {
                chkAtivo.Enabled = true;
                carregar_informacoes();

            }
            else
            {
                chkAtivo.Enabled = false;
                chkAtivo.Checked = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void carregar_informacoes()
        {
            using (var bd = new LOJA_PETEntities())
            {
                var vet = bd.Veterinarios.FirstOrDefault(x => x.ID_VET == codigo);
                txtnomvet.Text = vet.NOME_VET;
                txtcpfvet.Text = vet.CPF;
                txtcrmv.Text = vet.CRMV;
                mtxttelres.Text = vet.TELEFONE;
                mtxtcel.Text = vet.CELULAR;
                chkAtivo.Checked = vet.ATIVO;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Conversão.verificanum(e.KeyChar.ToString()) == false)
            {
                e.Handled = true;
            }
        }

        private void mtxttelres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Conversão.verificanum(e.KeyChar.ToString()) == false)
            {
                e.Handled = true;
            }
        }

        private void mtxtcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Conversão.verificanum(e.KeyChar.ToString()) == false)
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var bd = new LOJA_PETEntities())
            {
                Veterinarios vet;
                if (codigo == 0)
                {
                    vet = new Veterinarios();
                }
                else
                {
                    vet = bd.Veterinarios.FirstOrDefault(x => x.ID_VET == codigo);
                }
                vet.NOME_VET = txtnomvet.Text;
                vet.CPF = txtcpfvet.Text;
                vet.CRMV = txtcrmv.Text;
                vet.TELEFONE = Conversão.excluir_mascara(mtxttelres);
                vet.CELULAR = Conversão.excluir_mascara(mtxtcel);
                vet.ATIVO = chkAtivo.Checked;
                if (codigo == 0)
                {
                    bd.Veterinarios.Add(vet);
                }
                bd.SaveChanges();
                MessageBox.Show("Informação Salva com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
