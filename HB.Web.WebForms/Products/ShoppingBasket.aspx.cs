using Backbone.Logging;
using HB.Services.Models.Products.Dto;
using HB.Services.Models.Products.Requests;
using HB.Services.Models.Products.Results;
using HB.Web.Shared.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HB.Web.WebForms
{
    public partial class ShoppingBasket : System.Web.UI.Page
    {
        private readonly IProductServiceContract productService = new HB.Web.Shared.ProductService.ProductServiceContractClient();
        private ILogger logger = new DebugLogger();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var productIds = (List<int>)Session["products"];

                var productResult = new LoadProductsResult();

                productResult = productService.LoadProductsBy(new LoadProductsRequest(new ProductFilterDto()
                {
                    ProductIds = productIds
                }));

                var products = (from product in productResult.Products
                                select new
                                {
                                    Name = product.Name,
                                    Description = product.Description,
                                    Price = product.Price.ToString("C", Shared.Localization.Cultures.UnitedKingdom)
                                });

                shoppingBasket.DataSource = products;
                shoppingBasket.DataBind();
            }
        }
    }
}