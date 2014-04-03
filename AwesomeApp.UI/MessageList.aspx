<%@ Page Title="Message List" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="MessageList.aspx.cs" Inherits="AwesomeApp.UI.MessageList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <asp:GridView ID="gvMessages" runat="server" ItemType="AwesomeApp.DA.Message" DataKeyNames="ID"
        SelectMethod="gvMessages_GetData" AutoGenerateColumns="true" CssClass="table table-striped"></asp:GridView>
</asp:Content>
