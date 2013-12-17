using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TogglApi.Models;

namespace TogglApi.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            TogglAuthRequest auth = new TogglAuthRequest {
                ApiToken = "67be300bcfc9c09f40636074303ce3ff"
            };

            TogglApi api = new TogglApi(auth);
            var val = api.Users.GetCurrent();

            var clients = api.Clients.Get();

            ViewBag.Content = val.ToString();

            return View();
        }

    }
}
