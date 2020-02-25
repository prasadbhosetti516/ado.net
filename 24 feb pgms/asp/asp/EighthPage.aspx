<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EighthPage.aspx.cs" Inherits="asp.EighthPage" %>
<asp:Content ID="myid8" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:TextBox ID="TextBox1" runat="server" Text="Cid"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="delete" OnClick="Button1_Click" />
    </div>

</asp:Content>

