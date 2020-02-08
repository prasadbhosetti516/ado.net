<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlWebForm1.aspx.cs" Inherits="controls.ControlWebForm1" %>

<asp:Content ID="id122" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
       
        <asp:Label ID="Label1" runat="server" Text="Enter first name"></asp:Label>
        <br />
       
         <asp:TextBox ID="TextBox1" runat="server" Width="257px"></asp:TextBox>
        <br />

          <asp:Label ID="Label7" runat="server" Text="Enter middle name"></asp:Label>
        <br />

         <asp:TextBox ID="TextBox2" runat="server" Width="257px"></asp:TextBox>
        <br />

          <asp:Label ID="Label8" runat="server" Text="Enter last name"></asp:Label>
        <br />

        <asp:TextBox ID="txtName" runat="server" Width="257px"></asp:TextBox>
        <br />
        
        <asp:Label ID="Label2" runat="server" Text="Enter DOB"></asp:Label>
         <br />
       <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
       
        <asp:Label ID="Label3" runat="server" Text="Gender:"></asp:Label>
       
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>male</asp:ListItem>
            <asp:ListItem>female</asp:ListItem>
            <asp:ListItem>other</asp:ListItem>
        </asp:RadioButtonList>
        
        <br />
       
        <asp:Label ID="Label4" runat="server" Text=" Hobbies:"></asp:Label>
        <br />
       
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            <asp:ListItem>DANCING</asp:ListItem>
            <asp:ListItem>SINGING</asp:ListItem>
            <asp:ListItem>ROAMING</asp:ListItem>
            <asp:ListItem>PLAYING</asp:ListItem>
            <asp:ListItem>EATING</asp:ListItem>
        </asp:CheckBoxList>
        <br />
       
        <asp:Label ID="Label5" runat="server" Text="Education:"></asp:Label>
        <br />
        
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="193px">
            <asp:ListItem>SSC</asp:ListItem>
            <asp:ListItem>HSC</asp:ListItem>
            <asp:ListItem>BTECH</asp:ListItem>
        </asp:DropDownList>
       
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
   
        </div>
    
   
    
    <div class="jumbotron">
        <asp:Label ID="Label6" runat="server" Text="displaying registered data"></asp:Label>

    </div>
   
</asp:Content>