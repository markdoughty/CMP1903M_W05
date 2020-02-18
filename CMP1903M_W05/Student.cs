using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903M_W05
{
    class Student
    {
        //Some properties describing a Student
        public string Name { get; set; }
        public int Age { get; set; }
        public int studentID { get; set; }
        public string UniCollege { get; set; }
        public string UniSchool { get; set; }
        public int courseID { get; set; }
        public string UniCourse { get; set; }
        public int Year { get; set; }

        public Student()
        {
            //Console.WriteLine("This is the default");
            Name = "defaultName";
            Age = 0;
            studentID = 0;
            UniCollege = "defaultCollage";
            UniSchool = "defaultSchool";
            courseID = 0;
            UniCourse = "defaultCourse";
            Year = 1;
        }

        public Student(string name, int age, int Y): this()
        {
            Name = name;
            Age = age;
            Year = Y;
            //Console.WriteLine($"Student - Name: {Name}, Age: {Age}, Year of Study: {Year}");
        }

        public void Status()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"student ID: {studentID}");
            Console.WriteLine($"Year of study: {Year}");
        }
    }
}
