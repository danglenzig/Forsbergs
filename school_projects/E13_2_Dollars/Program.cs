using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("How many Dollars? ");
int dollarsInput = Convert.ToInt32(Console.ReadLine());
int dollarsLeft = dollarsInput;

string dollarString = "";


AddDollar:
if (dollarsLeft > 0)
{
    dollarString += "$";
    dollarsLeft -= 1;
    goto AddDollar;
}
else
{
    Console.WriteLine("Here's your dollars: " +  dollarString);
}
