using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPetshop_2._0
{
    class ClassSenhaAleatoria
    {
      
        

       public static string gerarsenha()
        {
            int TamanhoDaSenha = 8;
            // ValidaTamanhoSenha();
            string senha="0";
            string validar = "abcdefghijklmnozABCDEFGHIJKLMNOZ1234567890@#$%&*!";
            try
            {
                StringBuilder strbld = new StringBuilder(100);
                Random random = new Random();
                while (0
                    < TamanhoDaSenha--)
                {
                    strbld.Append(validar[random.Next(validar.Length)]);
                }
                senha = strbld.ToString();
            }
            catch (Exception)
            {
                senha = "";
            }
            return senha;
        }
    }
}
