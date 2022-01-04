using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StartBootStrap.Data;
using StartBootStrap.Models;
using StartBootStrap.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmHome model = new VmHome();
            model.Setting = _context.Settings.FirstOrDefault();
            model.Portfolios = _context.Portfolios.ToList();    
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
