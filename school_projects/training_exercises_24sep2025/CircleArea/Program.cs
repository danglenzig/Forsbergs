using System.Globalization;
using System;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
double pi = Math.PI;

Console.Write("Input radius: ");
string radiusStr = Console.ReadLine();
double radius = double.Parse(radiusStr);

double area = Math.PI * radius * radius;
Console.WriteLine(area);