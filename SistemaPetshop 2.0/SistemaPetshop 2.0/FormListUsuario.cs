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
    public partial class FormListUsuario : Form
    {
        public FormListUsuario()
        {
            InitializeComponent();
        }


        private string sql = "select id_usuario, NOME,lOGIN,Email,perfil.DESCRICAO,USUARIOS.ATIVO from USUARIOS " +
                  " inner join  PERFIL on (PERFIL.ID_PERFIL=USUARIOS.ID_PERFIL); ";
        private void carregar_informacoes(string sql_local)
        {
            using (var bd = new LOJA_PETEntities())
            {

                if (bd.USUARIOS.Count() > 0)
                {
                    dgvlistusuario.DataSource = new BindingSource(ClassComandoSQL.Retorna_Datatable(sql_local), null);

                }

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atualizarativo(int codigo, bool ativo)
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.USUARIOS.FirstOrDefault(x => x.Id_USUARIO == codigo);
                temp.ATIVO = ativo;
                bd.SaveChanges();
            }
        }

        private void dgvlistusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (dgvlistusuario.Rows.Count > 0)
            {
                int codigo = (int)dgvlistusuario.CurrentRow.Cells[1].Value;

                if (e.ColumnIndex == dgvlistusuario.Columns["BtnEditar"].Index)
                {
                    FormCadUsuario formCad = new FormCadUsuario();
                    formCad.codigo_usuario = codigo;
                    formCad.ShowDialog();
                    carregar_informacoes(sql);
                }
                if (e.ColumnIndex == dgvlistusuario.Columns["ClmAtivo"].Index)
                {
                    //Reference the GridView Row.
                    DataGridViewRow row = dgvlistusuario.Rows[e.RowIndex];

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

        private void FormListUsuario_Load(object sender, EventArgs e)
        {
            carregar_informacoes(sql);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FormCadUsuario formCad = new FormCadUsuario();
            formCad.ShowDialog();
            carregar_informacoes(sql);
        }

    }
}
