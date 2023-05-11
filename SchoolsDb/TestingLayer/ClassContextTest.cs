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
    public class ClassContextTest
    {
        private ClassContext context = new ClassContext(SetupFixture.dbContext);
        private Class class_;
        private Student st1, st2;
        private School sc1;

        [SetUp]
        public void CreateClass()
        {
            sc1 = new("Akad. K. Popov", "Chemshir 11", "High School");
            class_ = new("11j", "Liliana Rusinova", sc1);
            st1 = new("Kristiyan Angelov", 17, 5.80, 14, sc1, class_);
            st2 = new("Todor Demirov", 15, 5.50, 25, sc1, class_);

            class_.Students.Add(st1);
            class_.Students.Add(st2);

            context.Create(class_);
        }

        [TearDown]
        public void DropClass()
        {
            foreach (Class item in SetupFixture.dbContext.Classes.ToList())
            {
                SetupFixture.dbContext.Classes.Remove(item);
            }

            SetupFixture.dbContext.SaveChanges();
        }

        [Test]
        public void Create()
        {
            Class testClass = new("11e", "Ivan Iliev", sc1);
            int classBefore = SetupFixture.dbContext.Classes.Count();
            context.Create(testClass);
            int classAfter = SetupFixture.dbContext.Classes.Count();
            Assert.That(classBefore + 1 == classAfter, "Create() does not work!");
        }

        [Test]
        public void Read()
        {
            Class readClass = context.Read(class_.Id);
            Assert.AreEqual(class_, readClass, "Read does not return the same object!");
        }

        [Test]
        public void ReadWithNavigationalProperties()
        {
            Class readClass = context.Read(class_.Id, true);
            Assert.That(readClass.Students.Contains(st1) && readClass.Students.Contains(st1), "S1 and S2 are not in the Students list!");
        }

        [Test]
        public void ReadAll()
        {
            List<Class> classes = (List<Class>)context.ReadAll();

            Assert.That(classes.Count != 0, "ReadAll() does not return classes!");
        }

        [Test]
        public void ReadAllWithNavigationalProperties()
        {
            School sc = new("Dragan Manchov", "Chemshir 11", "Elementary");
            Class readClass = new("12j", "Unknown", sc);
            Student st = new("John Doe", 15, 4.50, 15, sc, readClass);
            SetupFixture.dbContext.Schools.Add(sc);
            SetupFixture.dbContext.Students.Add(st);
            SetupFixture.dbContext.Classes.Add(readClass);

            List<Class> classes = (List<Class>)context.ReadAll(true);
            Assert.That(classes.Count != 0 && context.Read(readClass.Id, true).Students.Count == 1,
                "ReadAll() does not return classes!");
        }

        [Test]
        public void Update()
        {
            Class changedClass = context.Read(class_.Id);

            changedClass.Name = "Updated " + class_.Name;
            changedClass.ClassTeacher = "Denitsa Grozeva";

            context.Update(changedClass);

            Assert.AreEqual(changedClass, class_, "Update() does not work!");
        }

        [Test]
        public void Delete()
        {
            int classBefore = SetupFixture.dbContext.Classes.Count();

            context.Delete(class_.Id);
            int classAfter = SetupFixture.dbContext.Classes.Count();

            Assert.IsTrue(classBefore - 1 == classAfter, "Delete() does not work!");
        }
    }
}
