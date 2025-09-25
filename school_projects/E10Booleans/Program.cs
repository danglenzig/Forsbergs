using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("What is your age? ");
string age = Console.ReadLine();
int ageInt = Convert.ToInt32(age);

bool isAChild = (ageInt >= 0 && ageInt <= 12);
bool isATeenager = (ageInt > 12 && ageInt <= 19);
bool isAnAdult = (ageInt > 19);

Console.WriteLine("You are a child: " + isAChild);
Console.WriteLine("You are a teenager: " + isATeenager);
Console.WriteLine("You are an adult: " + isAnAdult);