using System;
using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter lengths, separated by comma: ");
string inputStr = Console.ReadLine();
string[] splitStr = inputStr.Split(',');
double sideOne = double.Parse(splitStr[0]);
double sideTwo = double.Parse(splitStr[1]);

double hypotenuse = Math.Sqrt(  (sideOne * sideOne) + (sideTwo * sideTwo)  );
Console.WriteLine($"Hypotenuse: " + hypotenuse);

