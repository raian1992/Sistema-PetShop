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
    public partial class FormCadTaxas : Form
    {
        public FormCadTaxas()
        {
            InitializeComponent();
        }
        public int id_taxa = 0;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carregardados()
        {
            if (id_taxa > 0)
            {
                using (var bd = new LOJA_PETEntities())
                {
                    var temp = bd.TAXAS.FirstOrDefault(x => x.ID_TAXAS == id_taxa);
                    txtnome.Text = temp.DESCRICAOTX;

                    txtdebito.Text = Conversão.Format_string_Decimal_18_2(temp.TAXADEBITO.ToString()).ToString();
                    txtbol.Text = Conversão.Format_string_Decimal_18_2(temp.TAXABOLETO.ToString()).ToString();
                    txtcredito1.Text = Conversão.Format_string_Decimal_18_2(temp.TAXACREDITO1.ToString()).ToString();
                    txtcredito2.Text = Conversão.Format_string_Decimal_18_2(temp.TAXACREDITO2.ToString()).ToString();
                    txtcredito3.Text = Conversão.Format_string_Decimal_18_2(temp.TAXACREDITO3.ToString()).ToString();
                    txtcredito4.Text = Conversão.Format_string_Decimal_18_2(temp.TAXACREDITO4.ToString()).ToString();
                    txtcredito5.Text = Conversão.Format_string_Decimal_18_2(temp.TAXACREDITO5.ToString()).ToString();
                    txtcredito6.Text = Conversão.Format_string_Decimal_18_2(temp.TAXACREDITO6.ToString()).ToString();
                    txtcredito7.Text = Conversão.Format_string_Decimal_18_2(temp.TAXACREDITO7.ToString()).ToString();
                    txtcredito10.Text = Conversão.Format_string_Decimal_18_2(temp.TAXACREDITO10.ToString()).ToString();
                    chkpdivid.Checked = temp.P_DIV;
                    chkAtivo.Checked = temp.ATIVO;
                }

            }
        }

        private void FormCadTaxas_Load(object sender, EventArgs e)
        {
            if (id_taxa > 0)
            {
                carregardados();
            }
            else
            {
                string novo = "00,00";

                chkAtivo.Checked = true;
                chkAtivo.Enabled = false;
                txtdebito.Text = novo;
                txtbol.Text = novo;
                txtcredito1.Text = novo;
                txtcredito2.Text = novo;
                txtcredito3.Text = novo;
                txtcredito4.Text = novo;
                txtcredito5.Text = novo;
                txtcredito6.Text = novo;
                txtcredito7.Text = novo;
                txtcredito10.Text = novo;
            }
        }

        private string retornavalor(string valor)
        {
            string retono = "00,00";

            try
            {
                string[] temp = valor.Split('%');
                retono = temp[0];

            }
            catch (Exception)
            {

                throw;
            }

            return retono;
        }
        private void Validadar_dado(MaskedTextBox textBox)
        {
            if (Conversão.verificanum(retornavalor(textBox.Text)) == false)
            {
                MessageBox.Show("A informação digitada não é numero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();

            }
        }
        private void txtdebito_Leave(object sender, EventArgs e)// textbox debito
        {
            Validadar_dado(txtdebito);
        }

        private void txtcredito1_Leave(object sender, EventArgs e) // textbox credito 1
        {
            Validadar_dado(txtcredito1);
        }

        private void txtcredito2_Leave(object sender, EventArgs e) // textbox credito 2
        {
            Validadar_dado(txtcredito2);
        }

        private void txtcredito3_Leave(object sender, EventArgs e) // textbox credito 3
        {
            Validadar_dado(txtcredito3);
        }

        private void txtcredito4_Leave(object sender, EventArgs e)// textbox credito 4
        {
            Validadar_dado(txtcredito4);
        }

        private void txtcredito5_Leave(object sender, EventArgs e)// textbox credito 5
        {
            Validadar_dado(txtcredito5);
        }

        private void txtcredito6_Leave(object sender, EventArgs e)// textbox credito 6
        {
            Validadar_dado(txtcredito6);
        }

        private void txtcredito7_Leave(object sender, EventArgs e)// textbox credito 7
        {
            Validadar_dado(txtcredito7);
        }

        private void txtcredito10_Leave(object sender, EventArgs e)// textbox credito 10
        {
            Validadar_dado(txtcredito10);
        }

        private void txtbol_Leave(object sender, EventArgs e)// textbox Boleto
        {
            Validadar_dado(txtbol);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TAXAS tx;

            if (txtnome.Text.Count() > 0)
            {
                using (var bd = new LOJA_PETEntities())
                {
                    if (id_taxa > 0)
                    {
                        tx = bd.TAXAS.FirstOrDefault(x => x.ID_TAXAS == id_taxa);
                    }
                    else
                    {
                        tx = new TAXAS();
                    }
                    tx.DESCRICAOTX = txtnome.Text;
                    tx.ATIVO = chkAtivo.Checked;
                    tx.P_DIV = chkpdivid.Checked;
                    tx.TAXADEBITO = Conversão.Format_string_Decimal_18_2(retornavalor(txtdebito.Text));
                    tx.TAXABOLETO = Conversão.Format_string_Decimal_18_2(retornavalor(txtbol.Text));
                    tx.TAXACREDITO1 = Conversão.Format_string_Decimal_18_2(retornavalor(txtcredito1.Text));
                    tx.TAXACREDITO2 = Conversão.Format_string_Decimal_18_2(retornavalor(txtcredito2.Text));
                    tx.TAXACREDITO3 = Conversão.Format_string_Decimal_18_2(retornavalor(txtcredito3.Text));
                    tx.TAXACREDITO4 = Conversão.Format_string_Decimal_18_2(retornavalor(txtcredito4.Text));
                    tx.TAXACREDITO5 = Conversão.Format_string_Decimal_18_2(retornavalor(txtcredito5.Text));
                    tx.TAXACREDITO6 = Conversão.Format_string_Decimal_18_2(retornavalor(txtcredito6.Text));
                    tx.TAXACREDITO7 = Conversão.Format_string_Decimal_18_2(retornavalor(txtcredito7.Text));
                    tx.TAXACREDITO10 = Conversão.Format_string_Decimal_18_2(retornavalor(txtcredito10.Text));

                    if (id_taxa == 0)
                    {
                        bd.TAXAS.Add(tx);
                    }
                    bd.SaveChanges();
                    MessageBox.Show("Taxa Salva com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }

        }
    }
}
