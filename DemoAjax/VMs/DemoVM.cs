using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAjax.VMs
{
    public class DemoVM
    {
        public string Name { get; set; }
        public int Reg { get; set; }
        public List<IFormFile> Files { get; set; }
    }
}
