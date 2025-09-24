// See https://aka.ms/new-console-template for more information


// use periods as decimal points, not commas...
using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Operators!");


int x = 5 + 5;
int y = x + 5;
int z = y + y;

int add = 3 + 5;

int subtract = 6 - 12;
int multiply = 3 * 4;
int divide = 9/3;

int modulo = 10 % 3;

// operator precedence
// ()

int operation = 8 - (2-1);

int gold = 50;
gold += 10;
gold++;

float myFloat = 1.5f;
myFloat++;

Console.WriteLine(myFloat);

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " is even");
    }
    else
    {
        Console.WriteLine(i + " is odd");
    }
    
    Console.WriteLine(i);
}