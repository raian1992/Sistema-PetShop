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
    public partial class FormListTaxas : Form
    {
        public FormListTaxas()
        {
            InitializeComponent();
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carregar_informações()
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.TAXAS.ToList();
                dgvTaxas.DataSource = new BindingSource(temp, null);
            }
        }

        private void FormListTaxas_Load(object sender, EventArgs e)
        {
            carregar_informações();
        }

        private void atualizarativo(int codigo, bool ativo)
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.TAXAS.FirstOrDefault(x => x.ID_TAXAS == codigo);
                temp.ATIVO = ativo;
                bd.SaveChanges();
            }
        }

        private void atualizarPdividr(int codigo, bool Pdividir)
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.TAXAS.FirstOrDefault(x => x.ID_TAXAS == codigo);
                temp.P_DIV = Pdividir;
                bd.SaveChanges();
            }
        }

        private void dgvTaxas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTaxas.Rows[e.RowIndex];
            //Check to ensure that the row CheckBox is clicked.
            if (dgvTaxas.Rows.Count > 0)
            {
                int codigo = (int)dgvTaxas.CurrentRow.Cells[2].Value;

                if (e.ColumnIndex == dgvTaxas.Columns["btnEditar"].Index)
                {
                    FormCadTaxas formCad = new FormCadTaxas();
                    formCad.id_taxa = codigo;
                    formCad.ShowDialog();
                    carregar_informações();
                }

                if (e.ColumnIndex == dgvTaxas.Columns["ClmAtivo"].Index)
                {
                    

                    bool ativo = Convert.ToBoolean(row.Cells["ClmAtivo"].Value);
                    
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

                if (e.ColumnIndex == dgvTaxas.Columns["ClmP_DIVIDIR"].Index)
                {
                    //DataGridViewRow row = dgvTaxas.Rows[e.RowIndex];

                    bool Pdivid = Convert.ToBoolean(row.Cells["ClmP_DIVIDIR"].Value);
                    
                    if (Convert.ToBoolean(row.Cells["ClmP_DIVIDIR"].Value) == true && Pdivid == true)
                    {
                        atualizarPdividr(codigo, false);
                        carregar_informações();
                    }
                    else
                    {
                        atualizarPdividr(codigo, true);
                        carregar_informações();

                    }

                }

            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            FormCadTaxas formCad = new FormCadTaxas();
            formCad.ShowDialog();
            carregar_informações();
        }
    }
}
