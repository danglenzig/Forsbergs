// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Globalization;

// use periods as decimal points, not commas...
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Output: Give me a number.");
string numberString = Console.ReadLine();

double numberAsDouble = Convert.ToDouble(numberString);

Console.WriteLine(numberAsDouble);

int numberAsInt = Convert.ToInt32(numberAsDouble);

Console.WriteLine(numberAsInt);