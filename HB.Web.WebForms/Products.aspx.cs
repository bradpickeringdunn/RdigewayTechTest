using Backbone.Logging;
using HB.Web.Shared.ProductService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HB.Web.WebForms.Products
{
   
    public partial class Products : System.Web.UI.Page
    {
        private readonly IProductServiceContract productService = new HB.Web.Shared.ProductService.ProductServiceContractClient();
        private ILogger logger = new DebugLogger();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var categoryId = Request.QueryString["categoryId"];
            var productResult = productService.LoadProductsBy(new Services.Models.Products.Requests.LoadProductsRequest(new Services.Models.Products.Dto.ProductFilterDto() { CategoryId = 2}));
            

            var dataTable = new DataTable();
            dataTable.Columns.Add("Product name");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add(" ");

            foreach (var product in productResult.Products)
            {
                var row = dataTable.NewRow();
                row["Product name"] = product.Name;
                row["Description"] = product.Description;
                row["Price"] = product.Price;
               
                var categoryListLink = new HtmlGenericControl("a");
                categoryListLink.Attributes.Add("href", "#");
                categoryListLink.InnerText = "Buy";

                var url = VirtualPathUtility.ToAbsolute("~/Products/products?");
                row[" "] = "<a href='#' >Buy</a>";
                
                dataTable.Rows.Add(row);
                
            }

            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
    }
}