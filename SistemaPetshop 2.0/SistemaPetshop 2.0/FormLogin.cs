using SistemaPetshop_2._0.ClasseConsultas;
using SistemaPetshop_2._0.Suporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        string loginsup = "SUPERVISOR";
        string senhasup = "12345678";
        public bool erro = false;
        public bool liberado = false;
        private bool usu_ativo = true;
        private void btnconectar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var bd = new LOJA_PETEntities())
                {
                    //colocar dados para validação sem ser a senha de ADM
                    ClassComandoSQL.conn.ConnectionString = bd.Database.Connection.ConnectionString;
                    if (txtusuario.Text == loginsup && txtsenha.Text == senhasup)
                    {
                        //MessageBox.Show("Login de Supervisor aprovado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        liberado = true;
                        ClassUSUARIO.NomeLogin = txtusuario.Text;
                        this.Close();
                    }
                    if (txtusuario.Text == loginsup && txtsenha.Text != senhasup && erro == false)
                    {
                        MessageBox.Show("Login de Supervisor incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtusuario.Focus();
                        liberado = false;
                    }
                    if (txtusuario.Text != loginsup)
                    {

                        var usuario = bd.USUARIOS.FirstOrDefault(x => x.lOGIN.ToUpper() == txtusuario.Text.ToUpper() && x.ATIVO == true);
                        if (usuario != null)
                        {
                            erro = false;
                            if (usuario.ID_PERFIL > 0 && usuario.lOGIN.Length > 0)
                            {
                                if (txtsenha.Text == ClassCript.descriptografarsenha(usuario.SENHA))
                                {
                                    ClassUSUARIO.ID_USUARIO = usuario.Id_USUARIO;
                                    ClassUSUARIO.NomeLogin = usuario.NOME;
                                    //  MessageBox.Show("Login aprovado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    liberado = true;
                                    this.Close();
                                }

                            }

                        }
                        else
                        {

                            var inativo = bd.USUARIOS.FirstOrDefault(x => x.lOGIN.ToUpper() == txtusuario.Text.ToUpper());
                            if (inativo != null && txtsenha.Text == ClassCript.descriptografarsenha(inativo.SENHA))
                            {
                                usu_ativo = inativo.ATIVO;
                            }

                        }
                    }


                    if (liberado == false && txtusuario.Text != loginsup && usu_ativo == true)

                    {
                        MessageBox.Show("Login  incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtusuario.Text = "";
                        txtsenha.Text = "";
                        liberado = false;
                        txtusuario.Focus();
                    }
                    if (liberado == false && txtusuario.Text != loginsup && usu_ativo == false)
                    {
                        MessageBox.Show("Usuario informado esta Inativo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    txtusuario.Text = "";
                    txtsenha.Text = "";

                }
            }
            catch (Exception)
            {
                erro = true;
                MessageBox.Show("Falha na comunicação com o banco de dados, entre em contato com o suporte", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (txtusuario.Text != "")
                {
                    txtsenha.Focus();
                }
                else
                {
                    MessageBox.Show("Preencha o campo Corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.KeyCode == Keys.F12)
            {
                continuacao();
            }
        }

        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {

                if (txtusuario.Text != "")
                {
                    btnconectar.Focus();
                }
                else
                {
                    MessageBox.Show("Preencha o campo Corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.KeyChar == (char)Keys.F12)
            {
                continuacao();
            }
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F12)
            {
                continuacao();
            }
        }

        private void continuacao()
        {
            Suporte.FormSenha frmsenha = new Suporte.FormSenha();
            frmsenha.ShowDialog();
            bool liberado = frmsenha.liberado;
            if (liberado == true)
            {
                Suporte.FormConfigSuporte formConfig = new Suporte.FormConfigSuporte();
                formConfig.ShowDialog();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            buscar_banco();
        }

        private void buscar_banco()
        {
            int qtde_cnpj;
            bool validado = false;
            try
            {

                using (var bd = new LOJA_PETEntities())
                {
                    if (bd.CONFIG.Count() == 0)
                    {
                        erro = false;
                        Config_inicial.Criar_config_inicial();
                    }
                    Properties.Settings prp = new Properties.Settings();

                    if (prp.TIPO_MAQ.ToString() == "")
                    {
                        string dados = bd.Database.Connection.DataSource;//verificar uma maneira melhor de confirmar o servidor.

                        string[] inf = dados.Split('\\');
                        if (inf[0].ToUpper() == ClassSerial.nomepc.ToUpper() || inf[0].ToUpper() == ClassSerial.ippc || inf[0].ToUpper() == "LOCALHOST" || inf[0].ToUpper() == "127.0.0.1")
                        {
                            Config_inicial.tipo_maquina(1);
                        }
                        else
                        {
                            Config_inicial.tipo_maquina(2);
                        }
                    }

                    var temp = bd.EMPRESA.FirstOrDefault(x => x.ATIVO == true && x.TIPO_EMPRESA == 1);
                    qtde_cnpj = bd.EMPRESA.Where(x => x.ATIVO == true).Count();
                    if (temp.CHV == null)
                    {
                        temp.CHV = "";

                    }
                    if (temp.CHV != "" && prp.TIPO_MAQ.ToString() == "SERVER")
                    {


                        if (prp.TIPO_MAQ.ToString() == "SERVER")
                        {
                            validado = ClassSerial.validaserial(temp.CHV, qtde_cnpj);
                            temp.CONFIG.DT_VAL = ClassSerial.datainfinal;
                            bd.SaveChanges();
                        }
                        else
                        {
                            validado = ClassSerial.validarvencimentoestacao(temp.CHV);//validar com o serial do hd do servidor na chave e verificar se esta correto e com a data correta
                        }

                        if (validado == false)
                        {
                            MessageBox.Show("Sistema com data vencida!", "CHAVE EXPIRADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            FormChave chave = new FormChave();
                            chave.chv_old = ClassSerial.seriecompletanova;
                            chave.qtde_cnpj = qtde_cnpj;
                            chave.ShowDialog();
                            bool retorno = chave.retorno;

                            if (retorno == true && chave.arquivo != "")
                            {
                                temp.CHV = chave.arquivo;
                                bd.SaveChanges();
                                Application.Restart();
                            }
                            else
                            {
                                Application.Exit();
                            }
                            //QUANDO CHEGAR AQUI GERAR UM FORM PARA IMPORTAR A CHAVE NOVA OU DIGITADA. APOS ISSO USAR O APPLICATION.REESTART(); PARA VALIDAR NOVAMENTE
                        }
                    }
                    if (temp.CHV == "")
                    {


                        if (prp.TIPO_MAQ.ToString() == "SERVER")
                        {
                            temp.CHV = ClassCript.criptografarSenha(ClassSerial.GerarSerial(DateTime.Now.Date.AddDays(-1), 1));
                            bd.SaveChanges();
                            Application.Restart();
                        }
                        else
                        {
                            MessageBox.Show("O sistema Detectou que esta sem chave, entre em contato com o revendedor", "CHAVE INEXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();//adicionar um campo de matriz e filial
                                               //colocar no serial quantifades de empresas cadastradas 
                                               // carregar essas empresas na classceipt
                                               // criar o form de recepção e geração de serial
                                               // atualizae datas de instalação e validadr  do sistema ao abrir o sistema
                                               // criar as views do sistema 
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                erro = true;
                MessageBox.Show("Falha na comunicação com o banco de dados " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception e)
            {
                erro = true;
                MessageBox.Show("Falha na comunicação com o banco de dados " + e.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblesqueceusenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //esqueceu a senha irá tentar pela contra senha e caso nao consiga poderá redefinir a senha pelo e-mail configurado no cadastro do usuario
            FormEsqueceuasenha form = new FormEsqueceuasenha();
            form.ShowDialog();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
