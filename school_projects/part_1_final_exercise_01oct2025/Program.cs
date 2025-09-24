using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

const int SecondsPerDay = 86400;
const int SecondsPerHour = 3600;
const int SecondsPerMinute = 60;

Console.Write("Enter a number of seconds: ");
string inputStr = Console.ReadLine();

int inputSeconds =  int.Parse(inputStr);


int numberOfDays = inputSeconds / SecondsPerDay;
int remainder = inputSeconds % SecondsPerDay;

int numberOfHours = remainder / SecondsPerHour;
remainder = remainder % SecondsPerHour;

int numberOfMinutes = remainder / SecondsPerMinute;
remainder = remainder % SecondsPerMinute;

Console.WriteLine("Seconds: " + remainder);
Console.WriteLine("Minutes: " + numberOfMinutes);
Console.WriteLine("Hours: " + numberOfHours);
Console.WriteLine("Days: " + numberOfDays);

string formattedResultString = numberOfDays + "." + numberOfHours + ":" + numberOfMinutes + ":" + remainder;
Console.WriteLine("Formatted result: " + formattedResultString);

double daysDouble = Convert.ToDouble(inputSeconds) / Convert.ToDouble(SecondsPerDay);
Console.WriteLine("In total, that's : " + daysDouble + " Days.");


