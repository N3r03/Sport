using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportLife.Models;

namespace SportLife.Controllers
{
    public class SportController : Controller
    {
        // GET: Sport
        public ActionResult Index()
        {
            PlayersContext PlayersContext = new PlayersContext();
            List<Sport> Sports = PlayersContext.Sports.ToList();
            return View(Sports);

        }
       
    }
}