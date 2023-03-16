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
    public partial class USCADPET : UserControl
    {
        public USCADPET()
        {
            InitializeComponent();
        }
        public int codigo = 0;
        public int codigo_cliente = 0;
        public string nome_pet = "";

        public void limparinformações()
        {
            codigo_cliente = 0;
            codigo = 0;
            //Cliente
            lblcodigo.Text = "";
            txtbusca.Text = "";
            //PET
            txtnomepet.Text = "";
            cbxtipopet.Text = "";
            txtracapet.Text = "";
            cbxsexopet.Text = "";
            txtidade.Text = "";
            chkAtivo.Checked = true;
            chkAtivo.Enabled = false;
        }

        public void carregar_informacoes()
        {
            using (var bd = new LOJA_PETEntities())
            {
                if (codigo == 0)
                {
                    chkAtivo.Checked = true;
                    chkAtivo.Enabled = false;
                }
                else
                {

                    var pet = bd.PETS.FirstOrDefault(x => x.ID_PET == codigo);
                    codigo_cliente = pet.COD_CLIENTE;
                    codigo = pet.ID_PET;
                    lblcodigo.Text = pet.PROPRIETARIOS.ID_PROPRIETARIO.ToString();
                    txtbusca.Text = pet.PROPRIETARIOS.NOME_PROPRIETARIO;
                    txtracapet.Text = pet.RACA_PET;
                    txtnomepet.Text = pet.NOME_PET;
                    cbxtipopet.Text = pet.ESPECIE_PET;
                    cbxsexopet.Text = pet.SEXO_PET;
                    dtpnascimento.Value = pet.DATANASC_PET.Value;
                    txtidade.Text = pet.IDADE;
                    chkAtivo.Checked = pet.ATIVO;
                }
                if (codigo_cliente != 0 && codigo == 0)
                {
                    var prop = bd.PROPRIETARIOS.FirstOrDefault(x => x.ID_PROPRIETARIO == codigo_cliente);
                    lblcodigo.Text = prop.ID_PROPRIETARIO.ToString();
                    txtbusca.Text = prop.NOME_PROPRIETARIO;
                    btnbusca.Enabled = false;
                    grbcliente.Enabled = false;
                }
            }

        }

        private void btnbusca_Click(object sender, EventArgs e)
        {
            FormListProprietario form = new FormListProprietario();
            form.prp_pet = true;
            form.ShowDialog();
            codigo_cliente = form.codigo;
            if (codigo_cliente > 0)
            {
                using (var bd = new LOJA_PETEntities())
                {
                    var prp = bd.PROPRIETARIOS.FirstOrDefault(x => x.ID_PROPRIETARIO == codigo_cliente);
                    lblcodigo.Text = prp.ID_PROPRIETARIO + " - ";
                    txtbusca.Text = " " + prp.NOME_PROPRIETARIO;
                }
            }
        }


        public void esconderchkbox()
        {
            chkAtivo.Enabled = false;
        }
        public void salvardados()
        {
            nome_pet = txtnomepet.Text;
            if (nome_pet != "")
            {
                PET pet;
                using (var bd = new LOJA_PETEntities())
                {
                    if (codigo_cliente > 0)
                    {
                        if (codigo == 0)
                        {
                            pet = new PET();
                        }
                        else
                        {
                            pet = bd.PETS.FirstOrDefault(x => x.ID_PET == codigo);
                        }

                        pet.COD_CLIENTE = codigo_cliente;
                        pet.NOME_PET = txtnomepet.Text;
                        pet.ESPECIE_PET = cbxtipopet.Text;
                        pet.RACA_PET = txtracapet.Text;
                        pet.SEXO_PET = cbxsexopet.Text;
                        pet.DATANASC_PET = Convert.ToDateTime(dtpnascimento.Value);
                        pet.IDADE = txtidade.Text;
                        pet.ATIVO = chkAtivo.Checked;

                        if (codigo == 0)
                        {
                            bd.PETS.Add(pet);
                        }
                        bd.SaveChanges();
                       
                    }
                }
            }
        }
    }
}
