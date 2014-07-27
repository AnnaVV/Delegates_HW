using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {

        public delegate int Calculate(int x, int y);

        static void Main(string[] args)
        {
            Calculate sum = (int x, int y) => x + y;
            Calculate difference = (int x, int y) => x - y;
            Calculate product = (int x, int y) => x * y;
            Calculate quotient = (int x, int y) => x / y;

            Console.WriteLine("Please input first number");

            var firstArgument = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input second number");

            var secondArgument = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please choose operation: add/sub/mul/div");

            string operation = Console.ReadLine();


            switch (operation)
            {
                case "add":
                    {
                        Console.WriteLine("Result: {0}", sum(firstArgument, secondArgument));
                        break;
                    }
                case "sub":
                    {
                        Console.WriteLine("Result: {0}", difference(firstArgument, secondArgument));
                        break;
                    }
                case "mul":
                    {
                        Console.WriteLine("Result: {0}", product(firstArgument, secondArgument));
                        break;
                    }
                case "div":
                    {
                        Console.WriteLine("Result: {0}", quotient(firstArgument, secondArgument));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Sorry, you've chosen unsupported operation");
                        break;
                    }
            }

            Console.ReadLine();

        }
    }
}
