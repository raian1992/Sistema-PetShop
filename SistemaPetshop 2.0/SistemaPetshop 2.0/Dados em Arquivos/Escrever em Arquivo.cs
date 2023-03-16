using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaPetshop_2._0
{
    class Escrever_em_Arquivo
    {

        public static void EscreverArquivo(string Mensagem, string metodo)
        {
            string Diretorio_erro = @"C:\LOJAPET\ERRO";

            try
            {
                if (Directory.Exists(Diretorio_erro) != true)
                {
                    Directory.CreateDirectory(Diretorio_erro);
                }
                // StreamWriter escrever = new StreamWriter(@"c:\diretorio\nome " + " " + metodo + data + ".txt");  nao ha suporte para esse tipo de arquivo
                string teste;
                StreamWriter escrever;
                if (metodo == "itens nao inseridos")
                {

                    teste = Diretorio_erro + "\\ERRO   " + metodo + " " + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                    if (File.Exists(teste) == true)
                    {
                        escrever = File.AppendText(teste);
                        // escrever.WriteLine("Método " + metodo);
                        escrever.WriteLine(Mensagem);
                        escrever.Close();
                    }
                    else
                    {
                        escrever = new StreamWriter(teste);
                        escrever.WriteLine(metodo + " :");
                        escrever.WriteLine(Mensagem);
                        escrever.Close();
                    }

                }
                else
                {
                    teste = Diretorio_erro + "\\ERRO   " + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";

                    escrever = new StreamWriter(teste);
                    escrever.WriteLine("Método " + metodo);
                    escrever.WriteLine(Mensagem);
                    escrever.Close();
                }


            }
            catch (Exception ex)
            {

                string mensagem = "erro: " + ex;
            }


        }

        public static bool Gravarconexaobanco(string host, string instancia, string usuario, string senha, bool servidor, bool atualizar_dados)
        {
            bool retorno = false;
            string diretorio = @"C:\LOJAPET";
            try
            {
                if (File.Exists(diretorio) == true && atualizar_dados == true)
                {
                    XElement xml = XElement.Load(diretorio);

                    xml.RemoveAll();
                    xml.Add(new XAttribute("HOST", host));
                    xml.Add(new XAttribute("Instance", instancia));
                    xml.Add(new XAttribute("USER-ID", usuario));
                    xml.Add(new XAttribute("PASSWORD", senha));
                    xml.Add(new XAttribute("servidor", servidor)); //true sim, false nao
                    xml.Save(diretorio + "\\config");

                    retorno = true;

                }
                if (File.Exists(diretorio) == false)
                {

                    XElement x = new XElement("caminho");
                    x.Add(new XAttribute("HOST", host));
                    x.Add(new XAttribute("Instance", instancia));
                    x.Add(new XAttribute("USER-ID", usuario));
                    x.Add(new XAttribute("PASSWORD", senha));
                    x.Add(new XAttribute("servidor", servidor)); //true sim, false nao
                    x.Save(diretorio + "\\config");
                    retorno = true;
                }

            }
            catch (Exception)
            {

                retorno = false;
            }

            return retorno;
        }

        public static string[] LerConexaoBD()
        {
            string arquivo = @"C:\LOJAPET\config";
            string[] _retorno = new string[5];




            if (File.Exists(arquivo))
            {
                XElement x = XElement.Load(arquivo);
                _retorno[0] = x.Attribute("HOST").Value;
                _retorno[1] = x.Attribute("Instance").Value;
                _retorno[2] = x.Attribute("USER-ID").Value;
                _retorno[3] = x.Attribute("PASSWORD").Value;
                _retorno[4] = x.Attribute("servidor").Value;
            }

            return _retorno;
        }


        public static DataTable criar_xml_tabela(string local, string sql, string nome)
        {
            DataTable table = new DataTable(nome);
            table = ClassComandoSQL.Retorna_Datatable(sql);
            if (!Directory.Exists(@"C:\LojaPet\schema"))
            {
                Directory.CreateDirectory(@"C:\LojaPet\schema");
            }
            table.WriteXmlSchema(@"C:\LojaPet\schema" + local);
            return table;
        }
        public static DataTable CombineDataTables(params DataTable[] args)
        {
            return args.SelectMany(dt => dt.AsEnumerable()).CopyToDataTable();
        }

    }



}
