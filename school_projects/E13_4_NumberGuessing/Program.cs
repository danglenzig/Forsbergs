using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


StartOver:

Random random = new Random();
int randoInt = random.Next(1, 1001);

Console.WriteLine("I have chosen a number. Try to guess it!");
//Console.WriteLine("(Hint: the number is " + randoInt + ")");

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
    Console.Write("Wrong! ");
    if (yourGuess > randoInt)
    {
        Console.WriteLine("Too high...\n");
    }
    else
    {
        Console.WriteLine("Too low...\n");
    }
    goto IngestGuess;
}

Console.Write("\n\n");
goto StartOver;
