Console.Write("How many numbers? ");
int userInput = Convert.ToInt32(Console.ReadLine());

int[] howManyNumbers = new int[userInput];


void AskHowMany()
{
    for (int i = 0; i < userInput; i++)
    {
        Console.Write("What goes in slot " + i + "? ");
        int thisValue = Convert.ToInt32(Console.ReadLine());
        howManyNumbers[i] = thisValue;
    }
}

int LookForNumber(int findNumber)
{
    int count = 0;
    
    

    for (int i = 0; i < howManyNumbers.Length; i++)
    {
        if (howManyNumbers[i] == findNumber)
        {
            count++;
        }
    }
    
    return count;
}

AskHowMany();

while (true)
{
    Console.WriteLine();
    Console.Write("What number are you looking for? ");
    int lookingFor = Convert.ToInt32(Console.ReadLine());

    if (lookingFor < 0)
    {
        break;
    }
    
    int result = LookForNumber(lookingFor);
    Console.WriteLine(lookingFor + " appears " + result + " times");
}
