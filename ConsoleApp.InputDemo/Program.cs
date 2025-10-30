namespace ConsoleApp.InputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string name = string.Empty;
            int age = 0;
            int retirmentAge = 62;
            int retirmentLeftYears = 0;
            //Prompt user
            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());
            //process reirment left years
            retirmentLeftYears = retirmentAge - age;
            //Output data
            Console.WriteLine($"Your Name is : {name}");
            Console.WriteLine($"Your Age is : {age}");
            Console.WriteLine($"Your RetirmentLeft Years : {retirmentLeftYears}");






        }
    }
}
