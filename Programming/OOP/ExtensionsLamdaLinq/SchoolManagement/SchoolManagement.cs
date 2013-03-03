using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class SchoolManagement
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Pesho", "Peshev", 25),
                new Student("Nako", "Dakov", 23),
                new Student("Dako", "Nakov", 22),
                new Student("Gosho", "Mihailov", 23),
                new Student("Sasho", "Peshev", 20),
                new Student("Pesho", "Sashev", 19),
                new Student("Pesho", "Bashev", 19),
                new Student("Pesho", "Lashev", 19),
            };

            Console.WriteLine("Students whom first name is alphabetically before their lastname:\n");
            List<Student> newStudents = Student.GetStudents(students);

            foreach (var student in newStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nStudents between 18 and 24:\n");

            var studentsBetween =
                                 from st in students
                                 where st.Age > 18 && st.Age < 24
                                 select st;

            foreach (var st in studentsBetween)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine("\nSorting students by first name and lastname:\n");

            var sortedStudents = students.OrderBy(student => student.FirstName).ThenBy(student => student.LastName);

            foreach (var sortedStudent in sortedStudents)
            {
                Console.WriteLine(sortedStudent);
            }
        }
    }
}
