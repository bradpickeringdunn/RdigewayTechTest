<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingBasket.aspx.cs" Inherits="HB.Web.WebForms.ShoppingBasket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="shoppingBasketForm" runat="server">

        <asp:GridView ID="shoppingBasket" runat="server" Caption="Shopping basket"
     autogeneratecolumns="false" >
      <Columns>
          <asp:BoundField DataField="Name" HeaderText="Name" />
          <asp:BoundField DataField="Description" HeaderText="Description" />
          <asp:BoundField DataField="Price" HeaderText="Price" />
         
      </Columns>
    </asp:GridView>
    </form>

</body>
</html>
