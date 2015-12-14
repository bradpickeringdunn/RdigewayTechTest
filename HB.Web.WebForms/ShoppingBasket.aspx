<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingBasket.aspx.cs" Inherits="HB.Web.WebForms.ShoppingBasket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="shoppingBasketForm" runat="server">

        <asp:GridView ID="shoppingBasket" runat="server" Caption="1st Grid: Simple GridView with SqlDataSource"
     autogeneratecolumns="false" >
      <Columns>
          <asp:BoundField DataField="Name" HeaderText="DealID" />
          <asp:BoundField DataField="Description" HeaderText="DealID" />
          <asp:BoundField DataField="Price" HeaderText="DealID" />
         <asp:TemplateField HeaderText="">
            <ItemTemplate>
                <asp:LinkButton ID="lnk1" runat="server" Text="Buy" 
                    
                    CommandArgument='<%#Eval("Id")%>'
                    CommandName="Remove"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
      </Columns>
    </asp:GridView>
    </form>

</body>
</html>
