using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter a number: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int currentNumber = inputNumber;

DrawNextLine:
string lineToDraw = "";
for (int i = 1; i <= currentNumber; i++)
{
    lineToDraw += "#";
}
Console.WriteLine(lineToDraw);
currentNumber -= 1;
if (currentNumber >= 0)
{
    goto DrawNextLine;
}
else
{
    Console.WriteLine("All done");
}
