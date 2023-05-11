using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Student
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(6, 19, ErrorMessage = "Too young or old to be a student")]
        public int Age { get; set; }
        public double AverageGrade { get; set; }
        public string Telephone { get; set; }
        public int NumberInClass { get; set; }
        public School School { get; set; }
        public Class Class { get; set; }
        [ForeignKey("School")]
        public string SchoolId { get; set; }
        [ForeignKey("Class")]
        public string ClassId { get; set; }
        private Student()
        {

        }

        public Student(string name, int age, double averageGrade, int numberInClass, School school, Class @class, string telephone = null)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Age = age;
            AverageGrade = averageGrade;
            Telephone = telephone;
            NumberInClass = numberInClass;
            School = school;
            Class = @class;
        }
    }
}

