using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraningDiary.Models;
using TraningDiary.Repository;
using TraningDiary.ViewModels;
using Microsoft.Extensions.Logging;
using AutoMapper;
using System.Runtime.Serialization;
using System.Net;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TraningDiary.Controllers.Api
{
    [Route("api/workouts/{id}/type")]
    public class WorkoutTypeApiController : Controller
    {
        private ITraningDiaryRepository _repository;
        private ILogger<WorkoutTypeApiController> _logger;

        public WorkoutTypeApiController(ITraningDiaryRepository repository, ILogger<WorkoutTypeApiController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("")]
        public JsonResult Get(int Id)
        {
            try
            {
                var result = _repository.getWorkoutById(Id);

                if (result == null)
                {
                    return Json(null);
                }

                return Json(Mapper.Map<IEnumerable<WorkoutTypeViewModel>>(result.workoutType));
            }

            catch (Exception ex)
            {
                _logger.LogError("Faild to get workout types", ex);
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Error occurd finding  types");
            }
        }
    }
}

