<%@ Page Language="C#" MasterPageFile="~/MainTemplate.master" AutoEventWireup="true" CodeFile="PasswordRecovery.aspx.cs" Inherits="Avrise.LN.UI.PR" Title="LaurellNico - восстановление пароля" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
    <asp:PasswordRecovery runat="server" ID="PasswordRecovery1" OnSendingMail="PasswordRecovery1_SendingMail"     
    AnswerLabelText="Ответ:" 
    GeneralFailureText="Не удалось отправить пароль, попробуйте ещё раз." 
    QuestionFailureText="Неправильный ответ на вопрос, попробуйте ещё раз" 
    QuestionInstructionText="Введите ответ на вопрос, чтобы получить пароль" 
    QuestionLabelText="Вопрос:" SubmitButtonText="Отправить" 
    SuccessText="Ваш пароль отправлен вам на почту." 
    UserNameFailureText="Невозможно найти пользователя" 
    UserNameInstructionText="Введите Логин для получения пароля" 
    UserNameLabelText="Логин:" 
    UserNameTitleText="Забыли ваш пароль?" 
    AnswerRequiredErrorMessage="Ответ необходим." 
    UserNameRequiredErrorMessage="Логин необходим." SuccessPageUrl="~/" MailDefinition-From="site@laurellnico.ru" MailDefinition-Subject="Магазин LaurellNico.ru - восстановление пароля">
    </asp:PasswordRecovery></center>
    
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
</asp:Content>



