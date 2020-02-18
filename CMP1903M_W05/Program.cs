using System;

namespace CMP1903M_W05
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Josh",19,1);
            Student s2 = new Student("Joshua", 20, 1);
            s.Status();
             University U = new University("Lincoln", 1);
            U.addStudent(s);
            U.addStudent(s2);

            U.getNumberOfStudents();

            U.getAgeRangeOfStudents();
        }
    }
}
