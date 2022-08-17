using Beryllium.Models;
using Beryllium.ViewModels;
using Microsoft.EntityFrameworkCore;
using Beryllium.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IActionResult> Index()
        {
            IndexViewModel ivm = new IndexViewModel()
            {
                architectureImages = await db.ArchitectureImages.ToListAsync(),
                works = await db.Works.ToListAsync(),
                news = await db.News.ToListAsync(),
                testimonials = await db.Testimonials.ToListAsync(),
                features = await db.Features.ToListAsync(),
            };
            return View(ivm);

        }
        public IActionResult Contact()
        {
            return View();
        }
        public async Task<IActionResult> SendMessage(Message msg)
        {
            if (ModelState.IsValid)
            {
                msg.Date = DateTime.Now;
                await db.Messages.AddAsync(msg);
                await db.SaveChangesAsync();
                TempData["result"] = "Message Sent.";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["result"] = "Message was not Send.";
                return RedirectToAction("Index");
            }
        }
    }
}
