using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputConniceTrimmingham
{
    class Program
    {
        static void Main(string[] args)
        {
           //declare the variables 
            string Answer;

            //prints the greeting to users
            Console.WriteLine("Hi, My name is Connice Trimmingham!");
            Console.WriteLine("Thank You for loging in....What can I do for you today?");

            //Ask user to enter their response and press the enter key
            Console.WriteLine("Please type your Request below and hit ENTER");
           
            //take sthe response from user 
            Answer = Console.ReadLine();

            // prints the output from user
            Console.WriteLine("Your request is:'{0}'", Answer);

            //Press any key to exit the program 
            Console.WriteLine("Thank you for your request...Press any Key to exit! ");
            Console.ReadKey(true);
        }
    }
}
