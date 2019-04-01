<%@ page language="C#" masterpagefile="~/MainTemplate.master" autoeventwireup="true" CodeFile="Default.aspx.cs" inherits="Avrise.LN.UI.MainPage" title="" stylesheettheme="Default"%>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="<%# npk %>" />
<meta name="description" content="<%# npd %>" />
<meta name="robots" content="all" />


</asp:Content>

<asp:Content ID="ContentMain" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
    ContextTypeName="PagesDataContext" TableName="SiteContents">
    </asp:LinqDataSource>
<asp:Label runat="server" ID="mcont" />
<h1>LaurellNico</h1>



</asp:Content>







