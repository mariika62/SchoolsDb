using BusinessLayer;
using DataLayer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
    [TestFixture]
    public class SchoolContextTest
    {
        private SchoolsContext context = new(SetupFixture.dbContext);
        private School school;
        private Student st1, st2;
        private Class cl1, cl2;

        [SetUp]
        public void CreateSchool()
        {
            school = new("MG Akad. K. Popov", "Chemshir 11", "High School");

            cl1 = new("11j", "Liliana Rusinova", school);
            cl2 = new("11e", "Ivan Iliev", school);
            st1 = new("Kristiyan Angelov", 17, 5.80, 14, school, cl1);
            st2 = new("Todor Demirov", 15, 5.50, 25, school, cl1);
            school.Students.Add(st1);
            school.Students.Add(st2);
            school.Classes.Add(cl1);
            school.Classes.Add(cl2);

            context.Create(school);
        }

        [TearDown]
        public void DropSchool()
        {
            foreach (School item in SetupFixture.dbContext.Schools.ToList())
            {
                SetupFixture.dbContext.Schools.Remove(item);
            }
            SetupFixture.dbContext.SaveChanges();
        }

        [Test]
        public void Create()
        {
            School newSchool = new("Dragan Manchov", "Chemshir 11", "Elementary");
            int schoolsBefore = SetupFixture.dbContext.Schools.Count();
            context.Create(newSchool);
            int schoolsAfter = SetupFixture.dbContext.Schools.Count();
            Assert.IsTrue(schoolsBefore + 1 == schoolsAfter, "Create() does not work!");
        }

        [Test]
        public void Read()
        {
            School readSchool = context.Read(school.Id);
            Assert.AreEqual(school, readSchool, "Read() does not return the same object!");
        }

        [Test]
        public void ReadWithNavigationalProperties()
        {
            School readSchool = context.Read(school.Id, true);
            Assert.That(readSchool.Students.Contains(st1) && readSchool.Students.Contains(st2), "S1 and S2 are not in the Students list!");
            Assert.That(readSchool.Classes.Contains(cl1) && readSchool.Classes.Contains(cl2), "Cl1 and Cl2 are not in the Classes list!");
        }

        [Test]
        public void ReadAll()
        {
            List<School> schools = (List<School>)context.ReadAll();
            Assert.That(schools.Count != 0, "ReadAll() does not return schools!");
        }

        [Test]
        public void ReadAllWithNavigationalProperties()
        {
            School readSchool = new("EG Plovdiv", "Bul. Bulgaria", "Language");
            Class cl = new("11", "Unknown", readSchool);
            Student st = new("John Doe", 16, 5.00, 1, readSchool, cl);
            SetupFixture.dbContext.Students.Add(st);
            SetupFixture.dbContext.Classes.Add(cl);
            SetupFixture.dbContext.Schools.Add(readSchool);

            List<School> schools = (List<School>)context.ReadAll(true);
            Assert.That(schools.Count != 0 && context.Read(readSchool.Id, true).Classes.Count == 1 &&
                context.Read(readSchool.Id, true).Students.Count == 1, "ReadAll() does not return schools!");
        }

        [Test]
        public void Update()
        {
            School changedSchool = context.Read(school.Id);
            changedSchool.Name = "Updated " + school.Name;
            context.Update(changedSchool);
            Assert.AreEqual(changedSchool, school, "Update() does not work!");
        }

        [Test]
        public void Delete()
        {
            int schoolsBefore = SetupFixture.dbContext.Schools.Count();
            context.Delete(school.Id);
            int schoolsAfter = SetupFixture.dbContext.Schools.Count();
            Assert.IsTrue(schoolsBefore - 1 == schoolsAfter, "Delete() does not work!");
        }
    }
}
