﻿<%@ Page Language="C#" MasterPageFile="~/MainTemplate.master" AutoEventWireup="true" CodeFile="Contacts.aspx.cs" Inherits="Avrise.LN.UI.SendMessage" Title=""%>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<asp:Content ID="ContentMain" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="center" ><br /><br /><br /><br /><br /><br /><br /><br />
        <dxe:ASPxLabel ID="lblTitle" runat="server" Text="" Font-Size="16px" EnableDefaultAppearance="False">
        </dxe:ASPxLabel>
    </p>
    <table cellpadding="2" style="margin: 0 auto">
        <tr>
            <td style="width: 80px;">
                <asp:Label runat="server" ID="lblName" cssClass="lblmailform" AssociatedControlID="txtName" Text="От:"/>
                </td>
            <td style="width: 550px">
                <asp:TextBox runat="server" ID="txtName" cssClass="txtmailform" Width="100%" BackColor="#F0F0F0" />
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" Display="dynamic" ID="valRequireName"
                    SetFocusOnError="true" ControlToValidate="txtName" ErrorMessage='Поле "От:" должно быть заполнено.'>*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblEmail" cssClass="lblmailform" AssociatedControlID="txtEmail" Text="Адрес для ответа:"
                     />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtEmail" cssClass="txtmailform" Width="100%" BackColor="#F0F0F0" />
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" Display="dynamic" ID="valRequireEmail"
                    SetFocusOnError="true" ControlToValidate="txtEmail" ErrorMessage="Адрес для ответа не указан.">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" Display="dynamic" ID="valEmailPattern"
                    SetFocusOnError="true" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ErrorMessage="Указан неверный адрес для ответа.">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblSubject" cssClass="lblmailform" AssociatedControlID="txtSubject" Text="Тема:"
                     />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtSubject" cssClass="txtmailform" Width="100%" BackColor="#F0F0F0" />
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" Display="dynamic" ID="valRequireSubject"
                    SetFocusOnError="true" ControlToValidate="txtSubject" ErrorMessage='Поле "Тема:" должно быть заполнено.'>*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lblBody" cssClass="lblmailform" AssociatedControlID="txtBody" Text="Сообщение:"
                     />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtBody" cssClass="txtmailform" Width="100%" TextMode="MultiLine" Rows="8"
                    BackColor="#F0F0F0" />
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" Display="dynamic" ID="valRequireBody"
                    SetFocusOnError="true" ControlToValidate="txtBody" ErrorMessage="Текс сообщения не заполнен.">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="text-align: right;">
                <asp:Label runat="server" ID="lblFeedbackOK" Text="Ваше сообщение отправлено." Visible="False"
                     />
                <asp:Label runat="server" ID="lblFeedbackKO" Text="При отправке сообщения произошла ошибка. Попробуйте повторить через несколько минут."
                    Visible="False" />
                <div class="btn_sendmsg">
                    <asp:LinkButton ID="txtSubmit" runat="server" OnClick="txtSubmit_Click" >Отправить</asp:LinkButton>
                    <asp:ValidationSummary runat="server" ID="valSummary" ShowSummary="false" ShowMessageBox="true" />
                </div>
            </td>
        </tr>
    </table>
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
</asp:Content>
