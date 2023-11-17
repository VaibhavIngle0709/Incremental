using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetapp.Controllers
{
     [Route("[controller]")]
    public class NewHomeController : Controller
    {
      
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

      
    }
}