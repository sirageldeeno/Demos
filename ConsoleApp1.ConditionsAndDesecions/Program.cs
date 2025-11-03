// See https://aka.ms/new-console-template for more information
Console.Write("Enter Your Grade : ");
int grade = Convert.ToInt32( Console.ReadLine() );
 if (grade >50 )
{
    Console.WriteLine("Student Passed");


}
else
{
    Console.WriteLine("Student Has Failed");
    Console.WriteLine("Recommend Student to Student Affairs Office");
}
Console.WriteLine("Thanks your for using program");
