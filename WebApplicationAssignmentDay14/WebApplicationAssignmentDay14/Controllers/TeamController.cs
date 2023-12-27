using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationAssignmentDay14.Models;

namespace WebApplicationAssignmentDay14.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            List<Team> teams = new List<Team>
            {
                new Team { TeamId = 1, TeamName = "Australia", NumberOfWorldCups = 3 },
                new Team { TeamId = 2, TeamName = "India", NumberOfWorldCups = 2 },
                new Team { TeamId = 3, TeamName = "SriLanka", NumberOfWorldCups = 1 }
            };
            return View(teams);
        }
    }
}