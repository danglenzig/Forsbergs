using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter a number: ");
string inString = Console.ReadLine();
int number =int.Parse(inString);

if (number % 2 == 0)
{
    Console.WriteLine("The number " + number + " is even.");
}
else
{
    Console.WriteLine("The number " + number + " is odd.");
}