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
    public partial class FormCadPagamento : Form
    {
        public FormCadPagamento()
        {
            InitializeComponent();
        }

        public int codigo;
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadPagamento_Load(object sender, EventArgs e)
        {
            ENUMPAGAMENTO.carregardadospag();
            using (var bd = new LOJA_PETEntities())
            {

                if (bd.TAXAS.Count() > 0)
                {
                    var taxas = bd.TAXAS.ToList();
                    cbxtaxas.DataSource = new BindingSource(taxas, null);
                    cbxpag.DataSource = new BindingSource(ENUMPAGAMENTO.PAG, null);
                }
                else
                {
                    MessageBox.Show("Antes de cadastrar uma forma de pagamento é necessario cadastrar as taxas", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                if (codigo > 0)
                {
                    var pag = bd.PAGAMENTOS.FirstOrDefault(x => x.ID_PAGAMENTOS == codigo);
                    txtnome.Text = pag.NOME;
                    cbxpag.SelectedValue = pag.TIPO_PAG;
                    cbxtaxas.SelectedValue = pag.ID_TAXAS;
                    chkAtivo.Checked = pag.ATIVO;
                    chkgerfin.Checked = pag.Gera_Fin;
                }
                else
                {
                    cbxtaxas.SelectedValue = 1;
                    cbxpag.SelectedValue = 1;
                    chkAtivo.Checked = true;
                    chkAtivo.Enabled = false;
                }

            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text != "")
            {
                using (var bd = new LOJA_PETEntities())
                {
                    PAGAMENTOS pag;
                    if (codigo > 0)
                    {
                        pag = bd.PAGAMENTOS.FirstOrDefault(x => x.ID_PAGAMENTOS == codigo);
                    }
                    else
                    {
                        pag = new PAGAMENTOS();
                    }
                    pag.NOME = txtnome.Text;
                    pag.ID_TAXAS = Convert.ToInt32(cbxtaxas.SelectedValue);
                    pag.TIPO_PAG = Convert.ToInt32(cbxpag.SelectedValue);
                    pag.ATIVO = chkAtivo.Checked;
                    pag.Gera_Fin = chkgerfin.Checked;

                    if (codigo == 0)
                    {
                        bd.PAGAMENTOS.Add(pag);
                    }
                    bd.SaveChanges();
                    MessageBox.Show("Pagamento salvo com sucesso", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
        }
    }
}
