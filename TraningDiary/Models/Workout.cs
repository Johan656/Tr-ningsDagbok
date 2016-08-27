using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TraningDiary.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime WorkoutDate { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
        public ICollection<WorkoutType> workoutType { get; set; }
        public string username { get; set; }
    }
}
