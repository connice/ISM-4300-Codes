using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterative_Statements
{
    class Program
    {

        static void Main(string[] args)
        {
            //declare the variables 
            string n;
            int new_num;
            new_num = 1; //initialize the variable newnum that we would be ussing as a counter 

            //ask user to input number between 2 and 10
            Console.WriteLine("Enter a number between 2 and 10");

            //reads user input
            n = (Console.ReadLine());

            //all inputs ae string so this changes the string to and integer when user input a number 
            int N = int.Parse(n);


            //condition of whether or not user input an even or odd number 
            if (N % 2 == 1)

            {

                //if odd number subtract one and make it a variable newnum and spit out your have enter an odd number  newnum times
                new_num = N - 1;
                while (new_num > 0)
                {
                    Console.WriteLine("You entered an odd number");
                    new_num--;
                }


            }

            else

            {

                //if even number add one and make it a variable newnum and spit out your have enter an odd number  newnum times
                new_num = N + 1;
                while (new_num > 0)
                {
                    Console.WriteLine("You entered an even number");
                    new_num--;
                }
                ;

            }

            //Press any key to exit the program 
            Console.WriteLine("Thank you for your time ...Press any Key to exit! ");
            Console.ReadKey(true);
        }
    }
}
