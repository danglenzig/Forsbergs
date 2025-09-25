using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter three numbers separated by comma: ");
string inString = Console.ReadLine();

string[] numbers = inString.Split(',');
int firstNum = int.Parse(numbers[0]);
int secondNum = int.Parse(numbers[1]);
int thirdNum = int.Parse(numbers[2]);


// get min
int min = firstNum;

if (secondNum < min)
{
    min = secondNum;
}
if (thirdNum < min)
{
    min = thirdNum;
}

// get max
int max = firstNum;
if (secondNum > max)
{
    max = secondNum;
}
if (thirdNum > max)
{
    max = thirdNum;
}

Console.WriteLine(min + ", " + max);