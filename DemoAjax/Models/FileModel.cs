using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace DemoAjax.Models
{
    public abstract class HttpPostedFileBase
    {
        internal void SaveAs(string serverSavePath)
        {
            throw new NotImplementedException();
        }
    }
    public class FileModel
    {
        [Required(ErrorMessage = "Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] files { get; set; }
    }
}
