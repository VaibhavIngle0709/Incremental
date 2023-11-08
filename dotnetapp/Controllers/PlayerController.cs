using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext context;

        public PlayerController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public IActionResult Edit(int id)
        {
            var data=context.Players.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Player p)
        {
            var data=context.Players.ToList();
            return View();
        }
    }
}

