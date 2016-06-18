using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TheTraningdiaryProject.Models
{
    // Add profile data for application users by adding properties to the User class
    public class User 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
    }
}
