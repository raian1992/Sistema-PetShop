using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaPetshop_2._0
{
    class ClassE_mail
    {
        public static string E_mail_Sistema(string Destinatario, string Assunto, string enviaMensagem, int id_email)
        {
            try
            {
                string Remetente, senha, smtp;
                bool ssl;
                int porta;

                using (var bd = new LOJA_PETEntities())
                {
                    var temp = bd.EMAIL.FirstOrDefault(x => x.ID_EMAIL == id_email);
                    Remetente = temp.END_EMAIL;
                    senha = ClassCript.descriptografarsenha(temp.SENHA);
                    smtp = temp.SMTP;
                    ssl = temp.Req_SSL;
                    porta = Convert.ToInt32(temp.PORTA);
                }


                // valida o email
                bool bValidaEmail = ValidaEnderecoEmail(Destinatario);

                // Se o email não é validao retorna uma mensagem
                if (bValidaEmail == false)
                    return "Email do destinatário inválido: " + Destinatario;

                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                message.From = new MailAddress(Remetente);
                message.To.Add(new MailAddress(Destinatario));
                message.Subject = Assunto; //assunto
                message.IsBodyHtml = true;
                message.Body = enviaMensagem; // corpo do email
                client.Port = porta;
                client.Host = smtp;
                client.EnableSsl = ssl;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(Remetente, senha);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(message);
                return "Mensagem enviada para  " + Destinatario.ToLower() + " às " + DateTime.Now.ToString() + ".";

            }
            catch (Exception ex)
            {
                string erro = ex.Message.ToString();
                return ex.Message.ToString() + erro;
            }
        }
        public static string EnviaMensagemEmail(string Destinatario, string Remetente, string Assunto, string enviaMensagem, string smtp, int porta, string senha, bool ssl)
        {
            try
            {
                // valida o email
                bool bValidaEmail = ValidaEnderecoEmail(Destinatario);

                // Se o email não é validao retorna uma mensagem
                if (bValidaEmail == false)
                    return "Email do destinatário inválido: " + Destinatario;

                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                message.From = new MailAddress(Remetente);
                message.To.Add(new MailAddress(Destinatario));
                message.Subject = Assunto; //assunto
                message.IsBodyHtml = true;
                message.Body = enviaMensagem; // corpo do email
                client.Port = porta;
                client.Host = smtp;
                client.EnableSsl = ssl;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(Remetente, senha);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(message);
                return "Mensagem enviada para  " + Destinatario.ToLower() + " às " + DateTime.Now.ToString() + ".";
            }
            catch (Exception ex)
            {
                string erro = ex.Message.ToString();
                return ex.Message.ToString() + erro;
            }
        }

        public static string EnviaMensagemComAnexos(string Destinatario, string Remetente, string Assunto, string enviaMensagem, ArrayList anexos, string smtp, int porta, string senha)
        {
            try
            {
                // valida o email
                bool bValidaEmail = ValidaEnderecoEmail(Destinatario);

                if (bValidaEmail == false)
                    return "Email do destinatário inválido:" + Destinatario;

                // Cria uma mensagem
                MailMessage mensagemEmail = new MailMessage(
                   Remetente, Destinatario, Assunto, enviaMensagem);
                // Obtem os anexos contidos em um arquivo arraylist e inclui na mensagem
                foreach (string anexo in anexos)
                {
                    Attachment anexado = new Attachment(anexo, MediaTypeNames.Application.Octet);
                    mensagemEmail.Attachments.Add(anexado);
                }

                SmtpClient client = new SmtpClient(smtp, porta);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                NetworkCredential cred = new NetworkCredential(Remetente, senha);

                // Inclui as credenciais
                client.UseDefaultCredentials = true;

                client.Credentials = cred;



                // envia a mensagem
                client.Send(mensagemEmail);

                return "Mensagem enviada para " + Destinatario + " às " + DateTime.Now.ToString() + ".";
            }
            catch (Exception ex)
            {
                string erro = ex.InnerException.ToString();
                return ex.Message.ToString() + erro;
            }
        }

        public static bool ValidaEnderecoEmail(string enderecoEmail)
        {
            try
            {
                //define a expressão regulara para validar o email
                string texto_Validar = enderecoEmail;
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                // testa o email com a expressão
                if (expressaoRegex.IsMatch(texto_Validar))
                {
                    // o email é valido
                    return true;
                }
                else
                {
                    // o email é inválido
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
