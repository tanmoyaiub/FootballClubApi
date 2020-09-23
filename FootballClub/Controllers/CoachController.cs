using FootballClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballClub.Controllers
{
    public class CoachController : Controller
    {
        // GET: Coach
        public ActionResult Index()
        {
            FinalDataContext context = new FinalDataContext();
            return View(context.Coaches.ToList());
        }
    }
}