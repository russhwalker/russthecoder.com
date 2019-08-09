using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVCPostList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new Models.KidsViewModel
            {
                Kids = new List<Models.Kid>
                {
                    new Models.Kid
                    {
                        Name = "John",
                        Age = 3
                    },
                    new Models.Kid
                    {
                        Name = "Sally",
                        Age = 7
                    }
                }
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(Models.KidsViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}