using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1

            Console.WriteLine("Give a number between 1-3: ");
            int numb = Convert.ToInt16(Console.ReadLine());

            if (numb == 1)
                Console.WriteLine("Number is one");
            else if (numb == 2)
                Console.WriteLine("Number is two");
            else if (numb == 3)
                Console.WriteLine("Number is three");
            else if (numb >= 4)
                Console.WriteLine("Wrong number");
            else
            {
                return;
            }



            //task 2


            Console.WriteLine("Give point limit: ");
            int point = Convert.ToInt16(Console.ReadLine());

            if (point <= 1)
                Console.WriteLine("Your grade is 0");
            else if (point <= 3)
                Console.WriteLine("Your grade is 1");
            else if (point <= 5)
                Console.WriteLine("Your grade is 2");
            else if (point <= 7)
                Console.WriteLine("Your grade is 3");
            else if (point <= 9)
                Console.WriteLine("Your grade is 4");
            else if (point <= 12)
                Console.WriteLine("Your grade is 5, " + ("Well done!"));


            //task 3

            Console.WriteLine("Give a first number ");






            Console.Read();
        }
    }
}
