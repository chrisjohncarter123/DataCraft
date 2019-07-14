using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataCraftConsoleApp;
using WebClient.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebClient.Controllers
{
    public class DataCraftController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            DataBlockGroup group = new DataBlockGroup();
            ViewBag.Group = group.ToString();

            DataCraftViewModel model = new DataCraftViewModel();
            return View(model);
        }
    }
}
