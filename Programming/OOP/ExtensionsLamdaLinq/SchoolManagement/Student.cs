using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("First name is mandatory!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Last name is mandatory!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0 || value > 128)
                {
                    throw new ArgumentException("You have entered negative value or over 128 years!");
                }

                this.age = value;
            }
        }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("Firstname: {0} Lastname: {1} Age: {2}", this.FirstName, this.LastName, this.Age);
        }

        public static List<Student> GetStudents(List<Student> students)
        {
            return students.FindAll(x => x.FirstName.CompareTo(x.LastName) < 0);
        }
    }
}
