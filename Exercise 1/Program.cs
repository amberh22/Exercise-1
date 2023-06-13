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
            var yearOfBirthInt = ToInt(yearOfBirth);

            Console.WriteLine("Please type your month of birth here.");
            string monthOfBirth = Console.ReadLine();
            var monthOfBirthInt = ToInt(monthOfBirth);

            Console.WriteLine("Please type the day of the month you were born.");
            string dayOfBirth = Console.ReadLine();
            var dayOfBirthInt = ToInt(dayOfBirth);

            //Combine all of the ints into one date of birth.
            DateTime newdate = new DateTime(yearOfBirthInt, monthOfBirthInt, dayOfBirthInt);
            Console.WriteLine(newdate.ToShortDateString);
        }
        public static int ToInt(string value)
        {
            var success = int.TryParse(value, out var result);
            if (success)
            {
                return result;
            }
            Console.WriteLine($"Your value {value} is not a number.  Please enter your value again");
             
            Main(null);
            return 0;
        }
    }
}
