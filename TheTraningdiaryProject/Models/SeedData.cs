using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheTraningdiaryProject.Models;
using Microsoft.AspNet.Mvc;


namespace TheTraningdiaryProject.Models
{
    public class SeedData
    {
        private ApplicationDbContext _context;

        public SeedData(ApplicationDbContext context)
        {
            _context = context;
        }

        public void addData()
        {

            if (!_context.Workout.Any() && !_context.WorkoutType.Any() && !_context.User.Any())
            {
                var workoutType1 = new WorkoutType()
                {
                    speed = new Speed()
                    {
                        Activity = "MTB",
                        Quantity = 5,
                        Length = 3.0
                    },
                    workout = new Workout()
                    {
                        Title = "Ett MTB Pass",
                        WorkoutDate = new DateTime(2016, 06, 20),
                        Status = 1,
                        Comment = "Ett Skönt MTB-pass i skogen",
                        user = new User()
                        {

                            Name = "Johan Öhberg",
                            Age = 22,
                            Gender = "Male",
                            Length = 183,
                            Weight = 73,
                        }
                    }
                    
                };

                _context.WorkoutType.Add(workoutType1);
                _context.Speed.AddRange(workoutType1.speed);
                _context.Workout.AddRange(workoutType1.workout);
                _context.User.AddRange(workoutType1.workout.user);
                _context.SaveChanges();
            }


        }

    }
}
