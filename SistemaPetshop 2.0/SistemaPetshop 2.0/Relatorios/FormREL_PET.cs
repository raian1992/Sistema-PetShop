using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0.Relatorios
{
    public partial class FormREL_PET : Form
    {
        public FormREL_PET()
        {
            InitializeComponent();
        }

        static string nome = "b_pessoas_empresa_pet";
        static string sql = "select * from b_pessoas_empresa_pet where id_empresa=" + ClassEmpresa.ID_EMPRESA;
        static string local = "\\prop_pet.xml";
        DataTable table = new DataTable(nome);
        private void FormREL_PET_Load(object sender, EventArgs e)
        {
            table = Escrever_em_Arquivo.criar_xml_tabela(local, sql, nome);
            REL_PET_PROP1.SetDataSource(table);
        }
    }
}
