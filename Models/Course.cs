using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Course ID")]
        public int CourseID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public Course() 
        { 
            Enrollments = new List<Enrollment>();
            CourseAssignments = new List<CourseAssignment>();
        }
    }
}