using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter a letter: ");
string inString = Console.ReadLine();


// ||
bool isVowel = (inString == "A" || inString == "a" || inString == "E" || inString == "e" || inString == "I" || inString == "i" || inString == "O" || inString == "o" || inString == "U" || inString == "u");
bool isDigit = (inString == "0" || inString == "1" || inString == "2" || inString == "3" || inString == "4" || inString == "5" || inString == "6" || inString == "7" || inString == "8" || inString == "9");

if (isVowel)
{
    Console.Write("That's a vowel");
}
else if (isDigit)
{
    Console.Write("That's a digit");
}
else
{
    Console.Write("That's not a vowel or a digit. It is either a consonant or an Invalid input.");
}
