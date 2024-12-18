using System.ComponentModel.DataAnnotations;

namespace Gambl.Models
{
    public class CourseInfo
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? CourseCategory { get; set; }
        public string? CourseExplain { get; set; }
        public string? CourseInstructor { get; set; }
    }
    
}