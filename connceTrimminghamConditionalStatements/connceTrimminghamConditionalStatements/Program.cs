using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connceTrimminghamConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare user inputted score as string
            String Score;
            // prints the greeting to users and  ask for their total score out of 100 they expect to get in ISM 4300
            Console.WriteLine("Hi, Welcome to ISM 4300 score calculator");
            Console.WriteLine("Based on your perfermance in this class, please enter a total score out of 100 that you expect");

            // user enter their score
            Score = (Console.ReadLine());

            //even though score is inputed as a number it is still a string so this code cconverts that string to an integer
            int IntScore = int.Parse(Score);

            // assees the

            if (IntScore >= 98)
            {
                Console.WriteLine("You expect a Grade A+");
            }
            else if (IntScore >= 92 && IntScore <= 97)
            {
                Console.WriteLine("You expect a Grade A");
            }
            else if (IntScore >= 90 && IntScore <= 91)
            {
                Console.WriteLine("You expect a Grade A-");
            }

            else if (IntScore >= 88 && IntScore <= 89)
            {
                Console.WriteLine("You expect a Grade B+");
            }

            else if (IntScore >= 82 && IntScore <= 87)
            {
                Console.WriteLine("You expect a Grade B");
            }
            else if (IntScore >= 80 && IntScore <= 81)
            {
                Console.WriteLine("You expect a Grade B-");
            }

            else if (IntScore >= 78 && IntScore <= 79)
            {
                Console.WriteLine("You expect a Grade C+");

            }
            else if (IntScore >= 72 && IntScore <= 77)
            {
                Console.WriteLine("You expect a Grade C");
            }

            else if (IntScore >= 70 && IntScore <= 71)
            {
                Console.WriteLine("You expect a Grade C-");
            }

            else if (IntScore >= 68 && IntScore <= 69)
            {
                Console.WriteLine("You expect a Grade D+");
            }

            else if (IntScore >= 62 && IntScore <= 67)
            {
                Console.WriteLine("You expect a Grade D");
            }

            else if (IntScore >= 60 && IntScore <= 61)
            {
                Console.WriteLine("You expect a Grade D-");
            }

            else
            {
                Console.WriteLine("OHHHH NOOO! your expected score is below 60, this means You expect a Grade F,and Failed the Class");
            }


            //Press any key to exit the program 
            Console.WriteLine("Thank you for using the ISM 4300 Calculator...Press any Key to exit! ");
            Console.ReadKey(true);
        }
    }
}
        
                
    

