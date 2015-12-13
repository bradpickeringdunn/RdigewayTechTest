<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingBasket.aspx.cs" Inherits="HB.Web.WebForms.ShoppingBasket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="productsFrm" runat="server">

        <asp:GridView ID="GridView1" runat="server" Caption="1st Grid: Simple GridView with SqlDataSource"
     AllowPaging="True"  PageSize="8">
      <Columns>
        <asp:TemplateField HeaderText="Delete?">
            <ItemTemplate>
                <asp:LinkButton ID="lnk1" runat="server" Text="Delete" OnClientClick="return confirm('Are you sure to Delete?')" CommandName="Delete"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
      </Columns>
    </asp:GridView>
    </form>
</body>
</html>
