// See https://aka.ms/new-console-template for more information

using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("km/h: ");
string kmh = Console.ReadLine();
double kmhDouble = Convert.ToDouble(kmh);
double mhDouble = kmhDouble / 1.6;
Console.WriteLine("m/h = " + mhDouble);