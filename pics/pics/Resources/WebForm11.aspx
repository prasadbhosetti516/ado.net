<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="pics.Resources.WebForm11" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="upload" OnClick="Button1_Click"  /></asp:button>
         <br />
        <br />

        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
            <ItemTemplate>
                
                    <asp:Image ID="Image1"
                      Imageurl='<%# Eval("Name","~/Resources/{0}") %>'
Width="350px" Height="350px" runat="server" />
                <br />
                <%# Eval("Name") %>
                    </asp:Image>




            </ItemTemplate>



        </asp:DataList>

    </div>
</asp:Content>
