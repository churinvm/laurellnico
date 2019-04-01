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

namespace Avrise.LN.Configuration
{
    public class ContactFormElement : ConfigurationElement
    {
        [ConfigurationProperty("mailSubject", DefaultValue = "Mail from Site www.LaurellNico.ru")]
        public string MailSubject
        {
            get { return (string)base["mailSubject"]; }
            set { base["mailSubject"] = value; }
        }

        [ConfigurationProperty("mailTo", IsRequired = true)]
        public string MailTo
        {
            get { return (string)base["mailTo"]; }
            set { base["mailTo"] = value; }
        }

        [ConfigurationProperty("mailCC")]
        public string MailCC
        {
            get { return (string)base["mailCC"]; }
            set { base["mailCC"] = value; }
        }

        [ConfigurationProperty("mailFrom")]
        public string MailFrom
        {
            get { return (string)base["mailFrom"]; }
            set { base["mailFrom"] = value; }
        }
    }
}
