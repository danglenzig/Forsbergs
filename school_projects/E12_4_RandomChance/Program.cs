using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Enter win percent chance: ");
int chance = Convert.ToInt32(Console.ReadLine());

if (chance > 100)
{
    chance = 100;
}

if (chance < 0)
{
    chance = 0;
}

Random random = new Random();

int aRando = random.Next(0, 100);

if (aRando < chance)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("You lose!");
}

