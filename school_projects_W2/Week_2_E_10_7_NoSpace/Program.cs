Console.Write("Enter a string: ");
string userInput = Console.ReadLine();

string newString = "";
for (int i = 0; i < userInput.Length; i++)
{
    if (userInput[i] != ' ')
    {
        newString += userInput[i];
    }
}

Console.WriteLine(newString);