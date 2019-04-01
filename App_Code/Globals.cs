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
using System.Web.Configuration;
using Avrise.LN.Configuration;


namespace Avrise.LN
{
    /// <summary>
    /// Summary description for Globals
    /// </summary>
    public static class Globals
    {
        public readonly static LNSection Settings = (LNSection)WebConfigurationManager.GetSection("LN");

        static Globals()
        {

        }

    }
}
