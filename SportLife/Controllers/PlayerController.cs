using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportLife.Models;

namespace SportLife.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index(int SportID)
        {
            PlayersContext PlayersContext = new PlayersContext();
            List<Players> Players = PlayersContext.Players.Where(p => p.SportID == SportID).ToList();
            return View(Players);
        }

        public ActionResult Details(int SportID)
        {
            PlayersContext PlayersContext = new PlayersContext();
            Players Players1 = PlayersContext.Players.Single(pl => pl.SportID == SportID);
            return View(Players1);
        }
    }
}