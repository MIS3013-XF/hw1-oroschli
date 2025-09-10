// HW1b Grade

// Your Name: Olivia Roschli
// Did you seek help ? If yes, specify the helper or web link here: No

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname;
            string lname;
            double homework;
            double participation;
            double quiz;
            double midterm;
            double final;
            double sum;

            string homeworkAsString;
            string participationAsString;
            string finalAsString;
            string quizAsString;
            string midtermAsString;
            string idAsString;

            Console.WriteLine("What is your first name?");
            fname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lname = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            idAsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            homeworkAsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for participations?");
            participationAsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            quizAsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for midterm?");
            midtermAsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for final?");
            finalAsString = Console.ReadLine();

            const double hweight = 0.20;
            const double pweight = 0.15;
            const double qweight = 0.00;
            const double mweight = 0.15;
            const double fweight = 0.25;

            homework = Convert.ToDouble(homeworkAsString);
            participation = Convert.ToDouble(participationAsString);
            quiz = Convert.ToDouble(quizAsString);
            midterm = Convert.ToDouble(midtermAsString);
            final = Convert.ToDouble(finalAsString);

            homework = homework * hweight;
            participation = participation * pweight;
            quiz = quiz * qweight;
            midterm = midterm * mweight;
            final = final * fweight;

            sum = homework + participation + quiz + midterm + final;

            Console.WriteLine($"{fname} {lname} ({idAsString}), your final grade is {sum}%.");

            Console.ReadKey();

            
        }
    }
}
