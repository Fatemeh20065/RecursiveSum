using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
            // Recursive method to calculate sum from n down to 1
        static int SumToOne(int n)
             {
                  if (n <= 1) // base case
                    return 1;
                    return n + SumToOne(n - 1); // recursion
             }

        static void Main(string[] args)
             {
                   Console.Write("Please enter a positive number: ");
                     int number = int.Parse(Console.ReadLine());

                         if (number <= 0)
                             {
                                    Console.WriteLine("Error: The number must be greater than 0.");
                             }
                        else
                             {
                                     int result = SumToOne(number);
                                     Console.WriteLine("The sum of numbers from {0} down to 1 is: {1}",number,result);
                             }
                         Console.ReadKey();
                }   
      }


}

