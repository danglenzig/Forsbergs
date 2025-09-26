using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.Black;

Console.Write("Enter a number: ");
int numberInput = Convert.ToInt32(Console.ReadLine());

int linesRemaining = numberInput;

string lineA = "";
string lineB = "";

for (int i = 1; i <= numberInput; i++)
{
    lineA += "#-";
}
for (int i = 1; i <= numberInput; i++)
{
    lineB += "-#";
}

DrawLine:
if (linesRemaining > 0)
{
    if (linesRemaining % 2 == 0)
    {
        Console.WriteLine(lineA);
    }
    else
    {
        Console.WriteLine(lineB);
    }

    linesRemaining -= 1;
    goto DrawLine;
}
else
{
    //
}