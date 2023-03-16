using SistemaPetshop_2._0.Suporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
{
    public partial class FormChave : Form
    {
        public FormChave()
        {
            InitializeComponent();
        }
        public int qtde_cnpj;
        public string chv_old;
        private string pasta;
        public string arquivo;
        public bool retorno = false;
        private void FormChave_Load(object sender, EventArgs e)
        {
            txtserialold.Text = chv_old;
        }

        private void btncopiar_Click(object sender, EventArgs e)
        {
            if (txtserialold.Text != "")
            {
                Clipboard.SetText(txtserialold.Text);
            }
        }

        private void gerarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarpastas.Description = "Selecione o Diretorio para Salvar serial antigo";
            if (buscarpastas.ShowDialog() == DialogResult.OK)
            {
                pasta = buscarpastas.SelectedPath;
                using (StreamWriter writer = new StreamWriter(pasta + "\\serialold.txt"))
                {
                    writer.Write(txtserialold.Text);
                    writer.Close();
                }
                MessageBox.Show("Processo Realizado com Sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void carregarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscararquivos.InitialDirectory = @"c:\";
            buscararquivos.Filter = "txt files (*.txt)|*.txt";
            buscararquivos.FilterIndex = 1;
            buscararquivos.RestoreDirectory = true;
            if (buscararquivos.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                //arquivo = buscararquivos.FileName;

                //Read the contents of the file into a stream
                var fileStream = buscararquivos.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    txtserienova.Text = reader.ReadToEnd();
                    reader.Close();
                }
                File.Delete(fileStream.ToString());
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            arquivo = txtserienova.Text;
            if (ClassSerial.validaserial(arquivo, qtde_cnpj) == true)
            {
                MessageBox.Show("Chave validada com sucesso, a aplicação será Reiniciada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                retorno = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("A chave informada esta incorreta, favor verificar com o suporte", "CHAVE INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtserienova.Text = "";
            }


        }
    }
}
