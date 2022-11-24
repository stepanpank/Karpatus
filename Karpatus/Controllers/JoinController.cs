using Karpatus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karpatus.Controllers
{
    public class JoinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly AppDBContext db;

        public JoinController(AppDBContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Join()
        {
            return View(await db.JoinTabl.ToListAsync());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(JoinTablModel dop)
        {
            db.JoinTabl.Add(dop);
            await db.SaveChangesAsync();
            return RedirectToAction("Event");
        }
    }
}
