using Karpatus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Karpatus.Controllers
{
    public class CardusController : Controller
    {
        public IActionResult Cardus()
        {
            return View();
        }
    }
}
