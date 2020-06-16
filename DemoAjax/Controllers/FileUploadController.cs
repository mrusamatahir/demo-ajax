using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DemoAjax.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Web;
using Microsoft.AspNetCore.Server;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Components.Server;
using DemoAjax.VMs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DemoAjax.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly IWebHostEnvironment env;

        public FileUploadController(IWebHostEnvironment env)
        {
            this.env = env;
        }
        public IHttpContextAccessor Http { get; }

        public ActionResult UploadFiles()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFiles(List<DemoVM> vm)
        {
            string p = Path.Combine(env.WebRootPath, "Images");
            string img = "";
            string newFileName = "";
            int count = 0;
            foreach (var item in vm)
            {
                foreach (var file in item.Files)
                {
                    count += 1;
                    newFileName = item.Reg.ToString() + "_" + count.ToString();
                    img = Path.Combine(p, newFileName);
                    file.CopyTo(new FileStream(img, FileMode.Create));
                }
                count = 0;
            }
            return View();
        }
    }
}
