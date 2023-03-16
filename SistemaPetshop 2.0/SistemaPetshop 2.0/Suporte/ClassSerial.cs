using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPetshop_2._0.Suporte
{
    static class ClassSerial
    {
        public static int qtdecnpj;
        public static string seriehd;
        public static string nomepc = Environment.MachineName;
        public static string ippc = ClassCript.GetLocalIPAddress();
        public static string seriecompleta;
        public static char caracterbase = '#';
        public static string seriecompletanova;
        // public static string serie_cript;
        public static DateTime datainfinal;

        public static object ConfigurationManager { get; private set; }

        public static bool validaserial(string serial, int qtde_cnpj_local)
        {
            bool valido = false;
            try
            {

                string retorno = ClassCript.descriptografarsenha(serial);
                seriecompleta = retorno;
                string[] cadeiachar = retorno.Split(caracterbase);
                string serie_hd = cadeiachar[0];
                datainfinal = Convert.ToDateTime(cadeiachar[1]);
                qtdecnpj = Convert.ToInt32(cadeiachar[3]);
                string serienova = GerarSerial(datainfinal, qtdecnpj);
                seriecompletanova = ClassCript.criptografarSenha(serienova);
                if (seriecompleta == serienova && DateTime.Now.Date <= datainfinal)
                {
                    if (qtde_cnpj_local > qtdecnpj)
                    {
                        ClassComandoSQL.atualiza_empresas_p_inativa(qtde_cnpj_local - qtdecnpj);
                    }
                    qtdecnpj = qtde_cnpj_local;
                    valido = true;
            }
               // ClassComandoSQL.atualiza_config_dt_val(datainfinal);

            }
            catch (Exception)
            {

                valido = false;
            }
          
            return valido;
        }
        public static bool validarvencimentoestacao(string serial)
        {
            bool valido = false;
            string retorno = ClassCript.descriptografarsenha(serial);
            seriecompleta = retorno;
            string[] cadeiachar = retorno.Split(caracterbase);
            datainfinal = Convert.ToDateTime(cadeiachar[1]);
            if (DateTime.Now.Date >= datainfinal)
            {
                valido = false;
            }
            if (DateTime.Now.Date < datainfinal)
            {
                valido = true;
            }
            return valido;

        }
        public static string GerarSerial(DateTime datafinal, int QTDE_CNPJ)//validar quantidade serial tambem
        {
            seriehd = ClassCript.GetHardDiskSerialNo();
            //string serial = seriehd + caracterbase + datafinal.Date.ToString("dd.MM.yyyy");//verificar como definir um servidor dentro do serial
            string serial = seriehd + caracterbase + datafinal.Date.ToString("dd.MM.yyyy") + caracterbase + "QTDE_ESTAB" + caracterbase + QTDE_CNPJ;
            return serial;
        }

        public static string GerarSerialTrial()
        {
            // DateTime datafinal = DateTime.Now.AddDays(1);
            DateTime datafinal = DateTime.Now.AddDays(15);
            seriehd = ClassCript.GetHardDiskSerialNo();
            string serial = ClassCript.criptografarSenha(seriehd + caracterbase + datafinal.Date.ToString("dd.MM.yyyy") + caracterbase + "QTDE_ESTAB" + caracterbase + "1");//verificar como definir um servidor dentro do serial
            return serial;
        }


    }
}


