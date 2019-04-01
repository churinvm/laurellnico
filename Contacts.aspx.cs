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
using System.Net.Mail;
using System.Net;


namespace Avrise.LN.UI
{
    public partial class SendMessage : Avrise.LN.UI.BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString == null || string.IsNullOrEmpty(Request.QueryString["MessageType"]))
                {
                    Response.Redirect("~/error.aspx", true);
                    return;
                }
                string msgType = Request.QueryString["MessageType"];

                if (msgType == "1")
                {
                    lblTitle.Text = "Написать нам";
                }
                if (msgType == "2")
                {
                    lblTitle.Text = "Заказать";
                }
                if (string.IsNullOrEmpty(lblTitle.Text))
                {
                    Response.Redirect("~/error.aspx", true);
                    return;
                }
            }
        }
        
        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            try
            {
                msg.Subject = txtSubject.Text;
                msg.Body = txtBody.Text;
                msg.From = new MailAddress(txtEmail.Text, txtName.Text);
                msg.To.Add("site@laurellnico.ru");
                msg.IsBodyHtml = true;                
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(msg);
                lblFeedbackOK.Visible = true;
                lblFeedbackKO.Visible = false;
                txtName.Text = "";
                txtEmail.Text = "";
                txtSubject.Text = "";
                txtBody.Text = "";
            }
            catch (Exception ex)
            {
                lblFeedbackKO.Text += ex.ToString();
                lblFeedbackOK.Visible = false;
                lblFeedbackKO.Visible = true;
            }
        }
    }
}
