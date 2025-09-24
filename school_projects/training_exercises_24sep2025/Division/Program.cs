using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Type two numbers, separated by a comma: ");
string inputStr = Console.ReadLine();

string[] splitInputStr = inputStr.Split(',');

string firstNumberStr = splitInputStr[0];
string secondNumberStr = splitInputStr[1];

double firstNumber = Convert.ToDouble(firstNumberStr);
double secondNumber = Convert.ToDouble(secondNumberStr);

Console.WriteLine(firstNumber / secondNumber);