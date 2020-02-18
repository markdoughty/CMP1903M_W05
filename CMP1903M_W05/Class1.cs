using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMP1903M_W05
{
    class University
    {
        public string Name { get; set; }
        public int uniID { get; set; }
        public List<Student> students = new List<Student>();
        public University()
        {
            Name = "Default University";
            uniID = 0;
        }

        public University(string name, int ID)
        {
            Name = name;
            uniID = ID;
        }

        public void addStudent(Student A)
        {
            students.Add(A);
        }

        public void getNumberOfStudents()
        {
            Console.WriteLine($"Number of students at Uni: {students.Count()}");
        }

        public void getAgeRangeOfStudents()
        {
            Console.WriteLine("Age range of students");
            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{students[i].Age}");
            }
        }
    }
}
