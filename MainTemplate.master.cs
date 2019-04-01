using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Web.Configuration;

public partial class MainTemplate : System.Web.UI.MasterPage
{
    string un,uid;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        MembershipUser membershipUser = Membership.GetUser();
        if (membershipUser != null)
        {
            string loggedinuser = Membership.GetUser().ToString();
            LblUName.Text = "Добро Пожаловать";
            
            Loginpan.Visible = false;
        }
        else
        {
            LblUName.Text = " ";
            Loginpan.Visible = true;
        }
    }
    protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
    {
        if (Membership.ValidateUser(Login.UserName, Login.Password))
        {
            e.Authenticated = true;
        }
        else
        {
            e.Authenticated = false;
        }
    }
    
    protected void AddClient(object sender, EventArgs e)
    {
        if (Password.Text == ConfirmPassword.Text)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["LNSS"].ConnectionString;
            //Запоминаем Имя
            un = UserName.Text.ToString();
            //Создаём пользователя
            MembershipCreateStatus CStatus;
            Membership.CreateUser(un, Password.Text.ToString(), txtEMail.ToString(), null, null, true, out CStatus);
            //Прописываем Роль
            Roles.AddUserToRole(un, "Client");
            //Объявляем соединение
            //SqlConnection cn = new SqlConnection(connectionString);
            //Получаем Идентификатор пользователя
            //SqlCommand cmd = new SqlCommand("clyxa_GetUID", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@UserName", un);
            //SqlDataReader rd;
            //try
            //{
            //    cn.Open();
            //    rd = cmd.ExecuteReader();
            //    while (rd.Read())
            //    {
            //        uid = rd["Userid"].ToString();
            //    }
            //    rd.Close();
            //}
            //catch (Exception err)
            //{
            //    LblStatus.Text = "Error ";
            //    LblStatus.Text += err.ToString();
            //}
            //finally
            //{
            //    cn.Close();
            //}
            // Добавляем азпись в таблицу Клиентов
            
            LblStatus.Text = "Клиент " + un + " добавлен";
        }
        else
        {
            LblStatus.Text = "Не совпадают пароли!";
        }

    }


}
