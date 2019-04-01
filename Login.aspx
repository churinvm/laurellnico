<%@ Page Language="C#" MasterPageFile="~/MainTemplate.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" Title="Клякса: Главная страница" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div id="Login_block"><div style="top: 40px; left: 30px; position: relative;" >
             <asp:Login ID="Login" runat="server" Font-Names="Myriad pro"
                ForeColor="Black" 
                UserNameLabelText="Логин:" UserNameRequiredErrorMessage="Логин необходим." 
                PasswordRequiredErrorMessage="Пароль необходим." PasswordLabelText="Пароль:" 
                TitleTextStyle-Wrap="False" FailureText="Неправильно ввдены данные" BorderPadding="0" 
                TitleText="" DisplayRememberMe="False" LoginButtonType="Image" Orientation="Vertical" 
                LoginButtonStyle-CssClass="Login_btn" TextLayout="TextOnTop" LoginButtonImageUrl="App_Themes/Default/Images/Login_btn.gif" 
                FailureAction="RedirectToLoginPage" PasswordRecoveryUrl="PasswordRecovery.aspx" PasswordRecoveryText="Забыли пароль?" 
                CreateUserUrl="~/Registration/Registration.aspx" CreateUserText="Зарегистрироваться">
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <LoginButtonStyle BorderStyle="None" BorderWidth="0px" Font-Names="Myriad pro" ForeColor="Black" />
                </asp:Login>
                <asp:Button ID="SignOutButton" runat="server" OnClick="SignOut_Click" Text="Выход" Visible="True" />
            </div></div>    
    
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    
    
    
    
</asp:Content>



