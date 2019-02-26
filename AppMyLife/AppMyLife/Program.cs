using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMyLife
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;




            Console.WriteLine("Enter age here please: "); //asks for you to enter your age
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type out your name: ");
            name = Console.ReadLine();

            Console.WriteLine(name + age);
            Console.ReadLine();

        }
    }
}
