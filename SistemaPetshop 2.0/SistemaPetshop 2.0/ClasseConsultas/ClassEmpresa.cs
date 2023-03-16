using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
{
    class ClassEmpresa
    {
        public static int ID_EMPRESA;

        public static int Qtde_Empresa;
        private static DataTable table_empresa = new DataTable();
        public static DataTable BuscaEmpresaListagem()
        {
            using (var bd = new LOJA_PETEntities())
            {
                string sql = ("SELECT  ID_EMPRESA ,CNPJ_CPF, FANTASIA, " +
                                               "CASE  WHEN ATIVO = 1 THEN 'ATIVO'" +
                                               "WHEN ATIVO = 0 THEN 'INATIVO'" +
                                               "END 'STATUS'" +
                                               "FROM EMPRESA");
                table_empresa = ClassComandoSQL.Retorna_Datatable(sql);

            }

            return table_empresa;
        }

        public static DataTable BuscaEmpresaUSUARIO()
        {
            using (var bd = new LOJA_PETEntities())
            {
                string sql = ("select EMPRESA.* from EMPRESA " +
                              "inner join EMPRESA_USUARIO on(EMPRESA.ID_EMPRESA= EMPRESA_USUARIO.ID_EMPRESA) " +
                              "inner join USUARIOS on(EMPRESA_USUARIO.ID_USUARIO= USUARIOS.Id_USUARIO) " +
                              "where USUARIOS.Id_USUARIO= " + ClassUSUARIO.ID_USUARIO + ";");
                table_empresa = ClassComandoSQL.Retorna_Datatable(sql);

            }

            return table_empresa;
        }

    }
}
