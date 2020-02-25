<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Firstpage.aspx.cs" Inherits="asp.Firstpage" %>
<asp:Content ID="myid1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

 <br />
        <asp:Label ID="Label1" runat="server" Text="Sid"></asp:Label> <br />
       
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
           <asp:Label ID="Label2" runat="server" Text="Sname"></asp:Label> <br />
         
       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> <br />
           <asp:Label ID="Label3" runat="server" Text="Sgender"></asp:Label> <br />
          <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> <br />
         <asp:Button ID="Button1" runat="server" Text="click" OnClick="Button1_Click" ValidationGroup="vg" /> <br />
    </div>


</asp:Content>
