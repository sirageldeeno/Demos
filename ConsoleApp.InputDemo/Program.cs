using System.Xml.Linq;

namespace ConsoleApp.InputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string firstName = string.Empty;
            string lastName = string.Empty;

            int age = 0;
            int retirmentAge = 62;
            int retirmentLeftYears = 0;
            //Prompt user
            Console.WriteLine("Enter your first name : ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name : ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());
            //process reirment left years
            retirmentLeftYears = retirmentAge + age;
            //Output data
            Console.WriteLine($"Your full Name is : {firstName} {lastName}");
            Console.WriteLine($"Your Age is : {age}");
            Console.WriteLine($"Your RetirmentLeft Years : {retirmentLeftYears}");






        }
    }
}
