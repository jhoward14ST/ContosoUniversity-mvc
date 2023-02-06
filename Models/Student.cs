using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    // howarj9 - mvc1
    public class Student : Person
    {
        /* howarj9 - mvc9 
         Added : Person so that Student is derived from that class and removed reduntant statements */
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}