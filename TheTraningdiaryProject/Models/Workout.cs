using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTraningdiaryProject.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime WorkoutDate { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
        public User user { get; set; }
    }
}
