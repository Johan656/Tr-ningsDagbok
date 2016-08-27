using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraningDiary.Models;
using Microsoft.EntityFrameworkCore;
using TraningDiary.ViewModels;
using TraningDiary.Repository;
using Microsoft.AspNetCore.Authorization;

namespace TraningDiary.Controllers
{
    [Authorize]
    public class WorkoutController : Controller
    {
        private ITraningDiaryRepository _repository;

        public WorkoutController(ITraningDiaryRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var workout = _repository.getAllWorkout();
            return View(workout);
        }

        public IActionResult AddWorkout()
        {
            TestViewModel testViewModel = new TestViewModel();
            return View(testViewModel);
        }

        public IActionResult OverView()
        {
            var workout = _repository.getAllWorkout();
            return View(workout);
        }

        public IActionResult Calendar()
        {
            return View();
        }
    }
}
