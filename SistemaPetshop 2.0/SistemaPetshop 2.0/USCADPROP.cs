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
    public partial class USCADPROP : UserControl
    {
        public USCADPROP()
        {
            InitializeComponent();
        }
        public int codigo = 0;
        public string form = "";
        public string erronome = "";

        public void limparinformacoes()
        {
            codigo = 0;
            txtnome.Text = "";
            //endereco
            mtxtcep.Text = "";
            txtrua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtcidade.Text = "";
            txtEstado.Text = "";

            //contatos
            mtxttelres.Text = "";
            mtxtcel.Text = "";
            txtemail.Text = "";

            //situação
            chkAtivo.Checked = true;
            chkAtivo.Enabled = false;
        }
        private void USCADPROP_Load(object sender, EventArgs e)
        {

        }
        public void inativarchkbox()
        {
            chkAtivo.Enabled = false;
        }
        public void carregar_dados()
        {
            using (var bd = new LOJA_PETEntities())
            {
                if (codigo > 0)
                {
                    var prop = bd.PROPRIETARIOS.FirstOrDefault(x => x.ID_PROPRIETARIO == codigo);
                    txtnome.Text = prop.NOME_PROPRIETARIO;
                    //endereço
                    mtxtcep.Text = prop.CEP;
                    txtrua.Text = prop.RUA_AVENIDA;
                    txtNumero.Text = prop.NUMERO;
                    txtBairro.Text = prop.BAIRRO;
                    txtcidade.Text = prop.CIDADE;
                    txtEstado.Text = prop.ESTADO;
                    //contato
                    mtxttelres.Text = prop.FIXO;
                    mtxtcel.Text = prop.CELULAR;
                    txtemail.Text = prop.EMAIL;
                    chkAtivo.Checked = prop.ATIVO;
                }
                else
                {
                    chkAtivo.Checked = true;
                    chkAtivo.Enabled = false;
                }
            }
        }

        private void btnbuscacorreios_Click(object sender, EventArgs e)
        {

            string CEP = Conversão.RetirarIfemCEP(mtxtcep.Text);
            List<string> ret_cep = Conversão.Verificar_buscarcep(CEP);
            if (ret_cep.Count() > 0)
            {
                txtrua.Text = ret_cep[0].ToString();
                txtBairro.Text = ret_cep[1].ToString();
                txtcidade.Text = ret_cep[2].ToString();
                txtEstado.Text = ret_cep[3].ToString();
            }
            else
            {
                MessageBox.Show("Cep digitado esta incorreto ou é inválido!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void val_fechar_form()
        {
            if (form == "FormcadProp")
            {
                FormcadProp.ActiveForm.Close();
            }

        }

        public void btnSalvar_Click()
        {
            if (txtnome.Text != "")
            {
                PROPRIETARIO _proprietario;
                using (var bd = new LOJA_PETEntities())
                {
                    if (codigo == 0)
                    {
                        _proprietario = new PROPRIETARIO();
                    }
                    else
                    {
                        _proprietario = bd.PROPRIETARIOS.FirstOrDefault(x => x.ID_PROPRIETARIO == codigo);
                    }
                    _proprietario.NOME_PROPRIETARIO = txtnome.Text;



                    //endereco
                    _proprietario.CEP = Conversão.RetirarIfemCEP(mtxtcep.Text);
                    _proprietario.RUA_AVENIDA = txtrua.Text;
                    _proprietario.NUMERO = txtNumero.Text;
                    _proprietario.BAIRRO = txtBairro.Text;
                    _proprietario.CIDADE = txtcidade.Text;
                    _proprietario.ESTADO = txtEstado.Text;

                    //contatos
                    _proprietario.FIXO = Conversão.excluir_mascara(mtxttelres);
                    _proprietario.CELULAR = Conversão.excluir_mascara(mtxtcel);
                    _proprietario.EMAIL = txtemail.Text;

                    //situação
                    _proprietario.ATIVO = chkAtivo.Checked;

                    if (codigo == 0)
                    {
                        bd.PROPRIETARIOS.Add(_proprietario);
                    }
                    bd.SaveChanges();
                    if (form == "FormcadProp")
                    {
                        MessageBox.Show("Informações Salvas com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    erronome = txtnome.Text;
                }
            }
        }

        private void mtxtcep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Conversão.verificanum(e.KeyChar.ToString()) == false)
            {
                e.Handled = true;
            }
        }
    }
}
