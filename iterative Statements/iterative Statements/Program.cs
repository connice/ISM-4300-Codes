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
            string n;
            int new_num;
            new_num = 1;


            Console.WriteLine("Enter a number between 2 and 10");
            n = (Console.ReadLine());
            int N = int.Parse(n);

            if (N % 2 == 1)

            {
                new_num = N - 1;
                while (new_num > 0)
                {
                    Console.WriteLine("You entered an odd number");
                    new_num--;
                }


            }

            else

            {
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
