using Backbone.Logging;
using Backbone.Utilities;
using HB.Web.Shared.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HB.Web.Mvc.Controllers
{
    public class BaseController : Controller
    {
        public IProductServiceContract ProductService { get; private set; }
        public ILogger Logger { get; private set; }

        public BaseController(ILogger logger, IProductServiceContract productService)
        {
            Guardian.ArgumentNotNull(logger, "logger");
            Guardian.ArgumentNotNull(productService, "productService");

            this.ProductService = productService;
            this.Logger = logger;
        }
    }
}