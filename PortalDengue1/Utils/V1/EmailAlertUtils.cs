using System.Data;
using System.Net.Mail;
using System.Threading;
using System;
using PortalDengue1.Services.V1;
using System.Collections.Generic;

namespace PortalDengue1.Utils.V1
{
    public class EmailAlertUtils
    {
        private static string alertMessage = "O Bairro {0} acaba de registrar {1} novos casos de dengue.";
        private static string alertMessage2 = "O Bairro {0} ultrapassou a marca de {1} casos de dengue.";

        public static void StartSendingAlert(string district, int numberCases, int valueMessage)
        {
            while (true)
            {
                var emailUsers = new UserService().GetEmailByDistrict(district);
                if (emailUsers != null)
                {
                    switch (valueMessage)
                    {
                        case 1:
                            alertMessage = string.Format(alertMessage, district, numberCases);
                            SendEmail(alertMessage, emailUsers);
                            break;
                        case 2:
                            alertMessage = string.Format(alertMessage2, district, numberCases);
                            SendEmail(alertMessage, emailUsers);
                            break;
                    }
                }
                break;
            }
        }

        private static void SendEmail(string alertMessage, List<string> emailUsers)
        {
            string sender = "projedengue@gmail.com";
            string subject = "Alerta de novos casos de dengue";

            using (SmtpClient smtp = new SmtpClient())
            {

                //Servidor SMTP
                smtp.Host = "smtp.gmail.com";
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("projedengue@gmail.com", "rnaczvyzapthhkvl");
                smtp.Port = 587;
                smtp.EnableSsl = true;

                foreach (var item in emailUsers)
                {
                    MailMessage email = new MailMessage();

                    email.From = new MailAddress(sender);
                    email.To.Add(item);

                    email.Subject = subject;
                    email.IsBodyHtml = false;
                    email.Body = alertMessage;

                    smtp.Send(email);
                }
            }

        }
    }
}
