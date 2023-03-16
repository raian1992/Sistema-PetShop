using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
{
    class ClassCompromissos
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public string Descricao { get; set; }

        public char Concluido { get; set; }

        static ConnectionStringSettings connection = ConfigurationManager.ConnectionStrings["LOJA_PETEntities"];
        private static string[] subs, srv, banco, usuario, senha;
        static string bd, usu, psw, server, conectionstring;
        private static void carregardadosbanco()
        {
            string teste = connection.ConnectionString.ToString();
            subs = teste.Split(';');
            //connection.CurrentConfiguration.Save();
            srv = subs[2].Split('=');
            banco = subs[3].Split('=');
            usuario = subs[4].Split('=');
            senha = subs[5].Split('=');
            usu = usuario[1];
            psw = senha[1];
            server = srv[2];
            bd = banco[1];
        }


        public SqlConnection Conectar()
        {

            if (usu == "" && psw == "")
            {
                return new SqlConnection("Data Source=" + server + " ;Initial Catalog=" + banco + ";"
       + "Integrated Security=true;");
                conectionstring = "Data Source=" + server + " ;Initial Catalog=" + banco + ";"
       + "Integrated Security=true;";
            }

            else
            {
                return new SqlConnection(@"Server= " + server + " ;Database=" + banco +
                    ";User Id=" + usu + "; Password=" +
                                        psw + ";");
                conectionstring = @"Server= " + server + " ;Database=" + banco +
                    ";User Id=" + usu + "; Password=" +
                                        psw + ";";
            }


        }
        public static List<Compromissos> Listar(DateTime? Data = null)
        {
            ClassCompromissos.carregardadosbanco();
            using (SqlConnection conexao = new SqlConnection())
            {
                conexao.ConnectionString = conectionstring;

                string textoComando;

                textoComando = " SELECT Id           " +
                "       ,Data         " +
                "       ,Hora         " +
                "       ,Descricao    " +
                "       ,Concluido    " +
                "   FROM Compromissos ";

                if (Data != null)
                {
                    textoComando += " WHERE format (Data, 'dd/MM/yyyy')= '" + Data.Value.Date.ToString("dd/MM/yyyy") + "';";
                }

                SqlCommand comando = new SqlCommand(textoComando.ToString(), conexao);

                if (Data != null)
                {
                    comando.Parameters.Add("Data", SqlDbType.Date).Value = Data;
                }
                if (conexao.State.ToString() == "Closed")
                {
                    conexao.Open();
                }

                SqlDataReader leitor = comando.ExecuteReader();

                List<Compromissos> lista = new List<Compromissos>();

                while (leitor.Read())
                {
                    Compromissos compromissos = new Compromissos();
                    compromissos.Id = int.Parse(leitor["Id"].ToString());
                    compromissos.Hora = TimeSpan.Parse(leitor["Hora"].ToString());
                    compromissos.Data = DateTime.Parse(leitor["Data"].ToString());
                    compromissos.Descricao = leitor["Descricao"].ToString();                   
                    compromissos.Concluido = Convert.ToBoolean(leitor["Concluido"].ToString());
                


                    lista.Add(compromissos);
                }
                conexao.Close();
                return lista;
            }
        }

        public static void ConcluirCompromisso(int Id)
        {
            using (SqlConnection conexao = new SqlConnection())
            {
                conexao.ConnectionString = conectionstring;

                StringBuilder textoComando = new StringBuilder();

                textoComando.Append(" UPDATE Compromissos    ");
                textoComando.Append("    SET Concluido = '1' ");
                textoComando.Append("  WHERE Id = @Id        ");

                SqlCommand comando = new SqlCommand(textoComando.ToString(), conexao);
                comando.Parameters.Add("Id", SqlDbType.Int).Value = Id;

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public static void VerificaCompromissos()
        {
            using (SqlConnection conexao = new SqlConnection())
            {

                conexao.ConnectionString = conexao.ConnectionString = conectionstring;

                StringBuilder textoComando = new StringBuilder();

                textoComando.Append(" SELECT Id              ");
                textoComando.Append("       ,Descricao       ");
                textoComando.Append("   FROM Compromissos    ");
                textoComando.Append("  WHERE Data = @Data    ");
                textoComando.Append("    AND Hora = @Hora    ");
                textoComando.Append("    AND Concluido = '1' ");

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = textoComando.ToString();

                comando.Parameters.Add("Data", SqlDbType.Date).Value = DateTime.Now.Date;
                comando.Parameters.Add("Hora", SqlDbType.Time).Value = DateTime.Now.ToShortTimeString(); ;

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader();

                string lembrete = "";

                while (leitor.Read())
                {
                    if (lembrete != "")
                    {
                        lembrete = lembrete + "\n";
                    }

                    lembrete = lembrete + leitor["Descricao"].ToString();
                    //ConcluirCompromisso(int.Parse(leitor["Id"].ToString()));
                }
                conexao.Close();
                if (lembrete != "")
                {

                    MessageBox.Show(lembrete.ToString(),
                                    "Lembrete",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
                }
            }

        }

        //public static void AtualizarCompromisso(int id, string concluido)
        //{
        //    using (SqlConnection conexao = ClassComandoSQL.conn)
        //    {
        //        StringBuilder textoComando = new StringBuilder();

        //        textoComando.Append("UPDATE Compromissos SET ");
        //        textoComando.Append("           Data =@Data   ");
        //        textoComando.Append("           ,Hora=@Hora   ");
        //        textoComando.Append(" ,Descricao=@Descricao   ");
        //        textoComando.Append("    ,Concluido=@concluido ");
        //        textoComando.Append(" WHERE ID=@id");

        //        SqlCommand comando = new SqlCommand(textoComando.ToString(), conexao);
        //        comando.Parameters.Add("Data", SqlDbType.Date).Value = this.Data;
        //        comando.Parameters.Add("Hora", SqlDbType.Time).Value = ClassCompromissos.Hora;
        //        comando.Parameters.Add("Descricao", SqlDbType.VarChar).Value = ClassCompromissos.Descricao;
        //        comando.Parameters.Add("Concluido", SqlDbType.VarChar).Value = concluido;
        //        comando.Parameters.Add("id", SqlDbType.Int).Value = id;

        //        conexao.Open();
        //        comando.ExecuteNonQuery();
        //        conexao.Close();
        //    }
        //}
        ////public void Gravar()
        //{
        //    using (SqlConnection conexao = ClassComandoSQL.conn)
        //    {
        //        StringBuilder textoComando = new StringBuilder();

        //        textoComando.Append("INSERT INTO Compromissos");
        //        textoComando.Append("           (Data        ");
        //        textoComando.Append("           ,Hora        ");
        //        textoComando.Append("           ,Descricao   ");
        //        textoComando.Append("           ,Concluido)  ");
        //        textoComando.Append("     VALUES             ");
        //        textoComando.Append("           (@Data       ");
        //        textoComando.Append("           ,@Hora       ");
        //        textoComando.Append("           ,@Descricao  ");
        //        textoComando.Append("           ,'N')        ");

        //        SqlCommand comando = new SqlCommand(textoComando.ToString(), conexao);
        //        comando.Parameters.Add("Data", SqlDbType.Date).Value = ClassCompromissos.Data;
        //        comando.Parameters.Add("Hora", SqlDbType.Time).Value = ClassCompromissos.Hora;
        //        comando.Parameters.Add("Descricao", SqlDbType.VarChar).Value = ClassCompromissos.Descricao;

        //        conexao.Open();
        //        comando.ExecuteNonQuery();
        //        conexao.Close();
        //    }
        //}
    }
}
