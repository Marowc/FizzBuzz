using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        int max=0;

        public FizzBuzz(int upper)
        {
            this.max = upper;
        }
        public void Display()
        {
            for(int i=1; i<max; i++)
            {
                Console.WriteLine(" ");
                if(i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FIzzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if(i % 5 == 0) 
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
