<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TwelthPage.aspx.cs" Inherits="asp.TwelthPage" %>
<asp:Content ID="myid12" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:TextBox ID="TextBox1" runat="server" Text="Fid"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br />
    </div>
</asp:Content>
