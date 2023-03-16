using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaPetshop_2._0.Relatorios
{
    public partial class FormREL_PROP : Form
    {
        public FormREL_PROP()
        {
            InitializeComponent();
        }
        static string nome = "b_pessoas_empresa";
        static string sql = "select * from b_pessoas_empresa where id_empresa=" + ClassEmpresa.ID_EMPRESA;
        static string local = "\\prop.xml";
        DataTable table = new DataTable(nome);


        private void FormREL_PROP_Load(object sender, EventArgs e)
        {
            table = Escrever_em_Arquivo.criar_xml_tabela(local, sql, nome);
            Rel_cad_prop1.SetDataSource(table);

        }
    }
}
