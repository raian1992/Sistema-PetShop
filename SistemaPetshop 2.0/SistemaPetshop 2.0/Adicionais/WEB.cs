using System;
using System.Data;
using System.Net;
using System.Xml;
using System.Net;

namespace SistemaPetshop_2._0.Adicionais
{
    class WEB
    {
        public static int IsConnected()
        {
            int fail;

            System.Uri Url = new System.Uri("https://www.google.com"); //é sempre bom por um site que costuma estar sempre on, para n haver problemas

            WebRequest WebReq;
            WebResponse Resp;
            WebReq = WebRequest.Create(Url);
            WebReq.Timeout = 22000;// time out 22 milisegundos

            try
            {
                Resp = WebReq.GetResponse();
                Resp.Close();
                WebReq = null;
                fail = 0; //consegue conexão à internet
                return fail;
            }

            catch
            {
                //  MessageBox.Show("Não existe nenhuma ligação à internet.\n\nLiga-te à internet e tenta de novo.", "Erro de ligação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WebReq = null;
                fail = 1; //falhou a conexão à internet
                return fail;
            }
        }



        public static DataSet Consultacorreios_REPUBLICACEP(string cep)
        {
            DataSet ds = new DataSet();
            try
            {
                HttpWebRequest requisicao = WebRequest.Create("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep + "&formato=xml") as HttpWebRequest;
                HttpWebResponse resposta = requisicao.GetResponse() as HttpWebResponse;
                //int cont;
                requisicao.Timeout = 1000;
                XmlTextReader reader = new XmlTextReader(resposta.GetResponseStream());

                ds.ReadXml(reader);
            }
            catch (Exception)
            {

                ds.Tables.Clear();
            }


            return ds;
        }

        public static DataSet Consultacorreios_VIACEP(string cep)
        {
            DataSet ds = new DataSet();
            try
            {
                HttpWebRequest requisicao = WebRequest.Create("https://viacep.com.br/ws/" + cep + "/xml/") as HttpWebRequest;
                HttpWebResponse resposta = requisicao.GetResponse() as HttpWebResponse;
                //int cont;
                requisicao.Timeout = 1000;
                XmlTextReader reader = new XmlTextReader(resposta.GetResponseStream());

                ds.ReadXml(reader);
            }
            catch (Exception)
            {

                ds.Tables.Clear();
            }


            return ds;
        }



    }
}
