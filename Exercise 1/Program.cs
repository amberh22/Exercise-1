using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the program.  What year were you born?  This is YYYY/MM/DD format.");
            string yearOfBirth = Console.ReadLine();
            Console.WriteLine("Please type your month of birth here.");
            string monthOfBirth = Console.ReadLine();
            Console.WriteLine("Please type the day of the month you were born.");
            string dayOfBirth = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
