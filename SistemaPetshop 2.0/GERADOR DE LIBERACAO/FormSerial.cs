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
using SistemaPetshop_2._0;
using SistemaPetshop_2._0.Suporte;

namespace GERADOR_DE_LIBERACAO
{
    public partial class FormSerial : Form
    {
        public FormSerial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    txtserieantiga.Text = reader.ReadToEnd();
                    reader.Close();
                }
                File.Delete(fileStream.ToString());
            }


            //ClassSerial.GerarSerialSuporte
        }

        private void btngerarserial_Click(object sender, EventArgs e)
        {
            if (txtserieantiga.Text != "" && txtqtdecnpj.Text == "")
            {
                txtserienova.Text = ClassSerial.gerar_serial_suporte(dtpproximovencimento.Value, 0, txtserieantiga.Text);
            }
            if (txtserieantiga.Text != "" && txtqtdecnpj.Text != "")
            {
                txtserienova.Text = ClassSerial.gerar_serial_suporte(dtpproximovencimento.Value, Convert.ToInt32(txtqtdecnpj.Text), txtserieantiga.Text);
            }
            if (txtserieantiga.Text == "")
            {
                MessageBox.Show("Informe o Serial Antigo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btncopiar_Click(object sender, EventArgs e)
        {
            if (txtserienova.Text != "")
            {
                Clipboard.SetText(txtserienova.Text);
            }
        }

        private void FormSerial_Load(object sender, EventArgs e)
        {
            dtpproximovencimento.MinDate = DateTime.Now;
        }

        private void txtqtdecnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void chkbskatualizacnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbskatualizacnpj.Checked == true)
            {
                painelqtdecnpj.Visible = true;
                txtqtdecnpj.Text = "";
            }
            else
            {
                painelqtdecnpj.Visible = false;
            }
        }
    }
}
