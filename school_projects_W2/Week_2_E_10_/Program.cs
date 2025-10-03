Console.Write("Enter a string: ");
string str = Console.ReadLine();

int length = str.Length;

for (int i = length - 1; i >= 0; i--)
{
    Console.Write(str[i]);
}