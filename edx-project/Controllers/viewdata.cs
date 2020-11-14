using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace edx_project.Controllers
{
    public class viewdata : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["SiteAdresi"] = "deneme.com";
            return View();
        }
    }
}
