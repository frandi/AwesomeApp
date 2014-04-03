<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomField.ascx.cs" Inherits="AwesomeApp.UI.Controls.CustomField" %>
<div class="form-group">
    <asp:Label ID="lblLabel" runat="server" AssociatedControlID="txtInput"></asp:Label>
    <asp:TextBox ID="txtInput" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvInput" runat="server" Display="Dynamic"
        ControlToValidate="txtInput" Text="*"></asp:RequiredFieldValidator>
</div>
