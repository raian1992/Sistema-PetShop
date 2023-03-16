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
    public partial class FormCadAtendimento : Form
    {
        public FormCadAtendimento()
        {
            InitializeComponent();
        }
        public int id_atendimento { get; set; }
        public int codigocliente = 0;
        private bool novocliente = false;
        public int cod_pet = 0;
        private DateTime Time = DateTime.Now.AddHours(-15);

        private void FormCadAtendimento_Load(object sender, EventArgs e)
        {
            cadprop.Enabled = false;
            pnpet.Visible = false;
            pnnovoatendimento.Visible = false;
           // tabCadastro.SelectedIndex = 1;
        }

        private void btnnovoprop_Click(object sender, EventArgs e)//cadastrar novo proprietario
        {
            cadprop.Enabled = true;
            codigocliente = 0;
            cod_pet = 0;
            novocliente = true;
            cadprop.form = "FormAtendimento";
            cadprop.limparinformacoes();
            cadpet.limparinformações();
            pnpet.Visible = false;
        }

        private void btnbuscarprop_Click(object sender, EventArgs e)//buscar e carregar os dados do proprietario
        {
            int prop_ant = codigocliente;
            FormListProprietario proprietario = new FormListProprietario();
            proprietario.prp_pet = true;
            proprietario.ShowDialog();
            codigocliente = proprietario.codigo;
            cadprop.codigo = codigocliente;
            cadpet.codigo_cliente = codigocliente;
            cadpet.carregar_informacoes();
            cadprop.form = "FormAtendimento";
            cadprop.carregar_dados();
            cadprop.Enabled = true;
            if (prop_ant != codigocliente)
            {
                cadpet.limparinformações();
            }
        }

        private void btnbuscarpet_Click(object sender, EventArgs e)
        {
            FormListPet listPet = new FormListPet();
            listPet.cad_pet = true;
            listPet.cod_cliente = codigocliente;
            listPet.ShowDialog();
            cod_pet = listPet.codigo;
            if (cod_pet > 0)
            {
                cadpet.codigo = cod_pet;
                cadpet.carregar_informacoes();
            }
        }

        private void btnnovopet_Click(object sender, EventArgs e)
        {
            cadpet.codigo_cliente = codigocliente;
            cod_pet = 0;
            cadpet.Visible = true;
            cadpet.limparinformações();
        }

        private void btnproximo_Click(object sender, EventArgs e)//quando clica em avançar o sistema verifica se foi cadastrado o cliente para liberar o pet
        {
            cadprop.erronome = "";
            cadprop.btnSalvar_Click();
            if (cadprop.erronome == "")
            {
                MessageBox.Show("Selecione ou  Cadastre um novo Proprietario", "Falta de Informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                pnpet.Visible = true;
                cadpet.codigo_cliente = codigocliente;
                cadpet.carregar_informacoes();
                tabcadatendimento.SelectedIndex = 1;
            }
        }

        private void btnavançarpet_Click(object sender, EventArgs e)
        {
            cadpet.nome_pet = "";
            cadpet.salvardados();

            if (cadpet.nome_pet == "" && tabcadatendimento.SelectedIndex == 1 && cadprop.erronome != "")
            {
                MessageBox.Show("Selecione ou  Cadastre um novo PET", "Falta de Informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }// quando clicar em avançar verifica se o cliente foi salvo com sucesso para liberar o novo atendimento

        private void btnbuscarpet_Click_1(object sender, EventArgs e)
        {
            FormListPet pet = new FormListPet();
            pet.cod_cliente = codigocliente;
            pet.cad_pet = true;
            pet.ShowDialog();
            cod_pet = pet.codigo;
            cadpet.codigo = cod_pet;
            cadpet.carregar_informacoes();
        }

        private void btnnovopet_Click_1(object sender, EventArgs e)
        {
            cadpet.limparinformações();
            cod_pet = 0;
            cadpet.codigo_cliente = codigocliente;
            cadpet.carregar_informacoes();
        }
    }
}
