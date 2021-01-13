using System;

namespace studentEnrollmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            System.Console.WriteLine(student.showInfo());
        }
    }
}
