<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AwesomeApp.UI.Contact" %>
<%@ Register Src="~/Controls/CustomField.ascx" TagName="CustomField" TagPrefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:Label ID="lblMessage" runat="server" CssClass="label label-success"></asp:Label>
    <uc:CustomField ID="fieldName" runat="server" LabelValue="Name" InputType="SingleLine" IsRequired="true" RequiredValidationError="Name is mandatory!" />
    <uc:CustomField ID="fieldEmail" runat="server" LabelValue="Email" InputType="Email" IsRequired="true" RequiredValidationError="Email is mandatory!" />
    <uc:CustomField ID="fieldMessage" runat="server" LabelValue="Message" InputType="MultiLine" />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
</asp:Content>
