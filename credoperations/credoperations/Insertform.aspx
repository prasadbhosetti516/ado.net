<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Insertform.aspx.cs" Inherits="credoperations.Insertform" %>
<asp:Content id="cid" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lable1" runat="server" Text="enter student id"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox><br/>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>

