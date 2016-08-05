using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGB
{
    public class CreateStudents
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[8];
            int x;
            int id;
            string name;
            double gpa;
            for (x = 0; x < student.Length; x++)
            {
                GetData(out id, out name, out gpa);
                student[x] = new Student(id, name, gpa);
            }

            Array.Sort(student);
            Console.WriteLine("Sorted List");
            for (x = 0; x < student.Length; x++)
            {
                Display(student[x]);
            }
            Console.ReadKey();
        }

        public static void Display(Student stu)
        {
            Console.WriteLine("{0,5} {1, -10}{2,6}",
                stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
        }

        public static void GetData(out int id, out string name, out double gpa)
        {
            string inString;
            Console.Write("Please enter student ID number: ");
            inString = Console.ReadLine();
            id = Convert.ToInt32(inString);
            Console.Write("Please enter last name for student {0}: ", id);
            name = Console.ReadLine();
            Console.Write("Please enter grade point average: ");
            inString = Console.ReadLine();
            gpa = Convert.ToDouble(inString);

        }
    }
}
