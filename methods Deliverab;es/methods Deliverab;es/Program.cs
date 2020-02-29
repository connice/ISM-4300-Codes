using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_Deliverab_es
{
    class Program
    {
        static void My_Methods()
        {
            //declaring values 
            string a, b;
            int Add, Sub, Subb, Mul, div;
            Console.WriteLine("Please type type two numbers below and hit ENTER");

            Console.Write("Enter the First Number : ");

            //take sthe response from user 
            a = Console.ReadLine();

            Console.Write("Enter the second Number : ");
            b = Console.ReadLine();

            int A = int.Parse(a);
            int B = int.Parse(b);
            int ans = 0;
            char convert;

            Console.WriteLine("Now please enter which operation you wuld like to perform:1 for Addition, 2 for Subtraction, 3 for Multiplication, and 4 for Division.");
            convert = Convert.ToChar(Console.ReadLine());

            switch (convert)
            {
                case '1':
                    ans = A + B;
                    Console.WriteLine("Your addition for your numbers is: {0}", ans);
                    break;


                case '2':
                    ans = A - B;
                    Console.WriteLine("the difference between your numbers is:{0}", ans);
                    break;


                case '3':
                    ans = A * B;
                    Console.WriteLine("Your multiplication of your two numbers is: {0}", ans);
                    break;


                case '4':
                    ans = A / B;
                    Console.WriteLine("Your division for your two numbers is: {0}", ans);
                    break;

            }

            Console.ReadLine();

        }
        
      
          
static void Main(string[] args)
        {

            Console.WriteLine("Connice Trimmingham");
            My_Methods();
        }
    }
}
