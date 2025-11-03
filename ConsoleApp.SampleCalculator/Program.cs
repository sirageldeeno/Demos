// See https://aka.ms/new-console-template for more information
//sample calculator program
// Declare variables
int result=0;
// Welcome Message
Console.WriteLine("Welcome To Calculator Program");
// prompt user to Enter First number and Second number
Console.Write("Enter First Number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Second Number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
// Show user Options
Console.WriteLine("Please Select an operation");
Console.WriteLine("1- Adition");
Console.WriteLine("2- Substration");
Console.WriteLine("3- Production");
Console.WriteLine("4- Division");
// Read Operation
int operationNumber= Convert.ToInt32(Console.ReadLine());
// process calculation
switch (operationNumber)
{
    case 1:
        result = firstNumber + secondNumber;
      
        break;
    case 2:
        result = firstNumber - secondNumber;
        
        break;
    case 3:
        result = firstNumber * secondNumber;
       
        break;
    case 4:
        result = firstNumber / secondNumber;
        
        break;
    default:
        Console.WriteLine("Wrong Operation");

        break;

}
Console.WriteLine($"Answer is : {result} ");
















