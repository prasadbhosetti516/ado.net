<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NinthPage.aspx.cs" Inherits="asp.NinthPage" %>
<asp:Content ID="myid9" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:TextBox ID="TextBox1" runat="server" Text="Fid"></asp:TextBox><br />
        <asp:TextBox ID="TextBox2" runat="server" Text="Fname"></asp:TextBox><br />
        <asp:TextBox ID="TextBox3" runat="server" Text="Faddr"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
    </div>
</asp:Content>