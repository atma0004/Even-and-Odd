using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("please enter a number!");
            int number;
            number=Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
                {
                Console.WriteLine("your number is even");
                }
            else
                {
                Console.WriteLine("your number is odd");
                }
            }
        }
    }
