void PlayGame()
{
    string userInput = "";
    
    StartOver:
    // Console.Clear();
    Console.Write("\n\nPick ROCK, PAPER, or SCISSORS: ");
    userInput = Console.ReadLine().ToUpper();
    if (!IsGoodInput(userInput))
    {
        Console.WriteLine("You entered an incorrect input.");
        goto StartOver;
    }

    string cpuChoice = GetCpuChoice();
    
    Console.WriteLine("CPU choses " + cpuChoice);

    if (cpuChoice == userInput)
    {
        Console.WriteLine("It's a tie...");
        goto StartOver;
    }
    else
    {
        switch (userInput)
        {
            case "ROCK":
            {
                if (cpuChoice == "PAPER")
                {
                    Console.WriteLine("CPU Wins!");
                }
                else
                {
                    Console.WriteLine("You Wins!");
                }
                break;
            }

            case "PAPER":
            {
                if (cpuChoice == "SCISSORS")
                {
                    Console.WriteLine("CPU Wins!");
                }
                else
                {
                    Console.WriteLine("You Wins!");
                }
                break;
            }

            case "SCISSORS":
            {
                if (cpuChoice == "ROCK")
                {
                    Console.WriteLine("CPU Wins!");
                }
                else
                {
                    Console.WriteLine("You Wins!");
                }
                break;
            }
                
        }
        Console.Write("Play again? Y/N: ");
        string playAgain = Console.ReadLine().ToUpper();
        if (playAgain == "Y")
        {
            PlayGame();
        }
        else
        {
            return;
        }
    }
}

string GetCpuChoice()
{
    string output = "";
    Random random = new Random();
    int randoInt = random.Next(1,4);

    switch (randoInt)
    {
        case 1:
            output = "ROCK";
            break;
        case 2:
            output = "PAPER";
            break;
        case 3:
            output = "SCISSORS";
            break;
        default:
            output = "SCISSORS";
            break;
    }
    
    return output;
}



bool IsGoodInput(string input)
{
    bool isGood = true;
    if ((input != "ROCK") && (input != "PAPER") && (input != "SCISSORS"))
    {
        isGood = false;
    }
    return isGood;
}

PlayGame();
