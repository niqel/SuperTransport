using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TmsTcAPI.DAL.Models;
using CrmTc.DAL.Models;
using NotificationService.Enum;
using static NotificationService.Enum.ErrorEnum;
using NotificationService.Models;
//using Microsoft.EntityFrameworkCore;

namespace NotificationService.Business
{
    public class NotificationServiceBusiness
    {

        private TmsTcEntities TmsContext;
        public NotificationServiceBusiness(TmsTcEntities tmsContext, CrmTcEntities crmContext)
        {
            TmsContext = tmsContext;
        }

        public object EnviarCorreo(string correo)
        {
            EmailResponse respuesta = new EmailResponse();
            string body = string.Empty, titulo = string.Empty, subject = string.Empty;
            string strHtmlBody = string.Empty;
            try
            {
                Configuracioncorreos configuracionCorreo = TmsContext.Configuracioncorreos.Find(1);

                List<TemplateCorreo> ListaTemplate = ObtenerTemplateCorreos(1);

                TemplateCorreo objetoAcuse = ListaTemplate[0];
                body = WebUtility.HtmlDecode(objetoAcuse.Body);
                titulo = objetoAcuse.Nombre;
                subject = objetoAcuse.Subject;
                strHtmlBody = body;

                MailMessage mail = new MailMessage();
                SmtpClient Smtpclient = new SmtpClient(configuracionCorreo.OutgoingServer);

                mail.From = new MailAddress(configuracionCorreo.User);
                mail.To.Add(correo);
                mail.Subject = subject;
                mail.BodyEncoding = Encoding.UTF8;
                mail.Body = strHtmlBody;
                mail.IsBodyHtml = true;

                Smtpclient.Port = Int32.Parse(configuracionCorreo.OutgoingPort.ToString());
                Smtpclient.Credentials = new System.Net.NetworkCredential(configuracionCorreo.User, configuracionCorreo.Password);
                Smtpclient.EnableSsl = true;

                ServicePointManager.ServerCertificateValidationCallback =
                            delegate (object s, X509Certificate certificate,
                              X509Chain chain, SslPolicyErrors sslPolicyErrors)
                            { return true; };

                Smtpclient.Send(mail);
                respuesta.Data = "200";
                respuesta.Mensaje = "OK";

            }
            catch (SmtpFailedRecipientException ex)
            {
                if (ex.InnerException != null)
                {
                    respuesta.Data = ErrorEnum.TypeofError.ErrorEnElServidorDeCorreo.ToString();
                    respuesta.Mensaje = string.Empty;
                    respuesta.Mensaje = EnumHelper.SetErrorMessage(respuesta.Mensaje, ex, TypeofError.ErrorEnElServidorDeCorreo);

                }
                else
                {
                    respuesta.Data = ErrorEnum.TypeofError.ErrorEnElServidorDeCorreo.ToString();
                    respuesta.Mensaje = string.Empty;
                    respuesta.Mensaje = EnumHelper.SetErrorMessage(respuesta.Mensaje, ex, TypeofError.ErrorEnElServidorDeCorreo);
                }
            }
            return respuesta;
        }


        private string corrigeAcento(string cadenaAcorregir)
        {
            string cadenaCorregida = cadenaAcorregir;
            cadenaCorregida = cadenaCorregida.Replace("á", "&aacute;");
            cadenaCorregida = cadenaCorregida.Replace("é", "&eacute;");
            cadenaCorregida = cadenaCorregida.Replace("í", "&iacute;");
            cadenaCorregida = cadenaCorregida.Replace("ó", "&oacute;");
            cadenaCorregida = cadenaCorregida.Replace("ú", "&uacute;");
            cadenaCorregida = cadenaCorregida.Replace("ñ", "&ntilde;;");

            return cadenaCorregida;
        }

        private List<TemplateCorreo> ObtenerTemplateCorreos(int Id)
        {
            List<TemplateCorreo> ListaTemplate;
            ListaTemplate = (from template in TmsContext.Templatecorreos
                             where template.Id == Id && template.Active == true
                             select new TemplateCorreo()
                             {
                                 Id = template.Id,
                                 Nombre = template.Name,
                                 Subject = template.Subject,
                                 Cc = template.Cc,
                                 Body = template.Body,
                                 Bcc = template.Bcc
                             }).ToList();

            return ListaTemplate;
        }

    }

}

