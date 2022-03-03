using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab2
{
    internal class Main_class
    {
        public static void Main(string[] args)
        {

            //1)
            WriteLine("1)---------------------------");
            Person person1 = new Person();
            Person person2 = new Person();

            WriteLine($"Is person1 == person2 {person1.Equals(person2)}");
            WriteLine($"Hash code for person1 {person1.GetHashCode()}");
            WriteLine($"Hash code for person2 {person2.GetHashCode()}");
            WriteLine("---------------------------");
            
            //2)
            WriteLine("2)---------------------------");
            Student student = new Student();
            Exam[] newExams = new Exam[] { new Exam("Python", 3, new DateOnly(2020, 12, 25)), new Exam("Graphic", 2, new DateOnly(2019, 6, 6)) };
            Test[] newTests = new Test[] { new Test("Python", true), new Test("C", false) };
            student.AddExams(newExams);
            student.AddTests(newTests);

            WriteLine(student);
            WriteLine("---------------------------");
            
            //3)
            WriteLine("3)---------------------------");
            WriteLine($"Person for student\n{student.Person}");
            WriteLine("---------------------------");

            //4)
            WriteLine("4)---------------------------");
            Student studentCopy = (Student)student.DeepCopy();
            Test[] tests = new Test[] { new Test("Philosofy", true) };
            student.AddTests(tests);
            WriteLine($"Original object\n{student}");
            WriteLine($"Copy object\n{studentCopy}");
            WriteLine("-----------------------------");

            //5)
            WriteLine("5)---------------------------");
            try
            {
                Student student2 = new Student() { Group = 700 };
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
            }
            WriteLine("-----------------------------");

            //6)
            WriteLine("6)---------------------------");
            foreach(object obj in student.AllGoodExams(3))
            {
                WriteLine(obj);
            }
            WriteLine("-----------------------------");


            //7)
            WriteLine("Name subjects which are peresent in tests and exams");
            WriteLine("7)---------------------------");
            foreach (var subject in student)
            {
                WriteLine(subject);
            }
            WriteLine("-----------------------------");


            //8)
            WriteLine("Passed exams and tests");
            WriteLine("8)---------------------------");
            foreach(object obj in student.PassedTestsAndExams())
            {
                WriteLine(obj);
            }
            WriteLine("-----------------------------");

            //9)
            WriteLine("Passed only tests");
            WriteLine("9)---------------------------");
            foreach(Test test in student.PassedOnlyTests())
            {
                WriteLine(test);
            }
            WriteLine("-----------------------------");
        }
    }
}
