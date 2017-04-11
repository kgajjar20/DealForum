using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;

namespace DealsForum.Common
{
    public static class ConfigurationSettings
    {
        public static readonly string SmtpUserName = ConfigurationManager.AppSettings["SmtpUserName"].ToString();

        public static readonly string SmtpFromMail = ConfigurationManager.AppSettings["FromMail"].ToString();

        public static readonly string SmtpUserPassword = ConfigurationManager.AppSettings["SmtpUserPassword"].ToString();

        public static readonly string SmtpServer = ConfigurationManager.AppSettings["SmtpServer"].ToString();

        public static readonly string SiteUrl = ConfigurationManager.AppSettings["SiteUrl"].ToString();
    }
}