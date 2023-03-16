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
    public partial class FormCadUsuario : Form
    {
        public FormCadUsuario()
        {
            InitializeComponent();
        }
        public int codigo_usuario = 0;

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadUsuario_Load(object sender, EventArgs e)
        {
            using (var bd = new LOJA_PETEntities())
            {
                var perfil = bd.PERFIL.ToList();
                cbxperfil.DataSource = new BindingSource(perfil.ToList(), null);
                if (codigo_usuario > 0)
                {
                    var usuario = bd.USUARIOS.FirstOrDefault(x => x.Id_USUARIO == codigo_usuario);
                    cbxperfil.SelectedItem = usuario.ID_PERFIL;
                    txtnome.Text = usuario.NOME;
                    txtlogin.Text = usuario.lOGIN;
                    txtsenha.Text = ClassCript.descriptografarsenha(usuario.SENHA);
                    txtconfirmsenha.Text = ClassCript.descriptografarsenha(usuario.SENHA);
                    txtcontrasenha.Text = ClassCript.descriptografarsenha(usuario.CONTRA_SENHA);
                    txtemail.Text = usuario.Email;
                    chkativo.Checked = usuario.ATIVO;

                }
                else
                {
                    chkativo.Checked = true;
                    chkativo.Enabled = false;
                }

            }
        }

        private void txtconfirmsenha_Leave(object sender, EventArgs e)
        {
            if (txtsenha.Text != txtconfirmsenha.Text)
            {
                MessageBox.Show("A senha não confere com a confirmação de senha, favor revisar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtconfirmsenha.BackColor = Color.Yellow;
                txtsenha.BackColor = Color.Yellow;
                txtsenha.Focus();
            }
            if (txtsenha.Text == txtconfirmsenha.Text)
            {
                txtconfirmsenha.BackColor = Color.White;
                txtsenha.BackColor = Color.White;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            bool retorno = ClassE_mail.ValidaEnderecoEmail(txtemail.Text);
            if (retorno == false)
            {
                MessageBox.Show("o E-mail informando não é valido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();

            }
        }

        private void brnsalvar_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text != "" && txtsenha.Text != "" && txtsenha.Text == txtconfirmsenha.Text && txtemail.Text != "")
            {
                USUARIOS usu;
                using (var bd = new LOJA_PETEntities())
                {
                    if (codigo_usuario == 0)
                    {
                        usu = new USUARIOS();
                    }
                    else
                    {
                        usu = bd.USUARIOS.FirstOrDefault(x => x.Id_USUARIO == codigo_usuario);
                    }
                    usu.ID_PERFIL = Convert.ToInt32(cbxperfil.SelectedValue);//verificar aqui
                    usu.NOME = txtnome.Text;
                    usu.lOGIN = txtlogin.Text;
                    usu.SENHA = ClassCript.criptografarSenha(txtsenha.Text);
                    usu.CONTRA_SENHA = ClassCript.criptografarSenha(txtcontrasenha.Text);
                    usu.Email = txtemail.Text;
                    usu.ATIVO = chkativo.Checked;
                    if (codigo_usuario == 0)
                    {
                        bd.USUARIOS.Add(usu);
                    }
                    bd.SaveChanges();
                    MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }
    }
}
