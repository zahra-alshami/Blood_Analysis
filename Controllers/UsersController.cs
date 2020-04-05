using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blood_Analysis.Data;
using Blood_Analysis.Models;

namespace Blood_Analysis.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        UserContext db = new UserContext();
        public ActionResult Index()
        {
            return View();
        }
    }
}