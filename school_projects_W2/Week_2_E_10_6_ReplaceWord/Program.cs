Console.Write("Enter some words, separated by space: ");
string words = Console.ReadLine();
string[] wordsArray = words.Split(' ');

int numberOfWords = wordsArray.Length;

Console.WriteLine($"The number of words is {numberOfWords}");

string newString = "";


for (int i = 0; i < numberOfWords; i++)
{
    string word = wordsArray[i];
    if (word == "hate")
    {
        word = "love";
    }
    
    newString += word + " ";
}

Console.WriteLine(newString);