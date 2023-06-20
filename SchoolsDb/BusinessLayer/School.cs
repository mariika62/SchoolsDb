using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class School
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Type { get; set; }
        public List<Student> Students { get; set; }
        public List<Class> Classes { get; set; }
        private School()
        {
            Students = new List<Student>();
            Classes = new List<Class>();
        }

        public School(string name, string address, string type)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Address = address;
            Type = type;
            Students = new List<Student>();
            Classes = new List<Class>();
        }
        public override string ToString()
        {
            return $"<{Id}>-{Name}-{Address}-{Type}-{Students}-{Classes}";
        }
    }
}
