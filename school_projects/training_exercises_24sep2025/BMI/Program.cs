using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter height(cm), and weight(kg), separated by comma: ");
string inputStr = Console.ReadLine();
string[] splitStr = inputStr.Split(',');
double height = double.Parse(splitStr[0]);
double weight = double.Parse(splitStr[1]);

double bMi = height / (weight * weight);
Console.WriteLine(bMi);