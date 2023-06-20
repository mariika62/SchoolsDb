using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class Class
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Major { get; set; }
        [Required]
        public string ClassTeacher { get; set; }
        [Range(2, 6, ErrorMessage = "the average grade must be between 2 and 6")]
        public double? AverageGrade { get; set; }
        public List<Student> Students { get; set; }
        public School School { get; set; }

        [ForeignKey("School")]
        public string SchoolId { get; set; }
        private Class()
        {
            Students = new List<Student>();
        }

        public Class(string name, string classTeacher, School school, string major = null, double? averageGrade = null)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Major = major;
            ClassTeacher = classTeacher;
            AverageGrade = averageGrade;
            Students = new List<Student>();
            School = school;
        }
        public override string ToString()
        {
            return $"<{Id}>-{Name}-{Major}-{ClassTeacher}-{AverageGrade}-{Students}-{School}";
        }
    }
}
