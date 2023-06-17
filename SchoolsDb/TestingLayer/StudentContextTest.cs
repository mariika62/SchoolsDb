using BusinessLayer;
using DataLayer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
    [TestFixture]
    public class StudentContextTest
    {
        private StudentsContext context = new StudentsContext(SetupFixture.dbContext);
        private Student student;
        private Class cl1;
        private School sc1;

        [SetUp]
        public void CreateStudent()
        {
            sc1 = new("Akad. K. Popov", "Chemshir 11", "High School");
            cl1 = new("11j", "Liliana Rusinova", sc1);

            student = new("Todor Demirov", 15, 5.50, 25, sc1, cl1);

            context.Create(student);
        }

        [TearDown]
        public void DropStudent()
        {
            foreach (Student item in SetupFixture.dbContext.Students.ToList())
            {
                SetupFixture.dbContext.Students.Remove(item);
            }
            SetupFixture.dbContext.SaveChanges();
        }

        [Test]
        public void Create()
        {
            Student newStudent = new("Maria Petrova", 17, 5.99, 17, sc1, cl1);
            int studentsBefore = SetupFixture.dbContext.Students.Count();
            context.Create(newStudent);
            int studentsAfter = SetupFixture.dbContext.Students.Count();
            Assert.IsTrue(studentsBefore + 1 == studentsAfter, "Create() does not work!");
        }

        [Test]
        public void Read()
        {
            Student readStudent = context.Read(student.Id);
            Assert.AreEqual(student, readStudent, "Read() does not return the same object");
        }

        [Test]
        public void ReadAll()
        {
            List<Student> students = (List<Student>)context.ReadAll();
            Assert.That(students.Count != 0, "ReadAll() does not return students!");
        }

        [Test]
        public void Update()
        {
            Student changedStudent = context.Read(student.Id);
            changedStudent.Name = "Updated " + student.Name;
            changedStudent.Age = 18;
            context.Update(changedStudent);
            Assert.AreEqual(changedStudent, student, "Update() does not work!");
        }

        [Test]
        public void Delete()
        {
            int studentBefore = SetupFixture.dbContext.Students.Count();

            context.Delete(student.Id);
            int studentAfter = SetupFixture.dbContext.Students.Count();

            Assert.IsTrue(studentBefore - 1 == studentAfter, "Delete() does not work!");
        }
    }
}
