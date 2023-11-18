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
            List<Player> pe=new List<Player>();
            
            var data2=context.Teams.Find(id);
            string teamName=data2.TeamName;
            

            for(int i=0;i< data.Count;i++)
            {
                if(data[i].TeamId==id)
                {
                    pe.Add(data[i]);
                }
            }
            ViewModel viewModel=new ViewModel
            {
                p=pe,
                TeamName=teamName

            };
            return View(viewModel);
        }

      
    }
}