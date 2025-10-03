const int MinValue = 10;
const int MaxValue = 20;





int AskANumberBetween(int minVal, int maxVal)
{
    int userGuess = -1;
    do
    {
        Console.Write("Enter a number: ");
        userGuess = Convert.ToInt32(Console.ReadLine());
    } while(userGuess < MinValue || userGuess > MaxValue);
    return userGuess;
}


int theGuess = AskANumberBetween(MinValue, MaxValue);
Console.WriteLine(theGuess);