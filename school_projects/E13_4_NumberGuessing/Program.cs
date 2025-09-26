using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Random random = new Random();
int randoInt = random.Next(1, 101);

Console.WriteLine("I have chosen a number. Try to guess it!");
Console.WriteLine("(Hint: the number is " + randoInt + ")");

int numberOfGuesses = 0;

IngestGuess:
numberOfGuesses += 1;
Console.Write("Your guess: ");
int yourGuess = Convert.ToInt32(Console.ReadLine());
if (yourGuess == randoInt)
{
    Console.WriteLine("You Won in " + numberOfGuesses + " guesses!");
}
else
{
    Console.WriteLine("Wrong!");
    goto IngestGuess;
}
