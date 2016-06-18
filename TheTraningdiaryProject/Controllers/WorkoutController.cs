using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TheTraningdiaryProject.Models;

namespace TheTraningdiaryProject.Controllers
{
    public class WorkoutController : Controller
    {
        private ApplicationDbContext _context;

        public WorkoutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OverView()
        {
            return View();
        }

        public IActionResult AddWorkout()
        {
            return View();
        }


    }
}
