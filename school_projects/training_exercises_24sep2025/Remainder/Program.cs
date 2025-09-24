using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Type two numbers, separated by comma: ");
string inputStr = Console.ReadLine();

string[] splitInputStr = inputStr.Split(',');
string firstNumStr = splitInputStr[0];
string secondNumStr = splitInputStr[1];

double firstNum = double.Parse(splitInputStr[0]);
double secondNum = double.Parse(splitInputStr[1]);
double result = firstNum % secondNum;
Console.WriteLine(result);