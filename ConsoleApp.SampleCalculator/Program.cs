// See https://aka.ms/new-console-template for more information
//sample calculator program
// Declare variables

// Welcome Message
Console.WriteLine("Welcome To Calculator Program");
Console.WriteLine("-------------------------------");
Console.WriteLine("Choose operation or (-1) To Exit");
Console.WriteLine("Please Select an operation");
Console.WriteLine("1- Adition");
Console.WriteLine("2- Substration");
Console.WriteLine("3- Production");
Console.WriteLine("4- Division");
Console.WriteLine("5- Fibonachie");
int operationNumber = Convert.ToInt32(Console.ReadLine());
while (operationNumber != -1)
{
    Console.Write("Enter First Number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Second Number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    int result = 0;
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
        case 5:
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                result += i;
            }

            break;
        default:
            Console.WriteLine("Wrong Operation");

            break;

    }
    Console.WriteLine($"Answer is : {result} ");
    Console.WriteLine("Press Enter To Continue");
    Console.ReadLine();
    Console.WriteLine("Choose operation or (-1) To Exit");
    Console.WriteLine("Please Select an operation");
    Console.WriteLine("1- Adition");
    Console.WriteLine("2- Substration");
    Console.WriteLine("3- Production");
    Console.WriteLine("4- Division");
    Console.WriteLine("5- Fibonachie");
     operationNumber= Convert.ToInt32(Console.ReadLine());



}//End of while
    Console.WriteLine("Thank you  for using program");
















