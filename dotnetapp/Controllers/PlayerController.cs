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

        [Route("")]
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
       
        public IActionResult Create()
        {
            return View();
        }
        [Route("create")]
        [HttpPost]
        public IActionResult Create(Player p)
        {
            context.Players.Add(p);
            context.SaveChanges();
            return View();
        }

        public IActionResult Delete(int id)
        {
            var data=context.Players.Find(id);
            if(data==null)
            {
                return NotFound();
            }
            context.Players.Remove(data);
            context.SaveChanges();
            return View();
        }

    }
}

