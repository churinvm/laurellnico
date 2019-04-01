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
    
    public partial class MainPage  : Avrise.LN.UI.BasePage
    {
        public string Pid, npk, npd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString == null || string.IsNullOrEmpty(Request.QueryString["page"]))
                {
                    Pid = "1";
                }
                else
                {
                    Pid = Request.QueryString["page"];
                }
                PagesDataContext dc = new PagesDataContext();
                var obj1 = (from p in dc.SiteContents where p.Id == Convert.ToInt16(Pid) select new { p.MainContent, p.PageTitle, p.Hkey, p.Hdescription }).FirstOrDefault();
                Page.Title = obj1.PageTitle.ToString();
                mcont.Text = obj1.MainContent.ToString();
                npk = obj1.Hkey.ToString();
                npd = obj1.Hdescription.ToString();
                Page.DataBind();

            }

        }
        
    }
}
