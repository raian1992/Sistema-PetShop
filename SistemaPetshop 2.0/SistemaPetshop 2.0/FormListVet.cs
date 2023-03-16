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
    public partial class FormListVet : Form
    {
        public FormListVet()
        {
            InitializeComponent();
            dgvlistvet.AutoGenerateColumns = false;
        }

        private string sql = "select ID_VET,NOME_VET,CPF,CRMV,TELEFONE,CELULAR, " +
                         "case when ATIVO = 1 then 'ATIVO' else 'INATIVO' end ATIVO from Veterinarios";
        private void FormListVet_Load(object sender, EventArgs e)
        {
            informacoes_iniciais();


        }
        private void informacoes_iniciais()
        {
            using (var bd = new LOJA_PETEntities())
            {
                dgvlistvet.DataSource = new BindingSource(bd.Veterinarios.ToList(), null);
               // dgvlistvet.DataSource = new BindingSource(ClassComandoSQL.Retorna_Datatable(sql), null);
            }

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FormVet vet = new FormVet();
            vet.ShowDialog();
            informacoes_iniciais();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ALTERAR_INFORMACAO()
        {
            int codigo = (int)dgvlistvet.CurrentRow.Cells[0].Value;
            FormVet vet = new FormVet();
            vet.codigo = codigo;
            vet.ShowDialog();
            informacoes_iniciais();
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            int codigo = (int)dgvlistvet.CurrentRow.Cells[0].Value;
            using (var bd = new LOJA_PETEntities())
            {
                var vet = bd.Veterinarios.FirstOrDefault(x => x.ID_VET == codigo);
                if (vet.ATIVO == true)
                {
                    vet.ATIVO = false;
                    bd.SaveChanges();
                    informacoes_iniciais();
                }
                else
                {
                    MessageBox.Show("Veterinario(a) ja inativo(a)!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void atualizarativo(int codigo, bool ativo)
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.Veterinarios.FirstOrDefault(x => x.ID_VET == codigo);
                temp.ATIVO = ativo;
                bd.SaveChanges();
            }
        }
        private void dgvlistvet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvlistvet.Rows.Count > 0)
            {
                int codigo = (int)dgvlistvet.CurrentRow.Cells[0].Value;

                if (e.ColumnIndex == dgvlistvet.Columns["btneditar"].Index)
                {
                    FormVet formCad = new FormVet();
                    formCad.codigo = codigo;
                    formCad.ShowDialog();
                    informacoes_iniciais();
                }
                if (e.ColumnIndex == dgvlistvet.Columns["chkativo"].Index)
                {
                    //Reference the GridView Row.
                    DataGridViewRow row = dgvlistvet.Rows[e.RowIndex];

                    bool ativo = Convert.ToBoolean(row.Cells["chkativo"].Value);
                    // ativo = (bool)dgvlistservico.CurrentRow.Cells[4].Value;
                    if (Convert.ToBoolean(row.Cells["chkativo"].Value) == true && ativo == true)
                    {
                        atualizarativo(codigo, false);
                        informacoes_iniciais();
                    }
                    else
                    {
                        atualizarativo(codigo, true);
                        informacoes_iniciais();

                    }

                }
            }
        }

        private void FormListVet_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClassInfTemp.listveterinario = false;
        }
    }
}
