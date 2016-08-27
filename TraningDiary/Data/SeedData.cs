using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraningDiary.Models
{
    public class SeedData
    {
        private TraningDiaryDbContext _context;
        private UserManager<User> _userManger;

        public SeedData(TraningDiaryDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManger = userManager;
        }

        public void addData()
        {

            //if (await _userManger.FindByEmailAsync("johan656@hotmail.se") == null)
            //{
            //    // Add User
            //    var user = new User()
            //    {
            //        Name = "Johan Öhberg",
            //        Age = 22,
            //        Gender = "Male",
            //        Length = 183,
            //        Weight = 73,
            //        UserName = "johan656",
            //        Email = "johan656@hotmail.se"
            //    };

            //    await _userManger.CreateAsync(user, "stella93");
            //}

            if (!_context.Workout.Any())
            {
                var workout1 = new Workout()
                {
                    Title = "Ett MTB Pass",
                    WorkoutDate = new DateTime(2016, 06, 20),
                    Status = 1,
                    Comment = "Ett Skönt MTB-pass i skogen",
                    workoutType = new List<WorkoutType>()
                    {
                        new WorkoutType {
                        Type = "Speed",
                        Activity = "MTB",
                        Quantity = 5,
                        Length = 3.0,
                        }
                    },

                    username = "johanohberg6@oru.se"

                };

                _context.Workout.Add(workout1);
                _context.WorkoutType.AddRange(workout1.workoutType);
                _context.SaveChanges();
            }

        }
    }
}
