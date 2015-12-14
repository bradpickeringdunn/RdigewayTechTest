using Backbone.Logging;
using HB.Services.Models.Products.Dto;
using HB.Services.Models.Products.Requests;
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
            int categoryId;

            if(int.TryParse(Request.QueryString["categoryId"], out categoryId))
            {
                var productResult = productService.LoadProductsBy(
                    new LoadProductsRequest(
                        new ProductFilterDto()
                        {
                            CategoryId = categoryId
                        }
                    )
                );

                var products = from product in productResult.Products
                               select new
                               {
                                   Id = product.Id,
                                   Name = product.Name,
                                   Description = product.Description,
                                   Price = product.Price
                               };

                //var dataTable = new DataTable();
                //dataTable.Columns.Add("Product name");
                //dataTable.Columns.Add("Description");
                //dataTable.Columns.Add("Price");
                //dataTable.Columns.Add(" ");

                //foreach (var product in productResult.Products)
                //{

                //    //var link = new LinkButton()
                //    //{
                //    //    CommandName ="Buy",
                //    //    = "AddToBasket_Click"
                //    //    CommandArgument = product.Id.ToString()
                //    //};

                //    var row = dataTable.NewRow();
                //    row["Product name"] = product.Name;
                //    row["Description"] = product.Description;
                //    row["Price"] = product.Price;
                //    row[" "]

                //    var categoryListLink = new HtmlGenericControl("a");
                //    categoryListLink.Attributes.Add("href", "#");
                //    categoryListLink.InnerText = "Buy";

                //    var url = VirtualPathUtility.ToAbsolute("~/Products/products?");

                //    dataTable.Rows.Add(row);

                //}

                GridView1.DataSource = products;
                GridView1.DataBind();
            }
        }

        protected void AddToBasket_Click(object sender, EventArgs e)
        {
            var control = sender as LinkButton;
            var selectedProduct = control.CommandArgument;
            int productId;

            if (int.TryParse(selectedProduct, out productId))
            {
                var existingProducts = (List<int>)Session["products"];
                if (existingProducts.IsNotNull())
                {
                    existingProducts.Add(productId);
                }
                else
                {
                    existingProducts = new List<int>() { productId };
                }

                Session["products"] = existingProducts;
            }
           
            var url = VirtualPathUtility.ToAbsolute("~/ShoppingBasket");
            Response.Redirect(url);
        }
    }
}