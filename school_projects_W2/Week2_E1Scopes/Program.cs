using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
{
    Console.Write("Enter a number: ");
    string input = Console.ReadLine();

    input += 1;
    Console.WriteLine(input + "\n");
}

{
    Console.Write("Enter a number: ");
    int input = Convert.ToInt32(Console.ReadLine());
    input += 1;
    Console.WriteLine(input + "\n");
}
{
    Console.Write("Enter a number: ");
    char input = Convert.ToChar(Console.ReadLine());
    int charInt = Convert.ToInt32(input);
    charInt += 1;
    input = Convert.ToChar(charInt);
    Console.WriteLine(input);
}
