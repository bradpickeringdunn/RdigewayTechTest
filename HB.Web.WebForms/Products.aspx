<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="HB.Web.WebForms.Products.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="productsFrm" runat="server">

        <asp:GridView ID="GridView1" runat="server" Caption="1st Grid: Simple GridView with SqlDataSource"
     autogeneratecolumns="false" >
      <Columns>
          <asp:BoundField DataField="Name" HeaderText="DealID" />
          <asp:BoundField DataField="Description" HeaderText="DealID" />
          <asp:BoundField DataField="Price" HeaderText="DealID" />
         <asp:TemplateField HeaderText="">
            <ItemTemplate>
                <asp:LinkButton ID="lnk1" runat="server" Text="Buy" 
                    OnClick="AddToBasket_Click"
                    CommandArgument='<%#Eval("Id")%>'
                    CommandName="Buy"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
      </Columns>
    </asp:GridView>
    </form>

</body>
</html>


