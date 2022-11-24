using Karpatus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karpatus.Controllers
{
    public class PlaceController : Controller
    {
        private readonly AppDBContext db;

        public IActionResult Index()
        {
            return View("Place");
        }
        public PlaceController(AppDBContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Place()
        {
            return View(await db.PlaceTabl.ToListAsync());
        }
    }
}
