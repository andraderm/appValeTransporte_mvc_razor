using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppVT_MVC_Razor.Controllers
{
    public class SetoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
