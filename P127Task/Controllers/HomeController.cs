using Microsoft.AspNetCore.Mvc;
using P127Task.DAL;
using P127Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P127Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Slider> model = context.Sliders.ToList();
            return View(model);
        }
    }
}
