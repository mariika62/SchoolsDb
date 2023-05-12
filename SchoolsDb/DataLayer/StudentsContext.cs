using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentsContext : IDb<Student, string>
    {
        private readonly SchoolsDbContext dbContext;

        public StudentsContext(SchoolsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Student item)
        {
            try
            {
                School schoolFromDb = dbContext.Schools.Find(item.SchoolId);

                if (schoolFromDb != null)
                {
                    item.School = schoolFromDb;
                }

                Class classFromDb = dbContext.Classes.Find(item.ClassId);

                if (classFromDb != null)
                {
                    item.Class = classFromDb;
                }
                dbContext.Students.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Student Read(string key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Student> query = dbContext.Students;

                if (useNavigationalProperties)
                {
                    query = query.Include(s => s.School)
                        .Include(s => s.Class);
                }

                return query.FirstOrDefault(s => s.Id == key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Student> ReadAll(bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<Student> query = dbContext.Students;

                if (useNavigationalProperties)
                {
                    query = query.Include(s => s.School)
                        .Include(s => s.Class);
                }

                return query.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Student item, bool useNavigationalProperties = false)
        {
            try
            {
                Student studentFromDb = Read(item.Id, useNavigationalProperties);

                if (studentFromDb == null)
                {
                    Create(item);
                    return;
                }

                studentFromDb.Age = item.Age;
                studentFromDb.Name = item.Name;
                studentFromDb.AverageGrade = item.AverageGrade;
                studentFromDb.Telephone = item.Telephone;
                studentFromDb.NumberInClass = item.NumberInClass;

                if (useNavigationalProperties)
                {
                    School schoolFromDb = dbContext.Schools.Find(item.SchoolId);

                    if (schoolFromDb != null)
                    {
                        studentFromDb.School = schoolFromDb;
                    }
                    else
                    {
                        studentFromDb.School = item.School;
                    }
                    Class classFromDb = dbContext.Classes.Find(item.ClassId);

                    if (classFromDb != null)
                    {
                        studentFromDb.Class = classFromDb;
                    }
                    else
                    {
                        studentFromDb.Class = item.Class;
                    }
                }

                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Delete(string key)
        {
            try
            {
                Student studentFromDb = Read(key);

                if (studentFromDb != null)
                {
                    dbContext.Students.Remove(studentFromDb);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("Student with that id does not exist!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
