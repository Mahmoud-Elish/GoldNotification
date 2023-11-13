using GoldNotification.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GoldNotification.Controllers
{
    public class HomeController : Controller
    {
        private readonly GoldContext _context;
        public HomeController(GoldContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_context.Golds.ToList());
        }
        [HttpGet]
        public IActionResult GetUpdatedPrices()
        {
            var updatedPrices = _context.Golds.ToList();
            return Json(updatedPrices);
        }

    }
}