using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraningDiary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using Microsoft.Extensions.Logging;

namespace TraningDiary.Repository
{
    public class TraningDiaryRepository : ITraningDiaryRepository
    {
        private TraningDiaryDbContext _context;
        private ILogger<TraningDiaryRepository> _logger;

        public TraningDiaryRepository(TraningDiaryDbContext context, ILogger<TraningDiaryRepository> logger)
        {
            _context = context;
            _logger = logger; 
        }

        public void addWorkout(Workout newWorkout)
        {
            _context.Add(newWorkout);
        }

        public IEnumerable<Workout> getAllWorkout()
        {
            try
            {
                //return _context.WorkoutType.Include(w => w.workout).ToList();
                return _context.Workout.Include(w => w.workoutType).ToList();
            }

            catch(Exception ex)
            {
                _logger.LogError("Could not get Workout from database", ex);    
                return null;
            }
        }

        public IEnumerable<WorkoutType> getAllWorkoutTypes()
        {
            try
            {
                return _context.WorkoutType.ToList();
            }

            catch (Exception ex)
            {
                _logger.LogError("Could not get Workout from database", ex);
                return null;
            }
        }

        public IEnumerable<Workout> getUserWorkouts(string name)
        {
            return _context.Workout.Include(w => w.workoutType)
                .Where(w => w.username == name).ToList();
        }

        public Workout getWorkoutById(int id)
        {
            return _context.Workout.Include(w => w.workoutType)
                .Where(w => w.Id == id)
                .FirstOrDefault();
        }

        public bool saveAll()
        {
            return _context.SaveChanges() > 0;
        }

    }
}
