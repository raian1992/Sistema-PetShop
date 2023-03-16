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
    public partial class FormListServico : Form
    {
        public FormListServico()
        {
            InitializeComponent();
        }

        private void FormListServico_Load(object sender, EventArgs e)
        {
            carregar_informações();
        }
        private void carregar_informações()
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.SERVICO.ToList();
                dgvlistservico.DataSource = new BindingSource(temp, null);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atualizarativo(int codigo, bool ativo)
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.SERVICO.FirstOrDefault(x => x.ID_SERVICO == codigo);
                temp.ATIVO = ativo;
                bd.SaveChanges();
            }
        }

        private void dgvlistservico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (dgvlistservico.Rows.Count > 0)
            {
                int codigo = (int)dgvlistservico.CurrentRow.Cells[1].Value;

                if (e.ColumnIndex == dgvlistservico.Columns["btnEditar"].Index)
                {
                    FormCadServico formCad = new FormCadServico();
                    formCad.codigo = codigo;
                    formCad.ShowDialog();
                    carregar_informações();
                }
                if (e.ColumnIndex == dgvlistservico.Columns["ClmAtivo"].Index)
                {
                    //Reference the GridView Row.
                    DataGridViewRow row = dgvlistservico.Rows[e.RowIndex];

                    //Set the CheckBox selection.
                    //row.Cells["ClmAtivo"].Value = !Convert.ToBoolean(row.Cells["ClmAtivo"].EditedFormattedValue);//buscar a marcação
                    bool ativo = Convert.ToBoolean(row.Cells["ClmAtivo"].Value);
                    // ativo = (bool)dgvlistservico.CurrentRow.Cells[4].Value;
                    if (Convert.ToBoolean(row.Cells["ClmAtivo"].Value) == true && ativo == true)
                    {
                        atualizarativo(codigo, false);
                        carregar_informações();
                    }
                    else
                    {
                        atualizarativo(codigo, true);
                        carregar_informações();

                    }

                }

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormCadServico formCad = new FormCadServico();
            formCad.ShowDialog();
            carregar_informações();
        }
    }
}
