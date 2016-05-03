<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebJsonRestClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:TextBox ID="txtInputValue" runat="server" Text="7"></asp:TextBox>
    <asp:Button ID="btnSend" runat="server" Text="Send JSON" OnClick="btnSend_OnClick" />

</asp:Content>
