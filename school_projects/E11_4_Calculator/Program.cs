using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Enter operation code...");
Console.Write("(A->Addition, B->Subtraction, C->Multiplication, D->Division, E->Modulo): ");
string opCodeString = Console.ReadLine();

Console.Write("Enter two numbers separated by comma: ");
string numbersStr = Console.ReadLine();
string[] numbers = numbersStr.Split(',');
int firstNumber = int.Parse(numbers[0]);
int secondNumber = int.Parse(numbers[1]);

if ((opCodeString == "D" || opCodeString == "E") && secondNumber == 0)
{
    Console.WriteLine("Invalid input -- can't divide by zero!");
}
else
{
    switch (opCodeString)
    {
        case "A":
            Console.WriteLine(firstNumber + secondNumber);
            break;
        case "B":
            Console.WriteLine(firstNumber - secondNumber);
            break;
        case "C":
            Console.WriteLine(firstNumber * secondNumber);
            break;
        case "D":
            Console.WriteLine(firstNumber / secondNumber);
            break;
        case "E":
            Console.WriteLine(firstNumber % secondNumber);
            break; 
        default:
            Console.WriteLine("Invalid operation code!");
            break;
    
    }
}
    


