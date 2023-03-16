using SistemaPetshop_2._0.Adicionais;
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
    public partial class FormListPet : Form
    {
        public FormListPet()
        {
            InitializeComponent();
            DGVLISTPET.AutoGenerateColumns = false;
        }
        public bool cad_pet = false;
        public int codigo = 0;
        public int cod_cliente;
        private void carregar_informações()
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.PETS.ToList();
                DGVLISTPET.DataSource = new BindingSource(temp, null);
            }
        }// não esta sendo utilizado


        public string sql = "select ID_PET,NOME_PET, NOME_PROPRIETARIO, CASE WHEN COALESCE(ESPECIE_PET,'SRD')='' THEN 'SRD' ELSE ESPECIE_PET END  ESPECIE_PET," +
                  " PETS.ATIVO" +
            " from PETS INNER JOIN PROPRIETARIOS ON(PROPRIETARIOS.ID_PROPRIETARIO = PETS.COD_CLIENTE) ";
        private void carregar_informacoes(string sql_local)
        {

            using (var bd = new LOJA_PETEntities())
            {

                if (bd.PETS.Count() > 0 && cad_pet == false)
                {
                    DGVLISTPET.DataSource = new BindingSource(ClassComandoSQL.Retorna_Datatable(sql_local), null);
                    DGVLISTPET.Columns["BtnEditar"].Visible = true;
                    DGVLISTPET.Columns["ClmAtivo"].Visible = true;

                }

                if (cad_pet == true && bd.PETS.Count() > 0)
                {
                    DGVLISTPET.DataSource = new BindingSource(ClassComandoSQL.Retorna_Datatable(sql_local + " where PETS.ativo <> '0' and cod_cliente='" + cod_cliente + "'; "), null);
                    btnIncluir.Text = "SELECIONAR";
                    DGVLISTPET.Columns["BtnEditar"].Visible = false;
                    DGVLISTPET.Columns["ClmAtivo"].Visible = false;
                    grbcliente.Enabled = false;
                }
            }



        }


        private void FormListPet_Load(object sender, EventArgs e)
        {
            carregar_informacoes(sql);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ALTERARINFO();
        }

        private void ALTERARINFO()
        {
            int codigo = (int)DGVLISTPET.CurrentRow.Cells[0].Value;
            FormCADPET form = new FormCADPET();
            form.codigo = codigo;
            form.ShowDialog();
            carregar_informacoes(sql);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (cad_pet == false && btnIncluir.Text == "Adicionar")
            {
                FormCADPET form = new FormCADPET();
                form.ShowDialog();
                carregar_informacoes(sql);
            }
            else
            {
                codigo = (int)DGVLISTPET.CurrentRow.Cells[0].Value;
                this.Close();
            }
        }

        private void DGVLISTPET_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ALTERARINFO();
        }

        private void btnbusca_Click(object sender, EventArgs e)
        {
            string sql_novo;
            if (cbxcampobusca.Text != "")
            {
                switch (cbxcampobusca.Text)
                {
                    case "NOME_PET":
                        sql_novo = sql + " where NOME_PET like ('%" + txtbusca.Text + "%');";


                        break;
                    case "NOME_PROPRIETARIO":
                        sql_novo = sql + " where NOME_PROPRIETARIO like ('%" + txtbusca.Text + "%');";

                        break;

                    case "ESPECIE":
                        sql_novo = sql + " where ESPECIE_PET like ('%" + txtbusca.Text + "%');";

                        break;
                    default:
                        sql_novo = sql;

                        break;
                }
                carregar_informacoes(sql_novo);
            }
            else
            {
                carregar_informacoes(sql);
            }
        }

        private void FormListPet_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClassInfTemp.listpet = false;
        }




        private void atualizarativo(int codigo, bool ativo)
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.PETS.FirstOrDefault(x => x.ID_PET == codigo);
                temp.ATIVO = ativo;
                bd.SaveChanges();
            }
        }


        private void DGVLISTPET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (DGVLISTPET.Rows.Count > 0)
            {
                int codigo = (int)DGVLISTPET.CurrentRow.Cells[0].Value;

                if (e.ColumnIndex == DGVLISTPET.Columns["BtnEditar"].Index)
                {
                    FormCADPET formCad = new FormCADPET();
                    formCad.codigo = codigo;
                    formCad.ShowDialog();
                    carregar_informacoes(sql);
                }
                if (e.ColumnIndex == DGVLISTPET.Columns["ClmAtivo"].Index)
                {
                    //Reference the GridView Row.
                    DataGridViewRow row = DGVLISTPET.Rows[e.RowIndex];

                    //Set the CheckBox selection.
                    //row.Cells["ClmAtivo"].Value = !Convert.ToBoolean(row.Cells["ClmAtivo"].EditedFormattedValue);//buscar a marcação
                    bool ativo = Convert.ToBoolean(row.Cells["ClmAtivo"].Value);
                    // ativo = (bool)dgvlistservico.CurrentRow.Cells[4].Value;
                    if (Convert.ToBoolean(row.Cells["ClmAtivo"].Value) == true && ativo == true)
                    {
                        atualizarativo(codigo, false);
                        carregar_informacoes(sql);
                    }
                    else
                    {
                        atualizarativo(codigo, true);
                        carregar_informacoes(sql);

                    }
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
