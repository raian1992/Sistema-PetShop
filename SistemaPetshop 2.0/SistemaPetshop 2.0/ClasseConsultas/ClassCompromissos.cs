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
        public int USUARIO_CRIOU_COMP { get; set; }

        public int USUARIO_P_COMP { get; set; }

        public char Concluido { get; set; }


        public static List<Compromissos> Listar(DateTime? Data = null)
        {

            using (SqlConnection conexao = ClassComandoSQL.Conectar())
            {

                string textoComando;

                textoComando = " SELECT Id           " +
                "       ,Data         " +
                "       ,Hora         " +
                "       ,Descricao    " +
                "       ,USUARIO_CRIOU_COMP    " +
                "       ,USUARIO_P_COMP  " +
                "       ,Concluido    " +
                "   FROM Compromissos where USUARIO_P_COMP=' " + ClassUSUARIO.ID_USUARIO + "'";
                if (Data != null)
                {
                    textoComando += " AND format (Data, 'dd/MM/yyyy')= '" + Data.Value.Date.ToString("dd/MM/yyyy") + "' ";
                }

                textoComando += " union all ";

                textoComando += " SELECT Id           " +
                "       ,Data         " +
                "       ,Hora         " +
                "       ,Descricao    " +
                "       ,USUARIO_CRIOU_COMP    " +
                "       ,USUARIO_P_COMP  " +
                "       ,Concluido    " +
                "   FROM Compromissos  where coalesce(USUARIO_P_COMP ,0)=0 ";
                if (Data != null)
                {
                    textoComando += " and format (Data, 'dd/MM/yyyy')= '" + Data.Value.Date.ToString("dd/MM/yyyy") + "';";
                }

                SqlCommand comando = new SqlCommand(textoComando.ToString(), conexao);

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
                    compromissos.USUARIO_CRIOU_COMP = int.Parse(leitor["USUARIO_CRIOU_COMP"].ToString());
                    if (leitor["USUARIO_P_COMP"].ToString().Count() > 0)
                    {
                        compromissos.USUARIO_P_COMP = int.Parse(leitor["USUARIO_P_COMP"].ToString());
                    }
                    compromissos.Concluido = Convert.ToBoolean(leitor["Concluido"].ToString());
                    lista.Add(compromissos);
                }
                conexao.Close();
                return lista;
            }
        }

        public static void ConcluirCompromisso(int Id)
        {
            using (SqlConnection conexao = ClassComandoSQL.Conectar())
            {
                StringBuilder textoComando = new StringBuilder();

                textoComando.Append(" UPDATE Compromissos    ");
                textoComando.Append(" SET Concluido = '1'    ");
                textoComando.Append(" WHERE Id = @Id         ");

                SqlCommand comando = new SqlCommand(textoComando.ToString(), conexao);
                comando.Parameters.Add("Id", SqlDbType.Int).Value = Id;

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public static void VerificaCompromissos()
        {
            using (SqlConnection conexao = ClassComandoSQL.Conectar())
            {

                StringBuilder textoComando = new StringBuilder();

                textoComando.Append(" SELECT Id            ");
                textoComando.Append(" ,Descricao           ");
                textoComando.Append("  FROM Compromissos   ");
                textoComando.Append("  WHERE Data = @Data  ");
                textoComando.Append("  AND Hora = @Hora    ");
                textoComando.Append("  AND Concluido = '1' ");

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

        public static int quantidadecomp(DateTime Data)
        {

            using (SqlConnection conexao = ClassComandoSQL.Conectar())
            {
                int retorno = 0;
                string textoComando;

                textoComando = " SELECT COUNT(*) FROM COMPROMISSOS WHERE CONCLUIDO ='0' AND  format (Data, 'dd/MM/yyyy')= '" + Data.Date.ToString("dd/MM/yyyy") + "'and coalesce(USUARIO_P_COMP ,0)=0 or coalesce(USUARIO_P_COMP ,0)='" + ClassUSUARIO.ID_USUARIO + "';";

                SqlCommand comando = new SqlCommand(textoComando.ToString(), conexao);

                if (conexao.State.ToString() == "Closed")
                {
                    conexao.Open();
                }

                SqlDataReader leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    retorno = int.Parse(leitor[0].ToString());
                }
                conexao.Close();
                return retorno;
            }
        }

    }
}
