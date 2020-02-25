<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ThirdPage.aspx.cs" Inherits="asp.ThirdPage" %>

<asp:Content ID="myid3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

        <asp:Label ID="Label1" runat="server" Text=" Sid"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
          <asp:Label ID="Label2" runat="server" Text="Sname"></asp:Label><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" runat="server" Text="CLICK TO UPDATE" OnClick="Button1_Click" /><br />
    </div>
    </asp:Content>