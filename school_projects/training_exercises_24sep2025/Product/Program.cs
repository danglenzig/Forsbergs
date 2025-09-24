using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter two numbers, separated by comma: ");
string inputStr = Console.ReadLine();
string[] splitInput = inputStr.Split(',');
double firstNum = Convert.ToDouble(splitInput[0]);
double secondNum = Convert.ToDouble(splitInput[1]);

Console.WriteLine(firstNum * secondNum);