void AskIfBuy()
{
    if (GetAnswer("\nWanna buy game? "))
    {
        Console.WriteLine("Yay");
    }
    else
    {
        AskIfBuy();
    }
}

bool GetAnswer(string promptString)
{
    Console.Write(promptString);
    string answer = Console.ReadLine();
    return answer == "yes";
}

AskIfBuy();