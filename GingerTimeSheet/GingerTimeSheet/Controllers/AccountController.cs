using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GingerTimeSheet.Controllers
{
 
    public class AccountController : Controller
    {   
        // GET: Account
        public ActionResult GetAccounts()
        {
            return View("Account");
        }
        public ActionResult GetAccountHeader()
        {
            return PartialView("_Header");
        }
    }
}