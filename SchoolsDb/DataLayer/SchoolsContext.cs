using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SchoolsContext : IDb<School, string>
    {
        private readonly SchoolsDbContext dbContext;

        public SchoolsContext(SchoolsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(School item)
        {
            try
            {
                List<Student> students = new List<Student>();
                List<Class> classes = new List<Class>();

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

                foreach (Class c in item.Classes)
                {
                    Class cFromDb = dbContext.Classes.Find(c.Id);

                    if (cFromDb != null)
                    {
                        classes.Add(cFromDb);
                    }
                    else
                    {
                        classes.Add(c);
                    }
                }
                item.Students = students;
                item.Classes = classes;

                dbContext.Schools.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public School Read(string key, bool useNavigationalProperties = false)
        {
            try
            {
                IQueryable<School> query = dbContext.Schools;

                if (useNavigationalProperties)
                {
                    query = query.Include(s => s.Students)
                        .Include(s => s.Classes);
                }

                return query.FirstOrDefault(s => s.Id == key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<School> ReadAll(bool useNavigationalProperties = false)
        {

            try
            {
                IQueryable<School> query = dbContext.Schools;

                if (useNavigationalProperties)
                {
                    query = query.Include(s => s.Students)
                        .Include(s => s.Classes);
                }

                return query.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(School item, bool useNavigationalProperties = false)
        {
            try
            {
                School schoolFromDb = Read(item.Id, useNavigationalProperties);

                if (schoolFromDb == null)
                {
                    Create(item);
                    return;
                }

                schoolFromDb.Address = item.Address;
                schoolFromDb.Name = item.Name;
                schoolFromDb.Type = item.Type;

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

                    List<Class> classes = new List<Class>();

                    foreach (Class c in item.Classes)
                    {
                        Class cFromDb = dbContext.Classes.Find(c.Id);

                        if (cFromDb != null)
                        {
                            classes.Add(cFromDb);
                        }
                        else
                        {
                            classes.Add(c);
                        }
                    }
                    schoolFromDb.Students = students;
                    schoolFromDb.Classes = classes;
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
                School schoolFromDb = Read(key);

                if (schoolFromDb != null)
                {
                    dbContext.Schools.Remove(schoolFromDb);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("School with that id does not exist!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
