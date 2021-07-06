using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoursesLibNS;

namespace ConsoleAppNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o código do curso: ");
            int code = int.Parse(Console.ReadLine());
            CoursesLibClass curso = new CoursesLibClass();
            Console.WriteLine(curso.ShowCourseName(code));
            Console.ReadKey();
        }
    }
}
