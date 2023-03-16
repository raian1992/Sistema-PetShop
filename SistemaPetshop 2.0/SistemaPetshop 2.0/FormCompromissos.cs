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
    public partial class FormCompromissos : Form
    {
        public FormCompromissos()
        {
            InitializeComponent();
        }
        int id = 0;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void carregadados(int idtemp, string data, string hora, string compromisso, bool concluido)
        {
            txtData.Text = data;
            txtHora.Text = hora;
            txtDescricao.Text = compromisso;
            ckbconcluido.Visible = true;
            ckbconcluido.Checked = concluido;
            id = idtemp;
            carregarusuario();



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var bd = new LOJA_PETEntities())
            {
                Compromissos compromisso;
                try
                {

                    if (id > 0)
                    {
                        compromisso = bd.Compromissos.FirstOrDefault(x => x.Id == id);

                    }
                    else
                    {
                        compromisso = new Compromissos();

                    }

                    compromisso.Data = txtData.Value;
                    compromisso.Hora = TimeSpan.Parse(txtHora.Text);
                    compromisso.Descricao = txtDescricao.Text;
                    compromisso.Concluido = ckbconcluido.Checked;
                    //carregarusuario();

                    if (cbxusuario.Text != "" && cbxusuario.Text != "NENHUM")
                    {
                        compromisso.USUARIO_P_COMP = (Int32)cbxusuario.SelectedValue;
                    }
                    if (id == 0)
                    {
                        compromisso.USUARIO_CRIOU_COMP = ClassUSUARIO.ID_USUARIO;
                        bd.Compromissos.Add(compromisso);

                    }
                    bd.SaveChanges();

                    MessageBox.Show("Compromisso Salvo com sucesso!",
                                    "Informação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar compromisso!",
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                }

                this.Close();


            }
        }
        private void FormCompromissos_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                ckbconcluido.Checked = false;
                carregarusuario();
            }

        }

        private void carregarusuario()
        {

            string sql = "select 0 ID_usuario, 'NENHUM' NOME, lOGIN,SENHA,CONTRA_SENHA,EMAIL,ID_PERFIL,ATIVO FROM USUARIOS WHERE Id_USUARIO=(SELECT  MIN (ID_USUARIO ) FROM USUARIOS) " +

                        " UNION ALL" +
                        " select* from USUARIOS ";
            DataTable table = new DataTable();
            table = ClassComandoSQL.Retorna_Datatable(sql);
            cbxusuario.DataSource = new BindingSource(table, null);
            using (var bd = new LOJA_PETEntities())
            {
                if (id != 0)
                {
                    var comp = bd.Compromissos.FirstOrDefault(x => x.Id == id);
                    if (comp.USUARIO_P_COMP.GetValueOrDefault(0) != 0 && comp.Descricao != "")
                    {
                        cbxusuario.SelectedValue = comp.USUARIO_P_COMP;
                    }

                }

            }

        }

    }
}
