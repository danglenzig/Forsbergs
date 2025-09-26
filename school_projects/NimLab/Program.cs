//using System.Globalization;
//Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

const int NumberOfMatches = 24;

Random random = new Random();
bool isPlayerTurn = true;
int matchesRemaining = NumberOfMatches;
int turnsPlayed = 0;


Console.WriteLine("Welcome to Nim!\n");

// Decide who goes first
Console.Write("Let's decide who goes first.\nChose heads (0) or tails (1): ");
int whoFirstInt = Convert.ToInt32(Console.ReadLine());

switch (whoFirstInt <= 0)
{
    case true:
        Console.WriteLine("You chose heads...\n");
        break;
    default:
        Console.WriteLine("You chose tails...\n");
        break;
}

int coinFlip = random.Next(0,2);

Console.WriteLine("(flips coin...)");
Console.Write("The result is: ");
switch (coinFlip <= 0)
{
    case true:
        Console.WriteLine("Heads!");
        break;
    default:
        Console.WriteLine("Tails!");
        break;
}

switch (coinFlip == whoFirstInt)
{
    case true: // Player goes first
        isPlayerTurn = true;
        Console.WriteLine("You go first.\n");
        break;
        
    default:  // CPU goes first
        isPlayerTurn = false;
        Console.WriteLine("CPU goes first.\n");
        break;
}

// Turn loop
StartNextTurn:

turnsPlayed++;

// Say who's turn it is
if (isPlayerTurn)
{
    Console.WriteLine("\n\nTurn number " + turnsPlayed + ": Player\n");
}
else
{
    Console.WriteLine("\n\nTurn number " + turnsPlayed + ": CPU\n");
}

// Print the remaining matches
Console.WriteLine("Remaining matches\n");
string matchesString = "";
for (int i = 0; i < matchesRemaining; i++)
{
    if (i < matchesRemaining - 1)
    {
        matchesString += "/ ";
    }
    else
    {
        matchesString += "/\n";
    }
}
Console.WriteLine(matchesString);


// Handle the final turn condition
if (matchesRemaining <= 1)
{
    if (isPlayerTurn)
    {
        Console.WriteLine("You lose!");
    }
    else
    {
        Console.WriteLine("You win!");
    }
}

else
{
    int matchesChosenThisTurn = 0;
    
    if (isPlayerTurn)
    {
        // Player turn
        // Let the player chose 1, 2, or 3 matches
        Console.Write("1, 2, or 3 matches? ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice < 1)
        {
            choice = 1;
        }

        if (choice > 3)
        {
            choice = 3;
        }
        matchesChosenThisTurn = choice;
        Console.WriteLine("Player removes " + matchesChosenThisTurn + " matches\n");
    }
    else
    {
        // CPU turn
        switch (matchesRemaining)
        {
            // handle endgame scenarios
            case 2:
                matchesChosenThisTurn = 1;
                break;
            case 3:
                matchesChosenThisTurn = 2;
                break;

            // Otherwise, randomly chose 1, 2, or 3 matches
            default:
                int aRando = random.Next(1,4);
                matchesChosenThisTurn = aRando;
                break;
        }
        Console.WriteLine("CPU removes " + matchesChosenThisTurn + " matches\n");
    }
    // update the game area
    matchesRemaining -= matchesChosenThisTurn;
    // toggle the turn value
    isPlayerTurn = !isPlayerTurn;
    
    goto StartNextTurn;
}
