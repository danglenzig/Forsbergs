using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter a number: ");
string inputStr = Console.ReadLine();

double inputDbl = Convert.ToDouble(inputStr);

double result = (inputDbl > 0.0) ? -inputDbl : -inputDbl;

Console.WriteLine($"The result is: " + result);