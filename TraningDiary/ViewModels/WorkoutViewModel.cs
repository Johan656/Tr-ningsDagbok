using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraningDiary.Models;
using TraningDiary.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace TraningDiary.ViewModels
{
    public class WorkoutViewModel
    {
        public int Id { get; set; }

       // [Required]
        [StringLength(255, MinimumLength = 2)]
        public string Title { get; set; }

        public DateTime WorkoutDate { get; set; } = DateTime.UtcNow;

        public int Status { get; set; }

        //[Required]
        [StringLength(500, MinimumLength = 2)]
        public string Comment { get; set; }

      //  [Required]
        public ICollection<WorkoutType> workoutType { get; set; }

    }
}
