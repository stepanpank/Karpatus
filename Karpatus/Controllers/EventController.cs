using Karpatus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karpatus.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly AppDBContext db;

        public EventController(AppDBContext context)
        {
            db = context;
        }
       
        public async Task<IActionResult> Event()
        {
            return View(await db.EventTabl.ToListAsync());
        }
        
        
    }
}
