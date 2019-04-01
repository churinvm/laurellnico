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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
    {
        if (Membership.ValidateUser(Login.UserName, Login.Password))
        {
            e.Authenticated = true;
            SignOutButton.Visible = true;
        }
        else
        {
            e.Authenticated = false;
            SignOutButton.Visible = false;
        }
    }
    public void SignOut_Click(Object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("~/");
    }
}
