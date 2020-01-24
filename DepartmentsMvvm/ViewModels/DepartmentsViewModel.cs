using DepartmentsMvvm.Models;
using DepartmentsMvvm.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace DepartmentsMvvm.ViewModels
{
    public class DepartmentsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Employee> employees;

        private Employee selectedEmployee;

        public ObservableCollection<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                if (this.employees == value)
                {
                    return;
                }
                this.employees = value;
                this.OnPropertyChanged(nameof(this.Employees));
            }
        }

        public Employee SelectedEmployee
        {
            get
            {
                return this.selectedEmployee;
            }
            set
            {
                if (this.selectedEmployee == value)
                {
                    return;
                }
                this.selectedEmployee = value;
                this.OnPropertyChanged(nameof(this.SelectedEmployee));
            }
        }

        public ICommand NewEmployeeCommand { get; set; }

        public ICommand DeleteEmployeeCommand { get; set; }

        public ICommand GetEmployeesCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public DepartmentsViewModel()
        {
            this.Employees = new ObservableCollection<Employee>();
            this.NewEmployeeCommand = new RelayCommand(NewEmployeeCommandExecute);
            this.DeleteEmployeeCommand = new RelayCommand(DeleteEmployeeCommandExecute, DeleteEmployeeCommandCanExecute);
            this.GetEmployeesCommand = new RelayCommand(GetEmployeesCommandExecute, GetEmployeesCommandCanExecute);
        }

        public void NewEmployeeCommandExecute(object obj)
        {
            int maxId = 0;
            if (this.Employees.Count > 0)
            {
                maxId = this.Employees.Max(x => x.Id);
            }
            this.Employees.Add(new Employee(++maxId, null, null, DateTime.Now, false));
        }

        public bool DeleteEmployeeCommandCanExecute(object obj)
        {
            return this.SelectedEmployee != null;
        }

        public void DeleteEmployeeCommandExecute(object obj)
        {
            this.Employees.Remove(this.SelectedEmployee as Employee);
        }

        public bool GetEmployeesCommandCanExecute(object obj)
        {
            return this.Employees.Count == 0;
        }

        public void GetEmployeesCommandExecute(object obj)
        {
            this.Employees = new ObservableCollection<Employee>()
            {
                new Employee(1, "Steven", "Marketing", new DateTime(2003, 6, 17), false),
                new Employee(2, "Neena", "Marketing", new DateTime(2005, 9, 21), false),
                new Employee(3, "Lex", "Human Resources", new DateTime(2011, 1, 13), false),
                new Employee(4, "Alexander", "Purchasing", new DateTime(2006, 1, 3), false),
                new Employee(5, "Bruce", "Executive", new DateTime(2005, 9, 28), true),
                new Employee(6, "David", "Human Resources", new DateTime(2006, 3, 7), false),
                new Employee(7, "Valli", "Purchasing", new DateTime(2002, 2, 11), true),
                new Employee(8, "Diana", "Public Relations", new DateTime(2007, 12, 07), false),
                new Employee(9, "Nancy", "IT", new DateTime(2005, 5, 1), false),
                new Employee(10, "Daniel", "Public Relations", new DateTime(2007, 5, 5), false),
            };
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged is null)
            {
                return;
            }
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}