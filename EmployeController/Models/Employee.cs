using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeController.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        public ApplicationUser TaskName { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}