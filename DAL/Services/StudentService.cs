using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Services
{
    public class StudentService : IStudentService, IDisposable
    {
        private SchoolDbContext context;

        private bool disposed;

        public StudentService()
        {
            this.context = new SchoolDbContext();
            this.disposed = false;
        }

        public IEnumerable<Student> GetStudents()
        {
            return this.context.Students
                .Include(s => s.Books)
                .Include(s => s.Address)
                .ToList();
        }

        public void SaveStudents(IEnumerable<Student> students)
        {
            this.context.Students.UpdateRange(students);
            this.Save();
        }

        public void DeleteStudent(Student student)
        {
            this.context.Students.Remove(student);
            this.Save();
        }

        private void Save()
        {
            this.context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}