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


        public IActionResult Index()
        {
            var data=context.Players.ToList();
            return View (data);
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

        public IActionResult Create(Player p)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

    }
}

