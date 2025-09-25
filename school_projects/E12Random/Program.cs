using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Random random = new Random();


float randXFloat = (float)random.NextDouble();
float randYFloat = (float)random.NextDouble();

randXFloat *= 100;
randYFloat *= 100;

Console.WriteLine(randXFloat + "," + randYFloat);

int randXInt = random.Next(0, 101);
int randYInt = random.Next(0, 101);

Console.WriteLine(randXInt + "," + randYInt);