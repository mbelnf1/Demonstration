using System;

namespace Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo = "";
            int myNumber = 0;
            bool islucky = false;
//1=0 is an assignment, ! is not 
            if (myNumber != 0)
            {
                Console.WriteLine("You entered a number of {0}", myNumber);
            }
            else
            {
                Console.WriteLine("You have not updated my number");
            }
            //case works like an if and default is like an else statement
            switch (demo)
            {
                case "Jon":
                    Console.WriteLine("You are my son");
                    break;
                case "Charity":
                    Console.WriteLine("You are my Wife");
                    break;
                default:
                    Console.WriteLine("I do not know you");
                    break;
            }
        }
    }
}
