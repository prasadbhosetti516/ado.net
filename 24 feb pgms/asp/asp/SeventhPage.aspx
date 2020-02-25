<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SeventhPage.aspx.cs" Inherits="asp.SeventhPage" %>
<asp:Content ID="myid7" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:TextBox ID="TextBox1" runat="server" Text="Cid"></asp:TextBox><br />
        <asp:TextBox ID="TextBox2" runat="server" Text="Cname"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="click" OnClick="Button1_Click" /><br />
    </div>
</asp:Content>
