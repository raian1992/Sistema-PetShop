using System;

namespace SistemaPetshop_2._0.Suporte
{
    static class ClassSerial
    {
        public static int qtdecnpj;
        public static string seriehd;
        public static string seriecompleta;
        public static char caracterbase = '#';
        // public static string serie_cript;
        public static DateTime datainfinal;

        public static object ConfigurationManager { get; private set; }

        public static string gerar_serial_suporte(DateTime datafinal, int QTDE_CNPJ_ALT, string serial_old)
        {
            string retorno = ClassCript.descriptografarsenha(serial_old);
            seriecompleta = retorno;
            string[] cadeiachar = retorno.Split(caracterbase);
            seriehd = cadeiachar[0];
            if (QTDE_CNPJ_ALT == 0)
            {
                qtdecnpj = Convert.ToInt32(cadeiachar[3]);
            }
            retorno = ClassCript.criptografarSenha(seriehd + caracterbase + datafinal.Date.ToString("dd.MM.yyyy") + caracterbase + "QTDE_ESTAB" + caracterbase + qtdecnpj);
            return retorno;
        }



    }
}


