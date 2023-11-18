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

      
    }
}