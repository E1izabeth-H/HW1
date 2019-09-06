using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class StudentGrade
    {
        static void Main(string[] args)
        {
            //Elizabeth Haskins
            //Declare Variables
            string firstname;
            string lastname;
            string studentID;
            string participationAsString;
            string quizAsString;
            string homeworkAsString;
            string midtermAsString;
            string finalAsString;
            double homework, participation, quizzes, midterm, final, finalGrade;

            //Get input from user
            Console.WriteLine("What is your first name?");
            firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            studentID = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            homeworkAsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for participation?");
            participationAsString = Console.ReadLine();
            Console.WriteLine("What is your overall perventage grade for quizzes?");
            quizAsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the midterm?");
            midtermAsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the final?");
            finalAsString = Console.ReadLine();

            //Convert Strings to number data types
            homework = Convert.ToDouble(homeworkAsString);
            participation = Convert.ToDouble(participationAsString);
            quizzes = Convert.ToDouble(quizAsString);
            midterm = Convert.ToDouble(midtermAsString);
            final = Convert.ToDouble(finalAsString);

            finalGrade = (homework + participation + quizzes + midterm + final) / 5;

            //Output 
            string sentence = firstname + " " + lastname + " (" + studentID + "), " + "your final grade is "
                + (finalGrade / 100).ToString("P");

            Console.WriteLine(sentence);
            Console.ReadLine();
        }
    }
}
