using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAjax.VMs;
using Microsoft.AspNetCore.Mvc;


namespace DemoAjax.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(List<DemoVM> vm)
        {

            return RedirectToAction("Index");
        }
    }
}
