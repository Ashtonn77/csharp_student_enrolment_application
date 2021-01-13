using System;

namespace studentEnrollmentApp
{
    public class Student
    {
        
        private string firstName;
        private string lastName;
        private int gradeYear;
        private int tuitionBalance = 0;
        private int courseCost = 600;
        private string courses = "";
        private string studentID;
        private static int id = 1000;



        // constructot - get student name and year
        public Student()
        {
            System.Console.Write("Enter student first name: ");
            this.firstName = Console.ReadLine();
            System.Console.Write("Enter student last name: ");
            this.lastName = Console.ReadLine();
            
            System.Console.Write("\n1. First year\n2. Second year\n3. Third year\n4. Forth year\nEnter student year of study: ");
            this.gradeYear = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("");

            this.studentID = generateStudentID();


            getCourses();
            System.Console.WriteLine("");
            makePayment();
            
        }

        private string getCourses()
        {
            do
            { 
                System.Console.Write("Enter student course or \'Q\' to quit: ");
                String course = Console.ReadLine();

                if(course != "Q" && course != "q")
                {
                    courses += ("\n  " + course);
                    tuitionBalance += courseCost;
                }
                else
                {
                   break;     
                }


            }while(true);


            return courses;

        }

        private string generateStudentID()
        {
            return gradeYear + "" + (id++);
        }

        private void viewBalance()
        {
            System.Console.WriteLine("Your current balance is R" + tuitionBalance);
        }
        private void makePayment()
        {
            viewBalance();
            System.Console.Write("How much would you like to pay: R");
            int payment = Convert.ToInt32(Console.ReadLine());
            tuitionBalance -= payment;
            System.Console.WriteLine("");
            System.Console.WriteLine("Thank you for your payment of R" + payment);
            System.Console.WriteLine("");


        }

        public string showInfo()
        {
            return String.Format("Student number: {0}\nName: {1} {2}\nYear of study: {3}\nEnrolled in: {4}\nTuition balance: R{5}", studentID, firstName, lastName, gradeYear, courses, tuitionBalance);
        }
       

    }
}
