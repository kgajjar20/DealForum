using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace DealsForum.Common
{
    public class SendEmail : IDisposable
    {
        #region GLOBAL

        private static SendEmail objSendEmail = new SendEmail();

        public static SendEmail Instance { get { return objSendEmail; } }

        public SendEmail()
        {
        }

        #endregion GLOBAL

        #region METHODS

        public bool Send(string from, string to, string subj, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(ConfigurationSettings.SmtpServer);

                mail.From = new MailAddress(string.IsNullOrEmpty(from) ? ConfigurationSettings.SmtpFromMail : from);
                mail.To.Add(to);
                mail.Subject = subj;
                mail.IsBodyHtml = true;
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(ConfigurationSettings.SmtpUserName, ConfigurationSettings.SmtpUserPassword);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;

            }
        }

        public bool Send(string from, string to, string cc, string bcc, string subj, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(ConfigurationSettings.SmtpServer);

                mail.From = new MailAddress(string.IsNullOrEmpty(from) ? ConfigurationSettings.SmtpFromMail : from);
                mail.To.Add(to);
                mail.CC.Add(cc);
                mail.Bcc.Add(bcc);
                mail.Subject = subj;
                mail.IsBodyHtml = true;
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(ConfigurationSettings.SmtpUserName, ConfigurationSettings.SmtpUserPassword);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        #endregion METHODS

        #region IDisposable Members

        public void Dispose()
        {
        }

        #endregion IDisposable Members
    }
}