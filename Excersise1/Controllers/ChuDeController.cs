using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excersise1.Models;

namespace Excersise1.Controllers
{
    public class ChuDeController : Controller
    {
        // GET: ChuDe

        QLBANSACHEntities db = new QLBANSACHEntities();
        public ActionResult Index()
        {
            var All_ChuDe = from tt in db.CHUDEs select tt;
            return View(All_ChuDe);
        }
    }
}