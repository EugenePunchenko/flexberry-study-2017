﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="Ob'ektE.aspx.cs" Inherits="TeploCorp.TeploUchet.ОбъектE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Объект</h2>
        <div class="<%= Constants.FormToolbarCssClass %> <%= Constants.EditFormToolbarCssClass %> <%= Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass %> <%= Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlНаименованиеLabel" runat="server" Text="Наименование" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlНаименование" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlНаименованиеValidator" runat="server" ControlToValidate="ctrlНаименование"
ErrorMessage="Не указано: Наименование" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКонтрагентLabel" runat="server" Text="Контрагент" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlКонтрагент" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlКонтрагентValidator" runat="server" ControlToValidate="ctrlКонтрагент"
ErrorMessage="Не указано: Контрагент" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlДатаРегистрацииLabel" runat="server" Text="Дата регистрации" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlДатаРегистрации" runat="server"/>
</div>
<asp:RequiredFieldValidator ID="ctrlДатаРегистрацииValidator" runat="server" ControlToValidate="ctrlДатаРегистрации"
ErrorMessage="Не указано: ДатаРегистрации" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЛицСчетLabel" runat="server" Text="Лиц счет" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlЛицСчет" runat="server" MaxLength="19">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlЛицСчетValidator" runat="server" ControlToValidate="ctrlЛицСчет"
ErrorMessage="Не указано: ЛицСчет" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКодОбъектаLabel" runat="server" Text="Код объекта" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlКодОбъекта" runat="server" Enabled="false">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlКодОбъектаValidator" runat="server" ControlToValidate="ctrlКодОбъекта"
ErrorMessage="Не указано: КодОбъекта" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЗданиеLabel" runat="server" Text="Здание" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlЗдание" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlЗданиеValidator" runat="server" ControlToValidate="ctrlЗдание"
ErrorMessage="Не указано: Здание" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЗдание_АдресLabel" runat="server" Text="Адрес" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlЗдание_Адрес" runat="server" ReadOnly="true">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlЗдание_АдресValidator" runat="server" ControlToValidate="ctrlЗдание_Адрес"
ErrorMessage="Не указано: Здание.Адрес" EnableClientScript="true" ValidationGroup="savedoc">*</asp:RequiredFieldValidator>

</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
