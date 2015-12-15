using Backbone.Logging;
using HB.Services.Models.Products.Dto;
using HB.Web.Shared.Actions.Products;
using HB.Web.Shared.ProductService;
using HB.Web.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HB.Web.WebForms
{
    public partial class _Default : Page
    {
        private static IDictionary<int, string> productPages;

        protected void Page_Load(object sender, EventArgs e)
        {
            var productService = new HB.Web.Shared.ProductService.ProductServiceContractClient();
            var logger = new DebugLogger();

            var model = new BaseViewModel<IList<ProductCategoryDto>>();

            model = new LoadProductCategoriesAction<dynamic>(logger, productService)
            {
                OnSuccess = (m) => { return m; ; }
            }.Execute();

            
            foreach (var category in model.Payload)
            {
                var productPage = GetProductPage(category.Id);

                var url = VirtualPathUtility.ToAbsolute("~/{0}".FormatLiteralArguments(productPage));

                var categoryListItem = new HtmlGenericControl("li");
                var categoryListLink = new HtmlGenericControl("a");
                categoryListLink.Attributes.Add("href", url);

                categoryListLink.InnerText = category.Name;
                categoryListItem.Controls.Add(categoryListLink);

                productcategories.Controls.Add(categoryListItem);
                
            }
                
        }

        private string GetProductPage(int categoryId)
        {
            string productPage = string.Empty;

            if (productPages.IsNull())
            {
                productPages = new Dictionary<int, string>();
                productPages.Add(1, "Products/ProductBooks");
                productPages.Add(2, "Products/ProductMovies");
            }

            if (productPages.ContainsKey(categoryId))
            {
                productPage = productPages[categoryId];
            }

            return productPage;

        }
    }
}