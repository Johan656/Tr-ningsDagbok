using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraningDiary.ViewModels
{
    public class WorkoutTypeViewModel
    {
        public int Id { get; set; }

        // [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Type { get; set; }

        public string Activity { get; set; }
        public int Intensity { get; set; }
        public int Quantity { get; set; }
        public double Length { get; set; }
    }
}
