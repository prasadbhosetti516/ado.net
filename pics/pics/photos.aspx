<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="photos.aspx.cs" Inherits="pics.photos" %>
asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="upload" OnClick="Button1_click" />
         <br />
        <br />

        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
            <ItemTemplate>
                
                    <asp:Image ID="Image1"
                      Imageurl='<%# Eval("Name","~/Resources/{0}") %>'
                        width="350px" height="350px" Runat="server" />
                <%# Eval("Name") %>


                    </asp:Image>asp:




            </ItemTemplate>



        </asp:DataList>

    </div>
</asp:Content>
