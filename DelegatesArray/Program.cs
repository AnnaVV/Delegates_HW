using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesArray
{
    class Program
    {
        public delegate int RandomInt();
        public delegate double AverageOfMethods(RandomInt[] array);

        static void Main(string[] args)
        {
            RandomInt delegate1 = delegate()
            {
                Random number = new Random();
                return number.Next(50);
            };

            RandomInt delegate2 = delegate() 
            { 
                Random number = new Random(); 
                return number.Next(5, 100); 
            };

            RandomInt delegate3 = delegate()
            {
                Random number = new Random();
                return number.Next(1,10);
            };

            
            RandomInt[] delegatesArray = new RandomInt[] { delegate1, delegate2, delegate3 };

            AverageOfMethods delegateForAverage = delegate (RandomInt[] inputArray) 
            {
               
                int sum = 0;

                foreach (RandomInt del in inputArray)
                {
                    sum += del();
                }
                return sum / inputArray.Length;
            };

            Console.WriteLine(delegateForAverage(delegatesArray));

            Console.ReadLine();

        }

    }
}
