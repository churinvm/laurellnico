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
    /// <summary>
    /// Summary description for LNSection
    /// </summary>
    public class LNSection : ConfigurationSection
    {
        [ConfigurationProperty("defaultConnectionStringName", DefaultValue = "LN")]
        public string DefaultConnectionStringName
        {
            get { return (string)base["defaultConnectionStringName"]; }
            set { base["connectionStdefaultConnectionStringNameringName"] = value; }
        }
        [ConfigurationProperty("defaultCacheDuration", DefaultValue = "600")]
        public int DefaultCacheDuration
        {
            get { return (int)base["defaultCacheDuration"]; }
            set { base["defaultCacheDuration"] = value; }
        }

        [ConfigurationProperty("contactForm", IsRequired = true)]
        public ContactFormElement ContactForm
        {
            get { return (ContactFormElement)base["contactForm"]; }
        }
        //[ConfigurationProperty("articles", IsRequired = true)]
        //public ArticlesElement Articles
        //{
        //    get { return (ArticlesElement)base["articles"]; }
        //}

        //[ConfigurationProperty("polls", IsRequired = true)]
        //public PollsElement Polls
        //{
        //    get { return (PollsElement)base["polls"]; }
        //}

        //[ConfigurationProperty("newsletters", IsRequired = true)]
        //public NewslettersElement Newsletters
        //{
        //    get { return (NewslettersElement)base["newsletters"]; }
        //}

        //[ConfigurationProperty("forums", IsRequired = true)]
        //public ForumsElement Forums
        //{
        //    get { return (ForumsElement)base["forums"]; }
        //}

        //[ConfigurationProperty("store", IsRequired = true)]
        //public StoreElement Store
        //{
        //    get { return (StoreElement)base["store"]; }
        //}

    }

}
