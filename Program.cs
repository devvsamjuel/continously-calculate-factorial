using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int factorial(int x)
        {
            if (x==0)
            {
                return 1;
            }
            return x * factorial(x - 1);
        }
        static void calculateFactorial()
        {
            var strUserInput = Console.ReadLine();//string received
            //Console.WriteLine(strUserInput);
            int intUserInput; //= Convert.ToInt32(strUserInput);//integer equivalent of strUserInput
            var empty = String.IsNullOrWhiteSpace(strUserInput);//empty input
            if (!empty)
            {
                var isNumeric = int.TryParse(strUserInput,out intUserInput);
                if (!isNumeric)
                {
                    Console.WriteLine($"Enter a valid number");
                }
                Console.WriteLine($"The factorial of {intUserInput} is {factorial(intUserInput)}");
                calculateFactorial();
            }
           // Console.WriteLine("Enter another number to calculate again or press enter to quit");
            //var empty = String.IsNullOrWhiteSpace(Console.ReadLine());
            //if (!empty)
            //{
            //    calculateFactorial(x);
            //}
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What factorial?");
            calculateFactorial();

            //var check = true;
            //while (check)
            //{
            //    if (empty) { calculateFactorial(Convert.ToInt32(userInput)); }
            //    else { check = false; }
            //}

        }
    }
}
