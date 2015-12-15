using Backbone.Logging;
using HB.Web.Shared.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace HB.Web.WebForms.Products
{
    public partial class ProductBooks : System.Web.UI.Page
    {
        private readonly IProductServiceContract productService = new HB.Web.Shared.ProductService.ProductServiceContractClient();
        private ILogger logger = new DebugLogger();
                
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var productResult = productService.LoadBooks();

                var products = from product in productResult.Books
                               select new
                               {
                                   Id = product.Id,
                                   Name = product.Name,
                                   Description = product.Description,
                                   Price = product.Price.ToString("C", Shared.Localization.Cultures.UnitedKingdom),
                                   Author = product.Author,
                                   ISBN = product.ISBN,
                                   Pagecount = product.PageCount
                               };

                ProductGrid.DataSource = products;
                ProductGrid.DataBind();
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
            else
            {
                logger.Error("Selected product is not an int.");
            }

            var url = VirtualPathUtility.ToAbsolute("~/products/ShoppingBasket");
            Response.Redirect(url);
        }
    }
}