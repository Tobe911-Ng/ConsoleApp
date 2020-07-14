using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    class Class1
    {
        public static string GetName(){
            Console.WriteLine("Enter your name");
            string getName = Console.ReadLine();
            return getName;
        }
        public static int GetAge(){
            int age = 0;

            Console.WriteLine("Enter your Date of Birth (DD/MM/YYYY)");
            string getDate = Console.ReadLine();

            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;

            try
            {
                DateTime dob = Convert.ToDateTime(getDate);
                int birthYear = dob.Year;
                int birthMonth = dob.Month;
                int birthDay = dob.Day;
                age = currentYear - birthYear;
                if (currentMonth < birthMonth)
                {
                    --age;
                }
                else if (currentMonth == birthMonth)
                {
                    if(currentDay > birthDay)
                    {
                        --age;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Incorrect date format");
            }

            return age;
        }
    }
}
