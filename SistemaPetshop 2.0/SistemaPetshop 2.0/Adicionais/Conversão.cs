using SistemaPetshop_2._0.Adicionais;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPetshop_2._0
{
    class Conversão
    {

        public static int tipo_empresa;
        public static string tipo_empresa_n;

        public static string excluir_mascara(MaskedTextBox masked)
        {
            masked.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var valorSemMascara = masked.Text;
            return valorSemMascara;
        }

        public static String RetirarIfemCEP(string CEP)
        {
            string CEP_return = "";
            string[] nameArray = CEP.Split('-');
            foreach (string tel in nameArray)
            {
                CEP_return += tel;
            }
            return CEP_return;
        }

        public int ContarCPFCNPJ(String CPFCNPJ)
        {
            bool retorno = false;
            int cont = 0;
            char[] nameArray = CPFCNPJ.ToArray();
            foreach (char c in nameArray)
            {
                cont = cont + 1;
            }

            if (cont == 11)
            {
                retorno = ValidaCPF(CPFCNPJ);
            }
            if (cont == 14)
            {
                retorno = ValidaCNPJ(CPFCNPJ);
            }
            if (retorno != true)
            {
                cont = 1;
            }
            return cont;
        }


        public static bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public static bool ValidaCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
            //if (ValidaCPFCNPJ.Validador.ValidaCNPJ(txtCNPJ.Text))
            //{
            //    novaPessoa.CNPJ = txtCNPJ.Text;
            //}
            //else
            //{
            //    throw new Exception("CNPJ inválido!");
            //}
        }

        public static void conv_tipo_empresa_Numero(string valor1)
        {
            if (valor1 == "MATRIZ")
            {
                tipo_empresa = 1;
            }
            else
            {
                tipo_empresa = 2;
            }

        }

        public static void conv_tipo_empresa_Letra(int valor1)
        {
            if (valor1 == 1)
            {
                tipo_empresa_n = "MATRIZ";
            }
            else
            {
                tipo_empresa_n = "FILIAL";
            }

        }

        public static List<string> Verificar_buscarcep(string cep)
        {
            string end = "", bairro = "", cid = "", uf = "", ibge = "";
            List<string> retorno = new List<string>();
            using (var bd = new LOJA_PETEntities())
            {

                var temp = bd.CEP.FirstOrDefault(x => x.NUM_CEP == cep);
                if (temp != null)
                {
                    end = temp.ENDERECO;
                    bairro = temp.BAIRRO;
                    cid = temp.CIDADE;
                    uf = temp.ESTADO;

                }
                else
                {
                    if (WEB.IsConnected() == 0)
                    {


                        DataSet ds = new DataSet();
                        ds = WEB.Consultacorreios_VIACEP(cep);
                        if (ds.Tables[0].Columns.Count > 1)
                        {
                            end = ds.Tables[0].Rows[0][1].ToString();
                            bairro = ds.Tables[0].Rows[0][3].ToString();
                            cid = ds.Tables[0].Rows[0][4].ToString();
                            uf = ds.Tables[0].Rows[0][5].ToString();
                            ibge = ds.Tables[0].Rows[0][7].ToString();
                        }

                        //MODELO ANTIGO
                        //ds = WEB.Consultacorreios_REPUBLICACEP(cep);
                        //end = ds.Tables[0].Rows[0][7].ToString();
                        //bairro = ds.Tables[0].Rows[0][5].ToString();
                        //cid = ds.Tables[0].Rows[0][4].ToString();
                        //uf = ds.Tables[0].Rows[0][3].ToString();
                        //tipo = ds.Tables[0].Rows[0][5].ToString();

                        if (end != "" || bairro != "" || cid != "" || uf != "")
                        {
                            CEP NOVOCEP = new CEP
                            {
                                NUM_CEP = cep,
                                ENDERECO = end,
                                BAIRRO = bairro,
                                CIDADE = cid,
                                ESTADO = uf,
                                PAIS = "BRASIL",
                                IBGE = ibge
                            };
                            bd.CEP.Add(NOVOCEP);
                            bd.SaveChanges();
                        }
                    }
                }
                if (uf != "")
                {
                    retorno.Add(end);
                    retorno.Add(bairro);
                    retorno.Add(cid);
                    retorno.Add(uf);
                }
            }
            return retorno;
        }

        public static bool Valida_email(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }


        public static bool verificanum(string texto)
        {
            bool retorno;
            double temp;
            if (double.TryParse(texto, out temp))
                retorno = true;
            else
                retorno = false;

            return retorno;
        }

        public static decimal Format_string_Decimal_18_2(string valor)
        {
            string temp;
            decimal retorno;

            try
            {
                if (valor.Contains('.') || valor.Contains(','))
                {
                    valor = valor.Replace('.', ',');
                    string[] v = valor.Split(',');
                    if (v[1] == "  ")
                    {
                        temp = v[0] + ",00";
                    }
                    else
                    {
                        temp = string.Format("{0:N}", valor);
                    }
                }
                else
                {
                    temp = valor + ",00";
                }



            }
            catch (Exception)
            {

                temp = "00,00";
            }

            retorno = decimal.Parse(temp);// AO FORMATAR PARA DECIMAL O SISTEMA ESTA RETIRANDO A VIRGULA
            return retorno;

        }
    }
}
