using System;
using System.Collections.ObjectModel;
using DAL.Model;
using DAL.Services;
using Presentation.Extensions;


namespace Presentation.ViewModel
{
    public class StudentViewModel : ViewModelBase.ViewModelBase
    {
        private ObservableCollection<Student> students;

        private Student selectedStudent;

        private readonly IStudentService studentService;

        public ObservableCollection<Student> Students
        {
            get { return this.students; }
            set
            {
                this.students = value;
                this.OnPropertyChanged();
            }
        }

        public Student SelectedStudent
        {
            get { return this.selectedStudent; }
            set
            {
                this.selectedStudent = value;
                this.OnPropertyChanged();
            }
        }

        public DelegateCommand.DelegateCommand GetStudentsCommmand { get; }

        public DelegateCommand.DelegateCommand SaveStudentsCommand { get; }

        public DelegateCommand.DelegateCommand DeleteStudentCommand { get; }

        public StudentViewModel(IStudentService studentService)
        {
            if (studentService == null) throw new ArgumentNullException(nameof(studentService));

            this.studentService = studentService;
            this.Students = new ObservableCollection<Student>();

            this.GetStudentsCommmand = new DelegateCommand.DelegateCommand(this.ExecuteGetStudents);
            this.SaveStudentsCommand = new DelegateCommand.DelegateCommand(this.ExecuteSaveStudents, this.CanExecute);
            this.DeleteStudentCommand = new DelegateCommand.DelegateCommand(this.ExecuteDeleteStudent, this.CanExecute);
        }

        private bool CanExecute()
        {
            return this.selectedStudent != null;
        }

        private void ExecuteGetStudents()
        {
            this.Students = this.studentService.GetStudents().ToObservableCollection();
        }

        private void ExecuteSaveStudents()
        {
            this.studentService.SaveStudents(this.Students);
        }

        private void ExecuteDeleteStudent()
        {
            this.studentService.DeleteStudent(this.SelectedStudent);
            this.Students.Remove(this.selectedStudent);
        }
    }
}