using System;
using System.Collections.Generic;
using System.Text;
using University.DAL.Model;

namespace University.DAL.Repository
{
    public class UnitOfWork : IDisposable
    {
        private bool disposed;

        private UniversityDbContext context;

        private GenericRepository<Student> studentRepository;

        private GenericRepository<Course> courseRepository;

        private GenericRepository<Department> departmentRepository;

        public GenericRepository<Student> StudentRepository
        {
            get
            {
                if (this.studentRepository == null)
                {
                    this.studentRepository = new GenericRepository<Student>(this.context);
                }
                return this.studentRepository;
            }
        }

        public GenericRepository<Course> CourseRepository
        {
            get
            {
                if (this.courseRepository == null)
                {
                    this.courseRepository = new GenericRepository<Course>(this.context);
                }
                return this.courseRepository;
            }
        }

        public GenericRepository<Department> DepartmentRepository
        {
            get
            {
                if (this.departmentRepository == null)
                {
                    this.departmentRepository = new GenericRepository<Department>(this.context);
                }
                return this.departmentRepository;
            }
        }

        public UnitOfWork()
        {
            this.context = new UniversityDbContext();
            this.disposed = false;
        }

        public void Save()
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
