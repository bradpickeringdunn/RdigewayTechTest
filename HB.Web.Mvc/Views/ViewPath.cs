using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HB.Web.Mvc.Views
{
    public static class ViewPath
    {
        public static class Products
        {
            public const string ProductCategories = "~/views/Products/ProductCategories.cshtml";
            public const string Books = "~/views/products/Books.cshtml";
            public const string Movies = "~/views/products/Movies.cshtml";
        }

        public static class ShoppingBasket
        {
            public const string ViewMyBasket = "~/views/ShoppingBasket/ViewMyBasket.cshtml";
        }


    }
}