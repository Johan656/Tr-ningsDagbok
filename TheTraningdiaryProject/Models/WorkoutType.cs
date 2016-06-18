using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTraningdiaryProject.Models
{
    public class WorkoutType
    {
        public int Id { get; set; }
        public Endurance endurance { get; set; }
        public Strength strength { get; set; }
        public Mobility mobility { get; set; }
        public Speed speed { get; set; }
        public Rest rest { get; set; }
        public Workout workout { get; set; }
    }
}
