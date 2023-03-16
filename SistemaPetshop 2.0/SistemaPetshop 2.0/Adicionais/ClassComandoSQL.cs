using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SistemaPetshop_2._0
{

    class ClassComandoSQL
    {
        public static SqlConnection conn = new SqlConnection();
        private static SqlCommand cmd = new SqlCommand();
        private static SqlTransaction transaction;
        static ConnectionStringSettings connection = ConfigurationManager.ConnectionStrings["LOJA_PETEntities"];
        private static string[] subs, srv, banco, usuario, senha;
        public static string bd, usu, psw, server;
        private static void carregardadosbanco()
        {
            string teste = connection.ConnectionString.ToString();
            subs = teste.Split(';');
            srv = subs[2].Split('=');
            banco = subs[3].Split('=');
            usuario = subs[4].Split('=');
            senha = subs[5].Split('=');
            usu = usuario[1];
            psw = senha[1];
            server = srv[2];
            bd = banco[1];
        }


        public static SqlConnection Conectar()
        {

            if (usu == "" && psw == "")
            {
                return new SqlConnection("Data Source=" + server + " ;Initial Catalog=" + banco[1] + ";"
       + "Integrated Security=true;");
                conn.ConnectionString = "Data Source=" + server + " ;Initial Catalog=" + banco[1] + ";"
       + "Integrated Security=true;";
            }

            else
            {
                return new SqlConnection(@"Server= " + server + " ;Database=" + banco[1] +
                    ";User Id=" + usu + "; Password=" +
                                        psw + ";");
                conn.ConnectionString = @"Server= " + server + " ;Database=" + banco[1] +
                    ";User Id=" + usu + "; Password=" +
                                        psw + ";";
            }


        }


        public static DataTable Retorna_Datatable(string comandosql)
        {
            DataTable table = new DataTable("TABLE");
            try
            {
                carregardadosbanco();
                cmd.Connection = conn;
                cmd.CommandText = comandosql;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);

            }
            catch (SqlException)
            {

                table = null;
            }
            conn.Close();
            return table;

        }


        public static void atualiza_empresas_p_inativa(int qtde)
        {
            carregardadosbanco();
            string comandosql = "update empresa set ativo=0 where id_empresa not in ( select top" + qtde + " (id_empresa) from empresa where ativo=1);";
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comandosql;
                conn.Open();
                cmd.ExecuteNonQuery();
                transaction = conn.BeginTransaction();

            }
            catch (SqlException)
            {

                throw;
            }
            conn.Close();
        }

        public static void atualiza_config_dt_val(DateTime data_final)
        {
            carregardadosbanco();
            string comandosql = "update config set DT_VAL=" + data_final + ";";
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = comandosql;
                conn.Open();
                cmd.ExecuteNonQuery();
                transaction = conn.BeginTransaction();

            }
            catch (SqlException)
            {

                throw;
            }
            conn.Close();
        }


        public static bool backup_banco()
        {
            bool retorno;
            string sql = "BACKUP DATABASE [" + bd + "] TO  DISK = N'C:\\LojaPet\\backup\\" + bd + "-" + DateTime.Now.Date.ToString("dd-MM-yyyy") + ".bak' WITH NOFORMAT, INIT, " +
                " NAME = N'LOJA_PET-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10, CHECKSUM";
            try
            {
                if (!Directory.Exists(@"C:\\LojaPet\\backup"))
                {
                    Directory.CreateDirectory(@"C:\\LojaPet\\backup");
                }

                conn = Conectar();

                cmd.Connection = conn;
                cmd.CommandText = sql;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                retorno = true;
            }
            catch (Exception)
            {
                conn.Close();
                retorno = false;
            }
            return retorno;
        }
    }
}
