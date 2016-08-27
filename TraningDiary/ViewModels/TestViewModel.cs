using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraningDiary.Models;

namespace TraningDiary.ViewModels
{
    public class TestViewModel
    {
        // Workout
        public string Title { get; set; }
        public DateTime WorkoutDate { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
        public string username { get; set; }

        // WorkoutType
        public string Type { get; set; }
        public string Activity { get; set; }
        public int Intensity { get; set; }
        public int Quantity { get; set; }
        public double Length { get; set; }
    }
}
