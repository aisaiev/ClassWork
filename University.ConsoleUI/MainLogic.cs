using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.ConsoleUI.Enum;
using University.ConsoleUI.Menu;
using University.DAL.Model;
using University.DAL.Repository;

namespace University.ConsoleUI
{
    public class MainLogic
    {
        private Printer printer;

        public void Run()
        {
            this.printer = new Printer();
            this.CreateMenu();
        }

        private void CreateMenu()
        {
            ConsoleMenu mainMenu = new ConsoleMenu()
            {
                SubTitle = "-------------------- MENU ----------------------"
            };

            ConsoleMenu viewEntityMenu = new ConsoleMenu()
            {
                SubTitle = "-------------------- SELECT ENTITY ----------------------",
                ParentMenu = mainMenu
            };

            ConsoleMenu operationWithEntityMenu = new ConsoleMenu()
            {
                SubTitle = "-------------------- SELECT ENTITY ----------------------",
                ParentMenu = mainMenu
            };

            ConsoleMenu operationWithStudentMenu = new ConsoleMenu()
            {
                SubTitle = "-------------------- SELECT OPERATION ----------------------",
                ParentMenu = operationWithEntityMenu
            };

            ConsoleMenu operationWithCourseMenu = new ConsoleMenu()
            {
                SubTitle = "-------------------- SELECT OPERATION ----------------------",
                ParentMenu = operationWithEntityMenu
            };

            ConsoleMenu operationWithDepartmentMenu = new ConsoleMenu()
            {
                SubTitle = "-------------------- SELECT OPERATION ----------------------",
                ParentMenu = operationWithEntityMenu
            };

            ConsoleMenu exitMenu = new ConsoleMenu()
            {
                SubTitle = "-------------------- EXIT ----------------------",
            };

            mainMenu.AddMenuItem(0, "View entity", viewEntityMenu.ShowMenu);
            mainMenu.AddMenuItem(1, "Operation with entity", operationWithEntityMenu.ShowMenu);
            mainMenu.AddMenuItem(2, "Exit", exitMenu.ShowMenu);

            viewEntityMenu.AddMenuItem(0, "Student", () => this.ShowEntities(EntityType.Student));
            viewEntityMenu.AddMenuItem(1, "Course", () => this.ShowEntities(EntityType.Course));
            viewEntityMenu.AddMenuItem(2, "Department", () => this.ShowEntities(EntityType.Department));
            viewEntityMenu.AddMenuItem(3, "Back to main menu", viewEntityMenu.HideMenu);

            operationWithEntityMenu.AddMenuItem(0, "Student", operationWithStudentMenu.ShowMenu);
            operationWithEntityMenu.AddMenuItem(1, "Course", operationWithCourseMenu.ShowMenu);
            operationWithEntityMenu.AddMenuItem(2, "Department", operationWithDepartmentMenu.ShowMenu);
            operationWithEntityMenu.AddMenuItem(3, "Back to main menu", operationWithEntityMenu.HideMenu);

            operationWithStudentMenu.AddMenuItem(0, "Add Student", this.AddStudent);
            operationWithStudentMenu.AddMenuItem(1, "Update Student by Id", this.UpdateStudentById);
            operationWithStudentMenu.AddMenuItem(2, "Delete Student by Id", this.DeleteStudentById);
            operationWithStudentMenu.AddMenuItem(3, "Back to previous menu", operationWithStudentMenu.HideMenu);

            operationWithCourseMenu.AddMenuItem(0, "Add Course", this.AddCourse);
            operationWithCourseMenu.AddMenuItem(1, "Update Course by Id", this.UpdateCourseById);
            operationWithCourseMenu.AddMenuItem(2, "Delete Course by Id", this.DeleteCourseById);
            operationWithCourseMenu.AddMenuItem(3, "Back to previous menu", operationWithCourseMenu.HideMenu);

            operationWithDepartmentMenu.AddMenuItem(0, "Add Department", this.AddDepartment);
            operationWithDepartmentMenu.AddMenuItem(1, "Update Department by Id", this.UpdateDepartmentById);
            operationWithDepartmentMenu.AddMenuItem(2, "Delete Department by Id", this.DeleteDepartmentById);
            operationWithDepartmentMenu.AddMenuItem(3, "Back to previous menu", operationWithDepartmentMenu.HideMenu);

            exitMenu.AddMenuItem(0, "Yes", this.Exit);
            exitMenu.AddMenuItem(1, "No", exitMenu.HideMenu);

            mainMenu.ShowMenu();
        }

        private void AddStudent()
        {
            bool isCorrectInput = false;
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine();
            do
            {
                Console.Write("Create student? (Y/N): ");
                string select = Console.ReadLine().ToLower();
                switch (select.ToLower())
                {
                    case "y":
                        isCorrectInput = !isCorrectInput;
                        try
                        {
                            using (var unitOfWork = new UnitOfWork())
                            {
                                Student student = new Student { FirstName = firstName, LastName = lastName };
                                unitOfWork.StudentRepository.Insert(student);
                                unitOfWork.Save();
                                Console.WriteLine($"Student has been created with Id: {student.StudentId}");
                                Console.ReadLine();
                            }
                        }
                        catch (DbUpdateException)
                        {
                            Console.WriteLine("Unable to create student. It seems FirstName or LastName is more then 50 characters");
                            Console.ReadLine();
                        }
                        break;
                    case "n":
                        isCorrectInput = !isCorrectInput;
                        break;
                    default:
                        Console.WriteLine("Please enter 'Y' or 'N'");
                        break;
                }
            } while (!isCorrectInput);
        }

        private void UpdateStudentById()
        {
            bool isStudentIdValid = false;
            do
            {
                Console.Write("Student Id: ");
                string studentIdStr = Console.ReadLine();
                if (int.TryParse(studentIdStr, out int studentId))
                {
                    isStudentIdValid = !isStudentIdValid;

                    using (var unitOfWork = new UnitOfWork())
                    {
                        this.printer.ClearConsole();
                        this.printer.PrintLoadingMessage();
                        Student student = unitOfWork.StudentRepository.GetById(studentId);
                        if (student != null)
                        {
                            bool isCorrectInput = false;
                            this.printer.PrintStudents(new List<Student>() { student });
                            Console.Write("First Name: ");
                            string firstName = Console.ReadLine();
                            Console.Write("Last Name: ");
                            string lastName = Console.ReadLine();
                            Console.WriteLine();
                            do
                            {
                                Console.Write("Update student? (Y/N): ");
                                string select = Console.ReadLine().ToLower();
                                switch (select.ToLower())
                                {
                                    case "y":
                                        isCorrectInput = !isCorrectInput;
                                        try
                                        {
                                            student.FirstName = firstName;
                                            student.LastName = lastName;
                                            unitOfWork.StudentRepository.Update(student);
                                            unitOfWork.Save();
                                            Console.WriteLine($"Student with Id: {student.StudentId} has been updated");
                                            Console.ReadLine();
                                        }
                                        catch (DbUpdateException)
                                        {
                                            Console.WriteLine("Unable to update student. It seems FirstName or LastName is more then 50 characters");
                                            Console.ReadLine();
                                        }
                                        break;
                                    case "n":
                                        isCorrectInput = !isCorrectInput;
                                        break;
                                    default:
                                        Console.WriteLine("Please enter 'Y' or 'N'");
                                        break;
                                }
                            } while (!isCorrectInput);
                        }
                        else
                        {
                            Console.WriteLine($"Unable to find Student with Id {studentId}");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid Student Id");
                }

            } while (!isStudentIdValid);
        }

        private void DeleteStudentById()
        {
            bool isStudentIdValid = false;
            do
            {
                Console.Write("Student Id: ");
                string studentIdStr = Console.ReadLine();
                if (int.TryParse(studentIdStr, out int studentId))
                {
                    isStudentIdValid = !isStudentIdValid;
                    try
                    {
                        using (var unitOfWork = new UnitOfWork())
                        {
                            unitOfWork.StudentRepository.Delete(studentId);
                            unitOfWork.Save();
                            Console.WriteLine($"Student with Id {studentId} has been deleted");
                            Console.ReadLine();
                        }
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine($"Unable to delete Student with Id {studentId}");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid Student Id");
                }

            } while (!isStudentIdValid);
        }

        private void AddCourse()
        {
            bool isCorrectInput = false;
            Console.Write("Course Name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine();
            do
            {
                Console.Write("Create course? (Y/N): ");
                string select = Console.ReadLine().ToLower();
                switch (select.ToLower())
                {
                    case "y":
                        isCorrectInput = !isCorrectInput;
                        using (var unitOfWork = new UnitOfWork())
                        {
                            Course course = new Course { Name = courseName };
                            unitOfWork.CourseRepository.Insert(course);
                            unitOfWork.Save();
                            Console.WriteLine($"Course has been created with Id: {course.CourseId}");
                            Console.ReadLine();
                        }
                        break;
                    case "n":
                        isCorrectInput = !isCorrectInput;
                        break;
                    default:
                        Console.WriteLine("Please enter 'Y' or 'N'");
                        break;
                }
            } while (!isCorrectInput);
        }

        private void UpdateCourseById()
        {
            bool isCourseIdValid = false;
            do
            {
                Console.Write("Course Id: ");
                string courseIdStr = Console.ReadLine();
                if (int.TryParse(courseIdStr, out int courseId))
                {
                    isCourseIdValid = !isCourseIdValid;

                    using (var unitOfWork = new UnitOfWork())
                    {
                        this.printer.ClearConsole();
                        this.printer.PrintLoadingMessage();
                        Course course = unitOfWork.CourseRepository.GetById(courseId);
                        if (course != null)
                        {
                            bool isCorrectInput = false;
                            this.printer.PrintCourses(new List<Course>() { course });
                            Console.Write("Course Name: ");
                            string courseName = Console.ReadLine();
                            Console.WriteLine();
                            do
                            {
                                Console.Write("Update course? (Y/N): ");
                                string select = Console.ReadLine().ToLower();
                                switch (select.ToLower())
                                {
                                    case "y":
                                        isCorrectInput = !isCorrectInput;
                                        course.Name = courseName;
                                        unitOfWork.CourseRepository.Update(course);
                                        unitOfWork.Save();
                                        Console.WriteLine($"Course with Id: {course.CourseId} has been updated");
                                        Console.ReadLine();
                                        break;
                                    case "n":
                                        isCorrectInput = !isCorrectInput;
                                        break;
                                    default:
                                        Console.WriteLine("Please enter 'Y' or 'N'");
                                        break;
                                }
                            } while (!isCorrectInput);
                        }
                        else
                        {
                            Console.WriteLine($"Unable to find Course with Id {courseId}");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid Course Id");
                }

            } while (!isCourseIdValid);
        }


        private void DeleteCourseById()
        {
            bool isCourseIdValid = false;
            do
            {
                Console.Write("Course Id: ");
                string courseIdStr = Console.ReadLine();
                if (int.TryParse(courseIdStr, out int courseId))
                {
                    isCourseIdValid = !isCourseIdValid;
                    try
                    {
                        using (var unitOfWork = new UnitOfWork())
                        {
                            unitOfWork.CourseRepository.Delete(courseId);
                            unitOfWork.Save();
                            Console.WriteLine($"Course with Id {courseId} has been deleted");
                            Console.ReadLine();
                        }
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine($"Unable to delete Course with Id {courseId}, as Course Id {courseId} wasn't found");
                        Console.ReadLine();
                    }
                    catch (DbUpdateException)
                    {
                        Console.WriteLine($"Unable to delete Course with Id {courseId}, as it has references with another entities");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid Course Id");
                }

            } while (!isCourseIdValid);
        }

        private void AddDepartment()
        {
            bool isCorrectInput = false;
            Console.Write("Department Name: ");
            string departmentName = Console.ReadLine();
            Console.WriteLine();
            do
            {
                Console.Write("Create department? (Y/N): ");
                string select = Console.ReadLine().ToLower();
                switch (select.ToLower())
                {
                    case "y":
                        isCorrectInput = !isCorrectInput;
                        using (var unitOfWork = new UnitOfWork())
                        {
                            Department department = new Department { Name = departmentName };
                            unitOfWork.DepartmentRepository.Insert(department);
                            unitOfWork.Save();
                            Console.WriteLine($"Department has been created with Id: {department.DepartmentId}");
                            Console.ReadLine();
                        }
                        break;
                    case "n":
                        isCorrectInput = !isCorrectInput;
                        break;
                    default:
                        Console.WriteLine("Please enter 'Y' or 'N'");
                        break;
                }
            } while (!isCorrectInput);
        }

        private void UpdateDepartmentById()
        {
            bool isDepartmentIdValid = false;
            do
            {
                Console.Write("Department Id: ");
                string departmentIdStr = Console.ReadLine();
                if (int.TryParse(departmentIdStr, out int departmentId))
                {
                    isDepartmentIdValid = !isDepartmentIdValid;

                    using (var unitOfWork = new UnitOfWork())
                    {
                        this.printer.ClearConsole();
                        this.printer.PrintLoadingMessage();
                        Department department = unitOfWork.DepartmentRepository.GetById(departmentId);
                        if (department != null)
                        {
                            bool isCorrectInput = false;
                            this.printer.PrintDepartments(new List<Department>() { department });
                            Console.Write("Department Name: ");
                            string departmentName = Console.ReadLine();
                            Console.WriteLine();
                            do
                            {
                                Console.Write("Update department? (Y/N): ");
                                string select = Console.ReadLine().ToLower();
                                switch (select.ToLower())
                                {
                                    case "y":
                                        isCorrectInput = !isCorrectInput;
                                        department.Name = departmentName;
                                        unitOfWork.DepartmentRepository.Update(department);
                                        unitOfWork.Save();
                                        Console.WriteLine($"Depratment with Id: {department.DepartmentId} has been updated");
                                        Console.ReadLine();
                                        break;
                                    case "n":
                                        isCorrectInput = !isCorrectInput;
                                        break;
                                    default:
                                        Console.WriteLine("Please enter 'Y' or 'N'");
                                        break;
                                }
                            } while (!isCorrectInput);
                        }
                        else
                        {
                            Console.WriteLine($"Unable to find Department with Id {departmentId}");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid Department Id");
                }

            } while (!isDepartmentIdValid);
        }

        private void DeleteDepartmentById()
        {
            bool isDepartmentIdValid = false;
            do
            {
                Console.Write("Course Id: ");
                string departmentIdStr = Console.ReadLine();
                if (int.TryParse(departmentIdStr, out int departmentId))
                {
                    isDepartmentIdValid = !isDepartmentIdValid;
                    try
                    {
                        using (var unitOfWork = new UnitOfWork())
                        {
                            unitOfWork.DepartmentRepository.Delete(departmentId);
                            unitOfWork.Save();
                            Console.WriteLine($"Department with Id {departmentId} has been deleted");
                            Console.ReadLine();
                        }
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine($"Unable to delete Department with Id {departmentId}");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid Department Id");
                }

            } while (!isDepartmentIdValid);
        }

        private void ShowEntities(EntityType entityType)
        {
            this.printer.ClearConsole();
            switch (entityType)
            {
                case EntityType.Student:
                    this.printer.PrintLoadingMessage();
                    using (var unitOfWork = new UnitOfWork())
                    {
                        List<Student> students = unitOfWork.StudentRepository.Get().ToList();
                        this.printer.PrintStudents(students);
                    }
                    break;
                case EntityType.Course:
                    this.printer.PrintLoadingMessage();
                    using (var unitOfWork = new UnitOfWork())
                    {
                        List<Course> courses = unitOfWork.CourseRepository.Get().ToList();
                        this.printer.PrintCourses(courses);
                    }
                    break;
                case EntityType.Department:
                    this.printer.PrintLoadingMessage();
                    using (var unitOfWork = new UnitOfWork())
                    {
                        List<Department> departments = unitOfWork.DepartmentRepository.Get().ToList();
                        this.printer.PrintDepartments(departments);
                    }
                    break;
            }
            Console.ReadLine();
        }

        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}
