using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
  
    public class TeamController : Controller
    {
        private readonly ApplicationDbContext context;

        public TeamController(ApplicationDbContext _context)
        {
            context=_context;
        }
        [Route("TeamIndex")]
        public IActionResult TeamIndex()
        {
            var data=context.Teams.ToList();
            return View(data);
        }

        public IActionResult CreateTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTeam(Team t)
        {
            context.Teams.Add(t);
            context.SaveChanges();
            return RedirectToAction("TeamIndex");
        }

        public IActionResult ViewPlayers(int id)
        {
            var data=context.Players.ToList();
            List<Player> p=new List<Player>();

            List<Team> t=new List<Team>();
            

            for(int i=0;i< data.Count;i++)
            {
                if(data[i].TeamId==id)
                {
                    p.Add(data[i]);
                }
            }
            YourViewModel viewModel=new YourViewModel
            {
                PlayersList=p,


            };
            return View(p);
        }

      
    }
}