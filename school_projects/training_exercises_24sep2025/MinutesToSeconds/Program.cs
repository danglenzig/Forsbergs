using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Minutes: ");
string inputStr = Console.ReadLine();
double minutesDouble = Convert.ToDouble(inputStr);
Console.WriteLine("Seconds: " + minutesDouble * 60.0);