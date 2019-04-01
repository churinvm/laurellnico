<%@ Page Language="C#" MasterPageFile="~/MainTemplate.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>

<asp:Content ID="ContentMain" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">   
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:LNSS %>" 
    SelectCommand="SELECT [Id], [Caption] FROM [SiteContent]" >
</asp:SqlDataSource>
    <asp:Button ID="ResetB" runat="server" Text="Сброс" onclick="ResetB_Click" />&nbsp;&nbsp;
    <asp:Button ID="AddPage" runat="server" Text="Добавить" Enabled="false" Visible="false" onclick="AddPage_Click" />&nbsp;&nbsp;
    <asp:Button ID="Npage" runat="server" Text="Новая" onclick="Npage_Click" />&nbsp;&nbsp;
    <asp:Button ID="SvPage" runat="server" Text="Сохранить" Enabled="false" Visible="false" onclick="SvPage_Click"/>&nbsp;&nbsp;
    <asp:Button ID="RBUrl" runat="server" Text="Пересобрать" onclick="RBUrl_Click" />
    <asp:Label ID="LblError" runat="server" Text=""></asp:Label>
<table>
    <tr>
        <td>ID страницы</td><td>
        <asp:DropDownList id="Pid" runat="server" 
            DataSourceID="SqlDataSource1"  DataValueField="Id" DataTextField="Caption" 
            onselectedindexchanged="Pid_SelectedIndexChanged" AutoPostBack="True" />&nbsp;&nbsp; 
            <asp:Button ID="edit" runat="server" Text="edit" onclick="edit_Click" /></td>
    </tr>

    <tr>
        <td>АдресОригинальный</td><td><asp:TextBox runat="server" ID="txtOrigUrl" /></td>
    </tr>
    <tr>
        <td>АдресПереписанный</td><td><asp:TextBox runat="server" ID="txtMapUrl" /> 
            
        </td>
    </tr>
    <tr>
        <td>Заголовок</td><td><asp:TextBox runat="server" ID="Ptitle" /></td>
    </tr>
    <tr>
        <td>Ключевые слова</td><td><asp:TextBox runat="server" ID="Pkey" /></td>
    </tr>
    <tr>
        <td>Описание</td><td><asp:TextBox runat="server" ID="Pdesc" /></td>
    </tr>
    <tr>
        <td>Имя в меню</td><td><asp:TextBox runat="server" ID="txtCaption" /></td>
    </tr>
    <tr>
        <td>Родительская страница</td><td><asp:DropDownList ID="DDL1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Caption" DataValueField="Id" /></td>
    </tr>
    <tr>
        <td>Содержание</td>
        <td>
            
            
                <dx:ASPxHtmlEditor ID="McontEdit" runat="server"></dx:ASPxHtmlEditor>
            
                
        </td>
    </tr>
</table>

</asp:Content>



