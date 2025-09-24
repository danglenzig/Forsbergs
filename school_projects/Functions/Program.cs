using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

SomeFunction();
AnotherFunction();

void SomeFunction()
{
    Console.WriteLine("Hello World! My name is SomeFunction()");
}

void AnotherFunction(){}