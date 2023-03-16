using System;
using System.Net;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace SistemaPetshop_2._0.Suporte
{
    public partial class FormConfigSuporte : Form
    {
        public FormConfigSuporte()
        {
            InitializeComponent();
            carregardadosbanco();
        }

        private string[] subs, srv, banco, usuario, senha;
        private string string_conexao;
        ConnectionStringSettings connection = ConfigurationManager.ConnectionStrings["LOJA_PETEntities"];
        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        bool mov_estq, ult_estq, val_cpf, ut_banho, ult_vend;
        CONFIG inical_config;

        private void carregardadosbanco()
        {
            string teste = connection.ConnectionString.ToString();
            subs = teste.Split(';');
            //connection.CurrentConfiguration.Save();
            srv = subs[2].Split('=');
            banco = subs[3].Split('=');
            usuario = subs[4].Split('=');
            senha = subs[5].Split('=');
            txtusuario.Text = usuario[1];
            txtsenha.Text = senha[1];
            txtservidor.Text = srv[2];
            txtbanco.Text = banco[1];
        }

        private void PReencherPadrao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //colocar para carregar os dados segundo a informação do id;
            using (var bd = new LOJA_PETEntities())
            {
                int temp = Convert.ToInt32(cbxID.SelectedValue);
                inical_config = bd.CONFIG.FirstOrDefault(x => x.ID_CONFIG == temp);
                carregardados();
            }
        }





        private void carregardados()
        {

            switch (inical_config.AT_CHV)
            {

                case 0:
                    rdbdemonstracao.Checked = true;
                    break;
                case 1:
                    rdbatmensal.Checked = true;
                    break;

                case 2:
                    rdbatualizacaosemestral.Checked = true;
                    break;

                case 3:
                    rdbatualizacaoanual.Checked = true;
                    break;
                default:
                    rdbdemonstracao.Checked = true;
                    break;
            }
            chkmovestoque.Checked = inical_config.MOV_ESTOQUE;
            chkfinanceiro.Checked = inical_config.UT_FIN;
            validacpfcnpj.Checked = inical_config.Val_CPF_CNPJ;
            chkbanhoetosa.Checked = inical_config.UT_BANHOETOSA;
            chkmenuvenda.Checked = inical_config.UT_VENDA;

        }
        private void validamarcacao()
        {
            CONFIG dados_config;
            using (var bd = new LOJA_PETEntities())
            {
                int temp = Convert.ToInt32(cbxID.SelectedValue);
                if (temp > 0)
                {
                    dados_config = bd.CONFIG.FirstOrDefault(x => x.ID_CONFIG == temp);
                }
                else
                {
                    dados_config = new CONFIG();
                }

                if (rdbdemonstracao.Checked == true)
                {
                    dados_config.AT_CHV = 0;
                }

                if (rdbatmensal.Checked == true)
                {
                    dados_config.AT_CHV = 1;
                }
                if (rdbatualizacaosemestral.Checked == true)
                {
                    dados_config.AT_CHV = 2;
                }
                if (rdbatualizacaoanual.Checked == true)
                {
                    dados_config.AT_CHV = 3;
                }
                dados_config.MOV_ESTOQUE = chkmovestoque.Checked;
                dados_config.UT_FIN = chkfinanceiro.Checked;
                dados_config.Val_CPF_CNPJ = validacpfcnpj.Checked;
                dados_config.UT_BANHOETOSA = chkbanhoetosa.Checked;
                dados_config.UT_VENDA = chkmenuvenda.Checked;

                bd.SaveChanges();
            }
        }
        private void cbxbanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxbanco.Text == "Padrao")
            {
                txtservidor.Text = "LOCALHOST";
                txtbanco.Text = "LOJAPET";
                txtusuario.Text = "SA";
                txtsenha.Text = "SA_123456";
            }
            if (cbxbanco.Text == "Atual")
            {
                carregardadosbanco();
            }
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();

                conn.ConnectionString = "Server=" + txtservidor.Text + ";Database=" + txtbanco.Text + ";User Id=" + txtusuario.Text + ";Password=" + txtsenha.Text + ";" + "Connect Timeout = 10;";
                conn.Open();
                MessageBox.Show("estado da conexao:" + conn.State + " e Versao do Servidor" + conn.ServerVersion, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Falha na conexao com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormConfigSuporte_Load(object sender, EventArgs e)
        {
            string[] retorno = Escrever_em_Arquivo.LerConexaoBD();
            if (retorno.Length == 5)
            {
                txtservidor.Text = retorno[0];
                txtbanco.Text = retorno[1];
                txtusuario.Text = retorno[2];
                txtsenha.Text = retorno[3];

            }

            this.BringToFront();
            try
            {
                if (Adicionais.ClassInfTemp.bdconn == true)
                {
                    using (var dados = new LOJA_PETEntities())
                    {
                        inical_config = dados.CONFIG.FirstOrDefault(x => x.ATIVO == true);
                        cbxID.DataSource = new BindingSource(inical_config, null);
                        cbxID.SelectedItem = 1;
                        dtpinstalacao.Value = inical_config.DT_INST;
                        dtpval.Value = inical_config.DT_VAL;
                        if (DateTime.Now.Date == dtpinstalacao.Value.Date)
                        {
                            dtpinstalacao.Enabled = true;
                        }
                        else
                        {
                            dtpinstalacao.Enabled = false;
                        }
                        Adicionais.ClassInfTemp.bdconn = true;
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Banco de dados não encontrado!, configure o banco corretamente e salve os dados", "erro de configuração!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Adicionais.ClassInfTemp.bdconn = false;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string_conexao = subs[0] + ";" +
                subs[1] + ";" +
                srv[0] + "=" +
                srv[1] + "=" +
                txtservidor.Text + ";" +
                banco[0] + "=" +
                txtbanco.Text + ";" +
                usuario[0] + "=" +
                txtusuario.Text + ";"
                + senha[0] + "="
                + txtsenha.Text + ";"
                + subs[6] + ";"
                + subs[7] + ";";

            config.ConnectionStrings.ConnectionStrings["LOJA_PETEntities"].ConnectionString = string_conexao;
            //var settings = config.AppSettings.Settings;
            config.Save(ConfigurationSaveMode.Full);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            bool servidor = false;
            string nome = Dns.GetHostName();

            IPAddress[] ip = Dns.GetHostAddresses(nome);
            string[] teste2 = txtservidor.Text.Split('\\');
            if (nome.Equals(teste2[0].ToUpper()) || ip.ToString().Equals(teste2[0]) || txtservidor.Text.ToUpper() == "LOCALHOST" || txtservidor.Text == "127.0.0.1")
            {
                servidor = true;
            }

            if (txtservidor.Text != "" && txtusuario.Text != "" && txtsenha.Text != "")
            {
                servidor = Escrever_em_Arquivo.Gravarconexaobanco(
                     txtservidor.Text,
                     txtbanco.Text,
                     txtusuario.Text,
                     txtsenha.Text, servidor, true);
                validamarcacao();
                if (servidor == true)
                {
                    MessageBox.Show("Informações salvas com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Application.Restart();
        }

        private void btnCriarBanco_Click(object sender, EventArgs e)
        {
            //CREATE TABLE CONFIG(
            //ID_CONFIG INT NOT NULL IDENTITY (1, 1),
            //AT_CHV CHAR(1) NOT NULL,
            //DT_INST date, 
            //DT_VAL date,
            //MOV_ESTOQUE CHAR(1) NOT NULL,
            //UT_BANHOETOSA CHAR(1) NOT NULL,
            //UT_FIN CHAR(1) NOT NULL,
            //UT_VENDA CHAR(1) NOT NULL,
            //CONSTRAINT PK_CONFIG PRIMARY KEY(ID_CONFIG));
        }

        private void chkfinanceiro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
