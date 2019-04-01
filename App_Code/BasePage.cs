using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Avrise.LN.UI
{
    /// <summary>
    /// Summary description for BasePage
    /// </summary>
    public class BasePage : System.Web.UI.Page
    {
        protected void SslSend(object sender, MailMessageEventArgs e)
        {
            System.Net.Mail.SmtpClient smtpSender = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtpSender.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtpSender.Credentials = new System.Net.NetworkCredential("site@laurellnico.ru", "1qsczse4");
            smtpSender.EnableSsl = true;

            smtpSender.Send(e.Message);
            e.Cancel = true;
        }
    }
    
    

}
