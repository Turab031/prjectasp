using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcapp.Models;

namespace mvcapp.Controllers
{

    public class DashboardController(AppDbContext _context) : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        public IActionResult RedirectToEmployeeForm()
        {
            return RedirectToAction("AddEmployee");
        }


    }
}