using SistemaPetshop_2._0.Adicionais;
using SistemaPetshop_2._0.Suporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
{
    public partial class FormEmpresa : Form
    {
        public FormEmpresa()
        {
            InitializeComponent();
        }
        public int codigo = 0;
        private int id_email = 0;
        string tipo_juros, Ger_juros;

        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            if (codigo > 0)

            {
                using (var bd = new LOJA_PETEntities())
                {
                    var temp = bd.EMPRESA.FirstOrDefault(x => x.ID_EMPRESA == codigo);
                    txtrazaosocial.Text = temp.RAZAO_SOCIAL;
                    txtnomefantasia.Text = temp.FANTASIA;
                    txtcnpjcpf.Text = temp.CNPJ_CPF;
                    txtemail.Text = temp.EMAIL;
                    txtrgie.Text = temp.IE_RG;
                    mtxtcep.Text = temp.CEP;
                    txtrua.Text = temp.ENDERECO;
                    txtNumero.Text = temp.NUMERO;
                    txtBairro.Text = temp.BAIRRO;
                    txtcidade.Text = temp.CIDADE;
                    txtEstado.Text = temp.ESTADO;
                    mtxttelres.Text = temp.TELEFONE;
                    mtxtcel.Text = temp.CELULAR;
                    retorna_marcacao_Juros(temp.Tipo_juros, temp.Cobr_juros);
                    txtjuros.Text = temp.P_juros.ToString();
                    txtmulta.Text = temp.P_MULTA.ToString();
                    if (temp.CNPJ_CPF.Count() > 11)
                    {
                        cbxtipoEmpresa.Text = "JURIDICA";
                        lblcnpjcpf.Text = "CNPJ:";
                        lblrgie.Text = "Inscrição Estadual:";
                    }
                    else
                    {
                        cbxtipoEmpresa.Text = "FISICA";
                        lblcnpjcpf.Text = "CPF:";
                        lblrgie.Text = "                   RG:";
                    }
                    if (temp.ATIVO == true)
                    {
                        cbxstatus.Text = "ATIVO";
                    }
                    else
                    {
                        cbxstatus.Text = "INATIVO";
                    }
                    if (ClassSerial.qtdecnpj == 1)

                    {

                        cbxstatus.Enabled = false;
                        cbxstatus.Text = "ATIVO";
                    }
                    if (temp.EMPRESA_EMAIL.Count() > 0)
                    {
                        var carregaemail = temp.EMPRESA_EMAIL.FirstOrDefault(x => x.ID_EMAIL == x.EMAIL.ID_EMAIL);
                        txtsmtp.Text = carregaemail.EMAIL.SMTP;
                        txtporta.Text = carregaemail.EMAIL.PORTA;
                        txtemail2.Text = carregaemail.EMAIL.END_EMAIL;
                        txtsenha.Text = ClassCript.descriptografarsenha(carregaemail.EMAIL.SENHA);
                        chkAut.Checked = carregaemail.EMAIL.Req_AUT;
                        chkssl.Checked = carregaemail.EMAIL.Req_SSL;
                        id_email = carregaemail.ID_EMAIL;

                    }
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

        private void CbxtipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxtipoEmpresa.Text == "JURIDICA")
            {
                lblcnpjcpf.Text = "CNPJ:";
                lblrgie.Text = "Inscrição Estadual:";
            }
            else
            {
                lblcnpjcpf.Text = "CPF:";
                lblrgie.Text = "                    RG:";
            }
        }

        private void Txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text != "")
            {
                bool retorno = Conversão.Valida_email(txtemail.Text);
                if (retorno == false)
                {
                    MessageBox.Show("Email incorreto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtcnpjcpf_Leave(object sender, EventArgs e)
        {
            bool retorno = false;
            string CAMPO;
            if (cbxtipoEmpresa.Text == "FISICA")
            {
                retorno = Conversão.ValidaCPF(txtcnpjcpf.Text);
                CAMPO = "CPF";
            }
            else
            {
                retorno = Conversão.ValidaCNPJ(txtcnpjcpf.Text);
                CAMPO = "CNPJ";
            }
            if (retorno == false)
            {
                MessageBox.Show("O VALOR DIGITADO NO CAMPO " + CAMPO + " ESTA INCORRETO ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcnpjcpf.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            EMPRESA _empresa;
            using (var bd = new LOJA_PETEntities())
            {
                if (codigo == 0)
                {
                    _empresa = new EMPRESA();
                }
                else
                {
                    _empresa = bd.EMPRESA.FirstOrDefault(x => x.ID_EMPRESA == codigo);
                }
                //dados principais
                if (cbxstatus.Text == "ATIVO")
                {
                    _empresa.ATIVO = true;
                }
                else
                {
                    _empresa.ATIVO = false;
                }
                _empresa.RAZAO_SOCIAL = txtrazaosocial.Text;
                _empresa.FANTASIA = txtnomefantasia.Text;
                _empresa.CNPJ_CPF = txtcnpjcpf.Text;
                _empresa.IE_RG = txtrgie.Text;

                //endereco
                _empresa.CEP = Conversão.RetirarIfemCEP(mtxtcep.Text);
                _empresa.ENDERECO = txtrua.Text;
                _empresa.NUMERO = txtNumero.Text;
                _empresa.BAIRRO = txtBairro.Text;
                _empresa.CIDADE = txtcidade.Text;
                _empresa.ESTADO = txtEstado.Text;
                retorna_Valor();
                _empresa.Tipo_juros = tipo_juros;
                _empresa.Cobr_juros = Ger_juros;
                _empresa.P_juros = Conversão.Format_string_Decimal_18_2(txtjuros.Text);
                _empresa.P_MULTA = Conversão.Format_string_Decimal_18_2(txtmulta.Text);
                //contatos
                _empresa.TELEFONE = Conversão.excluir_mascara(mtxttelres);
                _empresa.CELULAR = Conversão.excluir_mascara(mtxtcel);

                _empresa.EMAIL = txtemail.Text;

                if (_empresa.ID_CONFIG == 0)
                {
                    _empresa.ID_CONFIG = bd.CONFIG.Min<CONFIG>().ID_CONFIG;
                }
                //if (_empresa.EMPRESA_USUARIO.Count()== 0)
                //{
                //    _empresa.ID_CONFIG = bd.CONFIG.Min<CONFIG>().ID_CONFIG;
                //}
                if (codigo == 0)
                {
                    bd.EMPRESA.Add(_empresa);
                }
                bd.SaveChanges();
                MessageBox.Show("Informações Salvas com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
        private void retorna_marcacao_Juros(string TIpo_juros, string Ger_juros)
        {
            if (TIpo_juros == "S")
            {
                rdbSimples.Checked = true;
            }
            else if (TIpo_juros == "C")
            {
                rdbComposto.Checked = true;
            }
            if (Ger_juros == "D")
            {
                rdbjurosdiarios.Checked = true;
            }
            else if (Ger_juros == "M")
            {
                rdbjurosmensal.Checked = true;
            }
        }

        private void retorna_Valor()
        {
            if (rdbSimples.Checked == true)
            {
                tipo_juros = "S";
            }
            if (rdbComposto.Checked == true)
            {
                tipo_juros = "C";
            }
            if (rdbjurosdiarios.Checked == true)
            {
                Ger_juros = "D";
            }
            if (rdbjurosmensal.Checked == true)
            {
                Ger_juros = "M";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Conversão.verificanum(e.KeyChar.ToString()) == false)
            {
                e.Handled = true;
            }
        }

        private void txtesteemail_Click(object sender, EventArgs e)
        {
            string retorno = ClassE_mail.EnviaMensagemEmail(txtemail2.Text, txtemail2.Text, "Teste Envio E-mail", "A configuração do E-mail está correta", txtsmtp.Text, Convert.ToInt32(txtporta.Text), txtsenha.Text, chkssl.Checked);
            MessageBox.Show(retorno, "Retorno Envio E-mail", MessageBoxButtons.OK);
        }

        private void txtsalvar_Click(object sender, EventArgs e)
        {
            using (var bd = new LOJA_PETEntities())
            {
                EMAIL mAIL;
                if (id_email != 0)
                {
                    mAIL = bd.EMAIL.FirstOrDefault(x => x.ID_EMAIL == id_email);
                    mAIL.SMTP = txtsmtp.Text;
                    mAIL.PORTA = txtporta.Text;
                    mAIL.END_EMAIL = txtemail2.Text;
                    mAIL.SENHA = ClassCript.criptografarSenha(txtsenha.Text);
                    mAIL.Req_AUT = chkAut.Checked;
                    mAIL.Req_SSL = chkssl.Checked;
                    bd.SaveChanges();
                    MessageBox.Show("E-mail Salvo com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    mAIL = new EMAIL();
                    mAIL.ID_EMAIL = id_email;
                    mAIL.SMTP = txtsmtp.Text;
                    mAIL.PORTA = txtporta.Text;
                    mAIL.END_EMAIL = txtemail2.Text;
                    mAIL.SENHA = ClassCript.criptografarSenha(txtsenha.Text);
                    mAIL.Req_AUT = chkAut.Checked;
                    mAIL.Req_SSL = chkssl.Checked;

                    bd.EMAIL.Add(mAIL);

                    bd.SaveChanges();

                    EMPRESA_EMAIL mPRESA_EMAIL;
                    mPRESA_EMAIL = new EMPRESA_EMAIL();
                    var tmp = bd.EMAIL.FirstOrDefault(x => x.END_EMAIL == txtemail2.Text);
                    mPRESA_EMAIL.ID_EMAIL = tmp.ID_EMAIL;
                    mPRESA_EMAIL.ID_EMPRESA = codigo;
                    bd.EMPRESA_EMAIL.Add(mPRESA_EMAIL);
                    bd.SaveChanges();
                    MessageBox.Show("E-mail Salvo com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void txtjuros_Leave(object sender, EventArgs e)
        {
            if (Conversão.verificanum(txtjuros.Text) == false)
            {
                MessageBox.Show("a informação digitada não é um numero", "informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtjuros.Focus();

            }
        }
        private void txtmulta_Leave(object sender, EventArgs e)
        {
            if (Conversão.verificanum(txtmulta.Text) == false)
            {
                MessageBox.Show("a informação digitada não é um numero", "informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtmulta.Focus();
            }


        }
    }
}
