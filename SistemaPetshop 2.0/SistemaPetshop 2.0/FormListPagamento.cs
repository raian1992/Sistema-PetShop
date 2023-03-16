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
    public partial class FormListPagamento : Form
    {
        public FormListPagamento()
        {
            InitializeComponent();
        }
        string sql = "select ID_PAGAMENTOS, NOME, " +
                     " case when TIPO_PAG = 1 then 'DINHEIRO' " +
                     " when TIPO_PAG = 2 then 'Cheque' " +
                     " when TIPO_PAG = 3 then 'Cartão de Credito' " +
                     " when TIPO_PAG = 4 then 'Cartão de Debito' " +
                     " when TIPO_PAG = 5 then 'Credito Loja' " +
                     " when TIPO_PAG = 10 then 'Vale Alimentação' " +
                     " when TIPO_PAG = 11 then 'Vale Refeição' " +
                     " when TIPO_PAG = 12 then 'Vale Presente' " +
                     " when TIPO_PAG = 13 then 'Vale Combustivel' " +
                     " when TIPO_PAG = 15 then 'Boleto Bancario' " +
                     " when TIPO_PAG = 90 then 'Sem Pagamento' " +
                     " when TIPO_PAG = 99 then 'Outros' " +
                     " end PAGAMENTOS," +
                     " TAXAS.DESCRICAOTX as TAXA," +
                     " PAGAMENTOS.ATIVO " +
                     " from PAGAMENTOS " +
                     " inner join TAXAS on(TAXAS.ID_TAXAS= PAGAMENTOS.ID_TAXAS)";
        private void brnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void carregar_informacoes(string sql_local)
        {
            using (var bd = new LOJA_PETEntities())
            {

                if (bd.PAGAMENTOS.Count() > 0)
                {
                    dgvPagamento.DataSource = new BindingSource(ClassComandoSQL.Retorna_Datatable(sql_local), null);

                }

            }
        }

        private void FormListPagamento_Load(object sender, EventArgs e)
        {
            carregar_informacoes(sql);
        }
        private void ALTERARINFO()
        {
            int codigo = (int)dgvPagamento.CurrentRow.Cells[0].Value;
            //FormCADPET form = new FormCADPET();
            //form.codigo = codigo;
            //form.ShowDialog();
            carregar_informacoes(sql);
        }
        private void atualizarativo(int codigo, bool ativo)
        {
            using (var bd = new LOJA_PETEntities())
            {
                var temp = bd.PAGAMENTOS.FirstOrDefault(x => x.ID_PAGAMENTOS == codigo);
                temp.ATIVO = ativo;
                bd.SaveChanges();
            }
        }

        private void dgvPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPagamento.Rows.Count > 0)
            {
                int codigo = (int)dgvPagamento.CurrentRow.Cells[1].Value;

                if (e.ColumnIndex == dgvPagamento.Columns["ClmEditar"].Index)
                {
                    FormCadPagamento formCad = new FormCadPagamento();
                    formCad.codigo = codigo;
                    formCad.ShowDialog();
                    carregar_informacoes(sql);
                }
                if (e.ColumnIndex == dgvPagamento.Columns["ClmAtivo"].Index)
                {

                    DataGridViewRow row = dgvPagamento.Rows[e.RowIndex];


                    bool ativo = Convert.ToBoolean(row.Cells["ClmAtivo"].Value);

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

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            FormCadPagamento formCad = new FormCadPagamento();
            formCad.ShowDialog();
            carregar_informacoes(sql);
        }
    }
}
