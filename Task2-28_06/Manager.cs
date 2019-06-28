using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_28_06
{
    public class Manager
    {
        private Dictionary<Tuple<string, string>, Student> studentDictionary;

        public Manager()
        {
            studentDictionary = new Dictionary<Tuple<string, string>, Student>();
        }

        public void AddStudent(Student student)
        {
            studentDictionary.Add(Tuple.Create(student.FirstName, student.LastName), student);
        }

        public Student GetStudentByFirstNameAndLastName(string firstName, string lastName)
        {
            studentDictionary.TryGetValue(Tuple.Create(firstName, lastName), out Student student);
            return student;
        }
    }
}
