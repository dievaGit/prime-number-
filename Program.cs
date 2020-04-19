using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring data
            int num = 0;

            //Requesting data from the user
            Console.Write(" Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Validating the number
            if(num >= 1 && num <= 100)
            {
                if((num == 2) || (num == 3) || (num == 5) || (num == 7))
                {
                    Console.WriteLine(" The number {0} is prime", num);
                }
                else
                { 
                  if ((num % 2 != 0) && (num % 3 != 0) && (num % 5 != 0) && (num % 7 != 0))
                  {
                        Console.WriteLine(" The number {0} is prime", num);
                  }
                  else
                  {
                        Console.WriteLine(" The number {0} is not prime", num);
                  }
                }
            }
            else
            {
                Console.WriteLine(" The number {0} is not valid", num);
            }

            Console.ReadKey();
        }
    }
}
