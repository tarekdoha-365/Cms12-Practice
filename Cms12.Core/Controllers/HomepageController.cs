using Cms12.Core.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms12.Core.Controllers
{

    public class HomepageController: PageController<Homepage>
    {
        public IActionResult Index(Homepage currentpage)
        {
            return View(currentpage);
        }
    }
}
