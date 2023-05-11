using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ServiceLayer
{
    public static class ContextGenerator
    {
        private static SchoolsDbContext dbContext;
        private static ClassContext classContext;
        private static SchoolsContext schoolsContext;
        private static StudentsContext studentsContext;

        public static SchoolsDbContext GetDbContext()
        {
            if (dbContext == null)
            {
                SetDbContext();
            }
            return dbContext;
        }
        public static void SetDbContext()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }

            dbContext = new SchoolsDbContext();
        }
        public static ClassContext GetClassContext()
        {
            if (classContext == null)
            {
                SetClassContext();
            }

            return classContext;
        }

        public static void SetClassContext()
        {
            classContext = new ClassContext(GetDbContext());
        }
        public static SchoolsContext GetSchoolsContext()
        {
            if (schoolsContext == null)
            {
                SetSchoolsContext();
            }

            return schoolsContext;
        }

        public static void SetSchoolsContext()
        {
            schoolsContext = new SchoolsContext(GetDbContext());
        }
        public static StudentsContext GetStudentsContext()
        {
            if (studentsContext == null)
            {
                SetStudentsContext();
            }

            return studentsContext;
        }

        public static void SetStudentsContext()
        {
            studentsContext = new StudentsContext(GetDbContext());
        }
    }
}