using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraningDiary.Models;
using TraningDiary.Repository;
using TraningDiary.ViewModels;
using System.Net;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace TraningDiary.Controllers.Api
{
    [Authorize]
    public class WorkoutApiController : Controller
    {
        private readonly ILogger _logger;
        private ITraningDiaryRepository _repository;

        public WorkoutApiController(ITraningDiaryRepository repository, ILogger<WorkoutApiController> logger)
        {
            _repository = repository;
            _logger = logger;

        }

        [HttpGet("api/workouts")]
        public JsonResult Get()
        {
            try
            {
                // var workouts = _repository.getUserWorkout(User.Identity.Name);
                var workouts = _repository.getAllWorkout(); 
                var result = Mapper.Map<IEnumerable<WorkoutViewModel>>(workouts);
                return Json(result);
            }

            catch (Exception ex)
            {
                return Json(new { Message = ex.Message });
            }
        }

        [HttpGet("api/workouts/{id}")]
        public JsonResult Get(int id)
        {
            try
            {
                var workout = _repository.getWorkoutById(id);
                var result = Mapper.Map<IEnumerable<WorkoutViewModel>>(workout);
                return Json(result);
            }

            catch (Exception ex)
            {
                return Json(new { Message = ex.Message });
            }
        }

        [HttpPost("api/workouts")]
        public JsonResult Post([FromBody]WorkoutViewModel vm)
        {
            try {
                if (ModelState.IsValid)
                {
                    // Map from VM to model so we can save it in database 
                    var newWorkout = Mapper.Map<Workout>(vm);

                    newWorkout.username = User.Identity.Name;

                    // Save to the Database
                    _logger.LogInformation("Attemting to save a new workout to the database");
                    _repository.addWorkout(newWorkout);

                    if (_repository.saveAll())
                        {

                        Response.StatusCode = (int)HttpStatusCode.Created;
                        return Json(Mapper.Map<WorkoutViewModel>(newWorkout));
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Could not post to the database", ex);
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { Message = ex.Message });
            }
                Response.StatusCode =(int) HttpStatusCode.BadRequest;
                return Json( new { message = "Faild" , ModelState = ModelState});
            }
        }
    }

