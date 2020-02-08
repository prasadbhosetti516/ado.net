<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TraineeApp.WebForm1" %>

<asp:Content ID="myid" ContentPlaceHolderID="MainContent" runat="server">



    <div class="jumbotron">
        <br />
        <asp:Label ID="Label1" runat="server" Text="tid"></asp:Label> <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="not exceed 1" ControlToValidate="TextBox1" MaximumValue="50" MinimumValue="1" ValidationGroup="vg" ForeColor="#FF3300" Type="Integer"></asp:RangeValidator><br />
           <asp:Label ID="Label2" runat="server" Text="tname"></asp:Label> <br />
          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="name must include" ControlToValidate="TextBox2" ValidationGroup="vg"></asp:RequiredFieldValidator><br />
           <asp:Label ID="Label3" runat="server" Text="location"></asp:Label> <br />
          <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> <br />
           <asp:Label ID="Label4" runat="server" Text="techdomain"></asp:Label> <br />
          <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> <br />
           <asp:Label ID="Label5" runat="server" Text="startdate"></asp:Label> <br />
          <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox> <br />
        <asp:Button ID="Button1" runat="server" Text="click" OnClick="Button1_Click" ValidationGroup="vg" /> <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="vg" />



    </div> 
</asp:Content>
