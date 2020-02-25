<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EleventhPage.aspx.cs" Inherits="asp.EleventhPage" %>
<asp:Content ID="myid11" ContentPlaceHolderID="MainContent" runat="server">
    <div classs="jumbotron">
        <asp:TextBox ID="TextBox1" runat="server" Text="Fid"></asp:TextBox><br />
        <asp:TextBox ID="TextBox2" runat="server" Text="Fname"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" /><br />
    </div><br />
</asp:Content>
