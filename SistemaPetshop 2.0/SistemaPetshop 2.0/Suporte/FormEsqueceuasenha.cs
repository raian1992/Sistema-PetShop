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
    public partial class FormEsqueceuasenha : Form
    {
        public FormEsqueceuasenha()
        {
            InitializeComponent();
        }
        int idusuario = 0;
        string senha_temp;

        private void cbxEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxEscolha.Text == "Contra-Senha")
            {
                grpcontrasenha.Visible = true;
                grpcontrasenha.Enabled = true;
                grpemail.Enabled = false;
                grpemail.Visible = false;

            }
            else
            {
                grpcontrasenha.Visible = false;
                grpcontrasenha.Enabled = false;
                grpemail.Enabled = true;
                grpemail.Visible = true;
            }
        }

        private void btnvalidar_Click(object sender, EventArgs e)// contra senha
        {
            btnvalidar.Enabled = false;
            txtusuarioct.ReadOnly = true;
            txtcontrasenhact.ReadOnly = true;
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.USUARIOS.FirstOrDefault(x => x.lOGIN.ToUpper() == txtusuarioct.Text.ToUpper());
                if (temp != null && txtusuarioct.Text.ToUpper() == temp.lOGIN.ToUpper() && txtcontrasenhact.Text == ClassCript.descriptografarsenha(temp.CONTRA_SENHA))
                {
                    painelnovasenha1.Enabled = true;
                    idusuario = temp.Id_USUARIO;

                }
                else
                {
                    MessageBox.Show("Os dados informados estão incorretos! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnvalidar.Enabled = true;
                    txtusuarioct.ReadOnly = false;
                    txtcontrasenhact.ReadOnly = false;
                }
            }
        }

        private void btnsalvardados_Click(object sender, EventArgs e)// contra senha
        {
            if (txtnovasenhact.Text == txtcnovasenhact2.Text)
            {
                salvarnovasenha(txtcnovasenhact2.Text);
                painelnovasenha1.Enabled = false;
                txtusuarioct.ReadOnly = false;
                txtcontrasenhact.ReadOnly = false;
                txtnovasenhact.Text = "";
                txtcnovasenhact2.Text = "";
                txtusuarioct.Text = "";
                txtcontrasenhact.Text = "";
                btnvalidar.Enabled = true;
            }

        }

        private void btnvalidarem_Click(object sender, EventArgs e)
        {
            if (senha_temp == txtcodigoemail.Text)
            {
                txtcodigoemail.ReadOnly = true;
                pnredemail.Enabled = true;
            }
            else
            {
                MessageBox.Show("Codigo Informado é divergente do enviado ao email", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnenviaremail_Click(object sender, EventArgs e)// valida as informações para poder enviar o e-mail de redefinição de senha
        {
            btnenviaremail.Enabled = false;
            txtusuarioem.ReadOnly = true;
            try
            {
                using (var bd = new LOJA_PETEntities())
                {
                    var temp = bd.EMPRESA_USUARIO.FirstOrDefault(x => x.USUARIOS.lOGIN.ToUpper() == txtusuarioem.Text.ToUpper());
                    if (temp != null && txtusuarioem.Text.ToUpper() == temp.USUARIOS.lOGIN.ToUpper())
                    {
                        senha_temp = ClassSenhaAleatoria.gerarsenha();
                        var email = bd.EMPRESA_EMAIL.FirstOrDefault(x => x.ID_EMPRESA == temp.EMPRESA.ID_EMPRESA);
                        string contrasenha = "Prezado usuario: " + temp.USUARIOS.NOME.ToUpper() + "  " +
                            " a confirmação do usuario é: " + senha_temp + ".";
                        idusuario = temp.ID_USUARIO;
                        btnvalidarem.Enabled = true;
                        string retorno = ClassE_mail.E_mail_Sistema(temp.USUARIOS.Email, "Redefinição de Senha Sistema Veterinario", contrasenha, email.ID_EMAIL);
                        MessageBox.Show(retorno, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("O usuario informado esta incorreto ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnenviaremail.Enabled = true;
                        btnvalidarem.Enabled = false;
                        txtusuarioem.ReadOnly = false;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("O usuario informado esta incorreto ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnenviaremail.Enabled = true;
                btnvalidarem.Enabled = false;
                txtusuarioem.ReadOnly = false;

            }

        }

        private void bnsalvarem_Click(object sender, EventArgs e) // salvar senha nova E-mail
        {
            if (txtnovasenhaem.Text == txtcnovasenhaem.Text)
            {
                salvarnovasenha(txtnovasenhaem.Text);
            }
            btnvalidarem.Enabled = true;
            txtusuarioem.ReadOnly = false;
            txtcodigoemail.ReadOnly = false;
            txtnovasenhaem.Text = "";
            txtcodigoemail.Text = "";
            txtusuarioem.Text = "";
            txtcnovasenhaem.Text = "";
            pnredemail.Enabled = false;
        }
        private void salvarnovasenha(string senhanova)
        {
            try
            {
                using (var bd = new LOJA_PETEntities())
                {
                    USUARIOS user = bd.USUARIOS.FirstOrDefault(x => x.Id_USUARIO == idusuario);
                    user.SENHA = ClassCript.criptografarSenha(senhanova);
                    bd.SaveChanges();
                    MessageBox.Show("Senha alterada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao salvar a nova senha " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
