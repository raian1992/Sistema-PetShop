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
    public partial class FormListProprietario : Form
    {
        public FormListProprietario()
        {
            InitializeComponent();
            DGVLISTPROPRI.AutoGenerateColumns = false;
        }
        public bool prp_pet = false;
        public int codigo = 0;

        private string sql = "select ID_PROPRIETARIO, NOME_PROPRIETARIO, FIXO, CELULAR, CIDADE,ESTADO," +
                             " proprietarios.ATIVO  from proprietarios";
        private void FormListProprietario_Load(object sender, EventArgs e)
        {
            carregar_informacoes(sql);
        }
        private void carregar_informacoes(string sql_local)
        {
            using (var bd = new LOJA_PETEntities())
            {

                if (bd.PROPRIETARIOS.Count() > 0 && prp_pet == false)
                {
                    DGVLISTPROPRI.DataSource = new BindingSource(ClassComandoSQL.Retorna_Datatable(sql_local), null);
                    DGVLISTPROPRI.Columns["BTNEDITAR"].Visible = true;
                    DGVLISTPROPRI.Columns["CHKATIVO"].Visible = true;

                }

                if (prp_pet == true && bd.PROPRIETARIOS.Count() > 0)
                {
                    DGVLISTPROPRI.DataSource = new BindingSource(ClassComandoSQL.Retorna_Datatable(sql_local+" where ativo <> '0' "), null);
                    btnIncluir.Text = "SELECIONAR";
                    DGVLISTPROPRI.Columns["BTNEDITAR"].Visible = false;
                    DGVLISTPROPRI.Columns["CHKATIVO"].Visible = false;
                }
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (prp_pet == false && btnIncluir.Text == "Adicionar")
            {
                FormcadProp prop = new FormcadProp();
                prop.ShowDialog();
                carregar_informacoes(sql);
            }
            else
            {
                codigo = (int)DGVLISTPROPRI.CurrentRow.Cells[0].Value;
                this.Close();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ALTERARINFORMACOES();
        }

        private void ALTERARINFORMACOES()
        {
            int codigo = (int)DGVLISTPROPRI.CurrentRow.Cells[0].Value;
            FormcadProp prop = new FormcadProp();
            prop.codigo = codigo;
            prop.ShowDialog();
            carregar_informacoes(sql);
        }

        private void btnbusca_Click(object sender, EventArgs e)
        {
            string sqlnovo = "";
            if (txtbusca.Text != "")
            {
                switch (cbxcampobusca.Text)
                {
                    case "NOME":
                        sqlnovo = sql + " where nome_proprietario like ('%" + txtbusca.Text + "%')";

                        break;
                    case "TELEFONE":
                        sqlnovo = sql + " where fixo ='" + txtbusca.Text + "';";

                        break;
                    case "CELULAR":
                        sqlnovo = sql + " where celular ='" + txtbusca.Text + "';";

                        break;
                    case "NOME DO PET":
                        sqlnovo = sql + " LEFT JOIN PETS ON(PROPRIETARIOS.ID_PROPRIETARIO = PETS.COD_CLIENTE)" + " where NOME_PET like('%" + txtbusca.Text + "%');";

                        break;
                    default:
                        sqlnovo = sql;
                        break;

                }
                carregar_informacoes(sqlnovo);
            }
            else
            {
                carregar_informacoes(sql);
            }
        }

        private void DGVLISTPROPRI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGVLISTPROPRI.Rows[e.RowIndex];
            //ALTERARINFORMACOES();
            //Check to ensure that the row CheckBox is clicked.
            if (DGVLISTPROPRI.Rows.Count > 0)
            {
                int codigo = (int)row.Cells["COD"].Value;

                if (e.ColumnIndex == DGVLISTPROPRI.Columns["BTNEDITAR"].Index)
                {
                    FormcadProp formCad = new FormcadProp();
                    formCad.codigo = codigo;
                    formCad.ShowDialog();
                    carregar_informacoes(sql);
                }
                if (e.ColumnIndex == DGVLISTPROPRI.Columns["CHKATIVO"].Index)
                {
                    //Reference the GridView Row.


                    //Set the CheckBox selection.
                    //row.Cells["ClmAtivo"].Value = !Convert.ToBoolean(row.Cells["ClmAtivo"].EditedFormattedValue);//buscar a marcação
                    bool ativo = Convert.ToBoolean(row.Cells["CHKATIVO"].Value);
                    // ativo = (bool)dgvlistservico.CurrentRow.Cells[4].Value;
                    if (Convert.ToBoolean(row.Cells["CHKATIVO"].Value) == true && ativo == true)
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

        private void FormListProprietario_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClassInfTemp.listproprietario = false;
        }
        private void atualizarativo(int codigo, bool ativo)
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.PROPRIETARIOS.FirstOrDefault(x => x.ID_PROPRIETARIO == codigo);
                temp.ATIVO = ativo;
                bd.SaveChanges();
            }
        }
    }
}
