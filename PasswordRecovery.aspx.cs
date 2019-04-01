using System;
using System.Collections;
using System.Configuration;
using System.Data;
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

    public partial class PR : Avrise.LN.UI.BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void PasswordRecovery1_SendingMail(object sender, MailMessageEventArgs e)
        {
            SslSend(sender, e);
        }

    }
}
