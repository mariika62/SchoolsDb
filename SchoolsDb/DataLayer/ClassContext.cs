using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ClassContext : IDb<Class, string>
    {
        private readonly SchoolsDbContext dbContext;

        public ClassContext(SchoolsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Class item)
        {
            try
            {
                dbContext.Classes.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(string key)
        {
            Class classFromDb = Read(key);

            if (classFromDb != null)
            {
                dbContext.Classes.Remove(classFromDb);
                dbContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Class with that id does not exist!");
            }
        }

        public Class Read(string key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Class> query = dbContext.Classes;

                if (useNavigationalProperties)
                {
                    query = query.Include(c => c.Students);
                }

                return query.FirstOrDefault(s => s.Id == key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Class> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Class> query = dbContext.Classes;

                if (useNavigationalProperties)
                {
                    query = query.Include(c => c.Students);
                }

                return query.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Class item, bool useNavigationalProperties = false)
        {
            try
            {
                Class classFromDb = Read(item.Id, useNavigationalProperties);

                if (classFromDb == null)
                {
                    Create(item);
                    return;
                }

                classFromDb.Major = item.Major;
                classFromDb.Name = item.Name;
                classFromDb.ClassTeacher = item.ClassTeacher;
                classFromDb.AverageGrade = item.AverageGrade;

                if (useNavigationalProperties)
                {

                    List<Student> students = new List<Student>();

                    foreach (Student s in item.Students)
                    {
                        Student sFromDb = dbContext.Students.Find(s.Id);

                        if (sFromDb != null)
                        {
                            students.Add(sFromDb);
                        }
                        else
                        {
                            students.Add(s);
                        }
                    }
                    classFromDb.Students = students;
                }
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
