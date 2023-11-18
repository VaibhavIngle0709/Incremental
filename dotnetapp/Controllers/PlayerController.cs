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

         [Route("ListPlayer")]
        public IActionResult Index()
        {
           var data=context.Players.ToList();
            // if(data.Count()==0)
            // {
            //     return View(data);
            // }
            return View (data);    
        }

        public IActionResult Display(int id)
        {
           var data=context.Player.ToList();
           if(data==null)
           {
                return NotFound("NO DATA FOUND WITH ID "+id);
           }
           return View(data); 
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
        [Route("create")]
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
            return View(data);
        }
        
       
        public IActionResult DeleteConfirmed(int id)
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

