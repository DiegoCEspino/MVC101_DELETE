using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC101.Controllers
{
    public class FilesController : Controller
    {
        public IActionResult Index()
        {
            string[] files = Directory.GetFiles(".\\TextFiles");
            return View(files);
        }

        public IActionResult Content(string id)
        {
            ViewBag.Content = System.IO.File.ReadAllText(".\\TextFiles\\" + id);
            return View();
        }
    }
}