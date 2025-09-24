using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter seconds: ");
string inputStr = Console.ReadLine();
int numberOfSeconds = int.Parse(inputStr);
int numberOfMinutes = numberOfSeconds / 60;
int remainder = numberOfSeconds % 60;

Console.WriteLine(numberOfMinutes + " minutes, " + remainder + " seconds");