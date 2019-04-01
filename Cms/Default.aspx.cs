using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Pid_SelectedIndexChanged(object sender, EventArgs e)
    {

        string connectionString = WebConfigurationManager.ConnectionStrings["LNSS"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("SELECT [Id], [MainContent], [Hkey], [Hdescription], [PageTitle], [OriginalUrl], [MappedUrl], [Caption], [SubCat] FROM [SiteContent] WHERE ([Id] = @Id)", con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@Id", Pid.SelectedItem.Value);
        SqlDataReader rd;
        try
        {

            con.Open();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Ptitle.Text = rd["PageTitle"].ToString();
                Pkey.Text = rd["Hkey"].ToString();
                Pdesc.Text = rd["HDescription"].ToString();
                McontEdit.Html = rd["MainContent"].ToString();
                txtOrigUrl.Text = rd["OriginalUrl"].ToString();
                txtMapUrl.Text = rd["MappedUrl"].ToString();
                txtCaption.Text = rd["Caption"].ToString();
                DDL1.SelectedItem.Value = rd["SubCat"].ToString();
            }
            rd.Close();

        }
        catch (Exception err)
        {
            LblError.Text = err.ToString();
        }
        finally
        {
            con.Close();
        }
        SvPage.Enabled = true;
        SvPage.Visible = true;
        
    }
    protected void edit_Click(object sender, EventArgs e)
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["LNSS"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("SELECT [Id], [MainContent], [Hkey], [Hdescription], [PageTitle], [OriginalUrl], [MappedUrl], [Caption], [SubCat] FROM [SiteContent] WHERE ([Id] = @Id)", con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@Id", Pid.SelectedItem.Value);        
        SqlDataReader rd;
        try
        {
            con.Open();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {                
                Ptitle.Text = rd["PageTitle"].ToString();
                Pkey.Text = rd["Hkey"].ToString();
                Pdesc.Text = rd["HDescription"].ToString();
                McontEdit.Html = rd["MainContent"].ToString();
                txtOrigUrl.Text = rd["OriginalUrl"].ToString();
                txtMapUrl.Text = rd["MappedUrl"].ToString();
                txtCaption.Text = rd["Caption"].ToString();
                DDL1.SelectedItem.Value = rd["SubCat"].ToString();
                
            }
            rd.Close();
        }
        catch (Exception err)
        {
            LblError.Text = err.ToString();
        }
        finally
        {
            con.Close();
        }
        SvPage.Enabled = true;
        SvPage.Visible = true;
    }
    protected void SvPage_Click(object sender, EventArgs e)
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["LNSS"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("UPDATE [SiteContent] SET [MainContent] = @MainContent, [Hkey] = @Hkey, [Hdescription] = @Hdescription,  [PageTitle] = @PageTitle, [OriginalUrl] = @OriginalUrl, [MappedUrl] = @MappedUrl, [Caption] = @Caption, [SubCat] = @SubCat WHERE [ID] = @ID", con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@Id", Pid.SelectedItem.Value );        
        cmd.Parameters.AddWithValue("@PageTitle", Ptitle.Text);
        cmd.Parameters.AddWithValue("@Hkey", Pkey.Text);
        cmd.Parameters.AddWithValue("@HDescription", Pdesc.Text);
        cmd.Parameters.AddWithValue("@MainContent", McontEdit.Html);
        cmd.Parameters.AddWithValue("@OriginalUrl", txtOrigUrl.Text);
        cmd.Parameters.AddWithValue("@MappedUrl", txtMapUrl.Text);
        cmd.Parameters.AddWithValue("@Caption", txtCaption.Text);
        cmd.Parameters.AddWithValue("@SubCat", DDL1.SelectedValue);

        SqlDataReader rd2;
        try
        {
            con.Open();
            rd2 = cmd.ExecuteReader();
            
            rd2.Close();
        }
        catch (Exception err)
        {
            LblError.Text = err.ToString();
        }
        finally
        {
            con.Close();
            SvPage.Enabled = false;
            SvPage.Visible = false;
        }
    }
    protected void AddPage_Click(object sender, EventArgs e)
    {
        PagesDataContext dc = new PagesDataContext();
        var obj1 = (from p in dc.SiteContents select new { p.Id }).ToArray();
        string ou = "~/Default.aspx?page=" + (obj1[obj1.Length-1].Id + 1).ToString();
        string connectionString = WebConfigurationManager.ConnectionStrings["LNSS"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("INSERT INTO [SiteContent] ([MainContent], [Hkey], [Hdescription], [PageTitle], [OriginalUrl], [MappedUrl], [Caption], [SubCat]) VALUES (@MainContent, @Hkey, @Hdescription, @PageTitle, @OriginalUrl, @MappedUrl, @Caption, @SubCat)", con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@PageTitle", Ptitle.Text);
        cmd.Parameters.AddWithValue("@Hkey", Pkey.Text);
        cmd.Parameters.AddWithValue("@HDescription", Pdesc.Text);
        cmd.Parameters.AddWithValue("@MainContent", McontEdit.Html);
        cmd.Parameters.AddWithValue("@OriginalUrl", ou);
        cmd.Parameters.AddWithValue("@MappedUrl", txtMapUrl.Text);
        cmd.Parameters.AddWithValue("@Caption", txtCaption.Text);
        cmd.Parameters.AddWithValue("@SubCat", DDL1.SelectedValue);
        SqlDataReader rd2;
        try
        {
            con.Open();
            rd2 = cmd.ExecuteReader();

            rd2.Close();
        }
        catch (Exception err)
        {
            LblError.Text = err.ToString();
        }
        finally
        {
            con.Close();
            AddPage.Enabled = false;
            AddPage.Visible = false;
        }
    }
    protected void Npage_Click(object sender, EventArgs e)
    {
        AddPage.Enabled = true;
        AddPage.Visible = true;        
        txtCaption.Text = "";
        Ptitle.Text = "";
        Pkey.Text = "";
        Pdesc.Text = "";
        McontEdit.Html = "";
        Npage.Enabled = false;
        Npage.Visible = false;
    }
    protected void ResetB_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Cms/Default.aspx");
    }
    protected void RBUrl_Click(object sender, EventArgs e)
    {
        string xmlFile = Server.MapPath("~/Url.xml");
        XmlTextWriter writer = new XmlTextWriter(xmlFile, null);
        writer.Formatting = Formatting.Indented;
        writer.Indentation = 3;
        writer.WriteStartDocument();
        writer.WriteStartElement("urlMappings");
        PagesDataContext dcurl = new PagesDataContext();
        var objurl = (from p in dcurl.SiteContents select new {p.Id, p.OriginalUrl, p.MappedUrl }).ToArray();
        foreach ( var i in objurl)
        {
            writer.WriteStartElement("add");
            writer.WriteAttributeString("url", i.MappedUrl);
            writer.WriteAttributeString("mappedUrl", i.OriginalUrl);
            writer.WriteEndElement();
        }
        writer.WriteEndElement();
        writer.Close();

   
        string xmlFile2 = Server.MapPath("~/SiteMap.xml");
            XmlTextWriter writer2 = new XmlTextWriter(xmlFile2, null);
            writer2.Formatting = Formatting.Indented;
            writer2.Indentation = 3;
            writer2.WriteStartDocument();
            writer2.WriteStartElement("mainmenu");
            PagesDataContext dcpc = new PagesDataContext();
            int mpid = 999;
            var pid = (from p in dcpc.SiteContents where p.SubCat == mpid select new { p.Id, p.Caption, p.MappedUrl, p.SubCat }).ToArray();
            foreach (var i in pid)
            {
                
                writer2.WriteStartElement("item");
                writer2.WriteAttributeString("Caption", i.Caption);
                writer2.WriteAttributeString("Url", i.MappedUrl);
                int i1 = i.Id;
                PagesDataContext dc2 = new PagesDataContext();
                int pi = (from p in dc2.SiteContents where p.SubCat == i.Id select new { p.Id }).Count();
                if (pi > 0)
                {
                    var pid1 = (from p in dc2.SiteContents where p.SubCat == i.Id select new { p.Id, p.Caption, p.MappedUrl, p.SubCat }).ToArray();
                    foreach (var ii in pid1)
                    {
                        if (ii.Id != i1)
                        {
                            writer2.WriteStartElement("subitem");
                            writer2.WriteAttributeString("Caption", ii.Caption);
                            writer2.WriteAttributeString("Url", ii.MappedUrl);
                            int ii1 = ii.Id;
                            PagesDataContext dc3 = new PagesDataContext();
                            int pii = (from ppid in dc3.SiteContents where ppid.SubCat == ii.Id select new { ppid.Id }).Count();
                            if (pii > 0)
                            {
                                var pid2 = (from ppid in dc3.SiteContents where ppid.SubCat == ii.Id select new { ppid.Id, ppid.Caption, ppid.MappedUrl, ppid.SubCat }).ToArray();
                                foreach (var iii in pid2)
                                {
                                    if (iii.Id != ii1)
                                    {
                                        writer2.WriteStartElement("subitem");
                                        writer2.WriteAttributeString("Caption", iii.Caption);
                                        writer2.WriteAttributeString("Url", iii.MappedUrl);
                                        writer2.WriteEndElement();
                                    }
                                }
                            }
                            writer2.WriteEndElement();
                        }
                    }
                }
                writer2.WriteEndElement();
            }
            writer2.WriteEndElement();
            writer2.Close();
                
            } 
            
            }

        


