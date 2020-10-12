using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String Welcome(String name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID {ID}");
        }
    }
}
