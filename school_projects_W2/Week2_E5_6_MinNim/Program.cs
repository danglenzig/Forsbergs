const int StartMatches = 10;
int remainingMatches = StartMatches;
void PrintRemainingMatches(int matches)
{
    while (matches > 0)
    {
        Console.Write("/");
        matches -= 1;
    }
    Console.WriteLine();
}


PrintRemainingMatches(remainingMatches);

while (remainingMatches > 0)
{
    Console.Write("1, 2, or 3: ");
    int inInt = Convert.ToInt32(Console.ReadLine());
    remainingMatches -= inInt;
    PrintRemainingMatches(remainingMatches);
}

