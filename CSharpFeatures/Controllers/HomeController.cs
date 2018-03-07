using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpFeatures.Models;

namespace CSharpFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        public ViewResult AutoProperty()
        {
            Product myProduct = new Product();

            myProduct.Name = "Peter";

            string productName = myProduct.Name;

            return View("Result", (object) String.Format("Product Name: {0}", productName));
        }
    }
}