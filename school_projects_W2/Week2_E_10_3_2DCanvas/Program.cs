string[,] twoDCanvas =  new string[5,5];


/*
 *
 * string[,] twoDCanvas =  new string[2,5];
 *                                    ^ ^
 *  columns---------------------------+ |
 *  rows--------------------------------+
 * 
 */
//Console.WriteLine(twoDCanvas.Length);


for (int i = 0; i < twoDCanvas.GetLength(0); i++)
{
    for (int j = 0; j < twoDCanvas.GetLength(1); j++)
    {
        twoDCanvas[i, j] = " - ";
    }
}

void PrintCanvas()
{
    for (int i = 0; i < twoDCanvas.GetLength(0); i++)
    {
        for (int j = 0; j < twoDCanvas.GetLength(1); j++)
        {
            Console.Write(twoDCanvas[i, j].ToString());
        }
        Console.WriteLine();
    }
}

PrintCanvas();
Console.WriteLine();

while (true)
{
    Console.Write("Enter x: ");
    int inX = int.Parse(Console.ReadLine());
    if (inX < 0)
    {
        inX = 0;
    }
    if (inX >= twoDCanvas.GetLength(0) - 1)
    {
        inX = twoDCanvas.GetLength(0) - 1;
    }
    
    Console.Write("Enter y: ");
    int inY = int.Parse(Console.ReadLine());
    if (inY < 0)
    {
        inY = 0;
    }
    if (inY >= twoDCanvas.GetLength(1) - 1)
    {
        inX = twoDCanvas.GetLength(0) - 1;
    }
    
    Console.Write("Enter value: ");
    string inValue = Console.ReadLine();

    if (inValue == "QUIT")
    {
        break;
    }
    
    twoDCanvas[inY, inX] = " " + inValue +  " ";
    
    PrintCanvas();
    Console.WriteLine();
    
}