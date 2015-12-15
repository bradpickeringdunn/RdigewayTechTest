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
            var productIds = (List<int>)Session["products"];

            var productResult = new LoadProductsResult();

            using(var service = new ProductServiceContractClient()) {

                productResult = productService.LoadProductsBy(new LoadProductsRequest(new ProductFilterDto()
                {
                    ProductIds = productIds
                }));
            }
        

            shoppingBasket.DataSource = productResult.Products;
            shoppingBasket.DataBind();
        }
    }
}