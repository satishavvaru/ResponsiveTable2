using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ResponsiveGrid3.Models;

namespace MVC_ResponsiveGrid3.Controllers
{
    public class DefaultController : Controller
    {
        ProtoEntities db = new ProtoEntities();

        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
	}
}