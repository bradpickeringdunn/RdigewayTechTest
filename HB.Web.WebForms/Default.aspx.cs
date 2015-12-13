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
                var url = VirtualPathUtility.ToAbsolute("~/Products/products?");

                var categoryListItem = new HtmlGenericControl("li");
                var categoryListLink = new HtmlGenericControl("a");
                categoryListLink.Attributes.Add("href", url + "categoryId=" + category.Id);

                categoryListLink.InnerText = category.Name;
                categoryListItem.Controls.Add(categoryListLink);

                productcategories.Controls.Add(categoryListLink);
            }
                
        }
    }
}