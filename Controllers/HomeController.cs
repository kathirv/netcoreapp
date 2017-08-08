using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcoreApp.Models;

namespace netcoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            // ViewData["Message"] = "Your application description page.";
            EmployeeContext _context = new EmployeeContext();
            List<EmpMaster> _master = (from p in _context.EmpMaster select p).ToList();

            return View(_master);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
