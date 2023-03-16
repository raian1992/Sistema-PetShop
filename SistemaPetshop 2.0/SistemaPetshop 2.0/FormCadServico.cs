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
    public partial class FormCadServico : Form
    {
        public FormCadServico()
        {
            InitializeComponent();
        }
        public int codigo { get; set; }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void carregar_dados()
        {
            if (codigo > 0)
            {
                using (var bd = new LOJA_PETEntities())
                {
                    var temp = bd.SERVICO.FirstOrDefault(x => x.ID_SERVICO == codigo);
                    chkbativo.Checked = temp.ATIVO;
                    txtdescricao.Text = temp.NOME_SERVICO;
                    mtxtvalor.Text = temp.VALOR_SERVICO.ToString();
                }
            }
            else
            {
                chkbativo.Checked = true;
                chkbativo.Enabled = false;
            }

        }

        private void FormCadServico_Load(object sender, EventArgs e)
        {
            carregar_dados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //string retorno = Conversão.excluir_mascara(mtxtvalor);
            if (txtdescricao.Text.Count() > 0 && mtxtvalor.Text.Count() > 0)
            {
                using (var bd = new LOJA_PETEntities())
                {
                    SERVICO servico;
                    if (codigo > 0)
                    {
                        servico = bd.SERVICO.FirstOrDefault(x => x.ID_SERVICO == codigo);
                    }
                    else
                    {
                        servico = new SERVICO();
                    }
                    servico.NOME_SERVICO = txtdescricao.Text;
                    servico.VALOR_SERVICO = Convert.ToDecimal(mtxtvalor.Text);
                    servico.ATIVO = chkbativo.Checked;
                    if (codigo == 0)
                    {
                        bd.SERVICO.Add(servico);
                    }
                    bd.SaveChanges();
                    MessageBox.Show("Serviço Salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
            }
        }
    }
}
