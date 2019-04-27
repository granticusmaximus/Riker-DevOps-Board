using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace riker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new ImportFiles());
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }

        public class ImportFiles
        {
            public List<string> Styles { get; set; }
            public List<string> Scripts { get; set; }

            public ImportFiles()
            {
                Styles = new List<string>();
                Scripts = new List<string>();
            }
        }
    }
}