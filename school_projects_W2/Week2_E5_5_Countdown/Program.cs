void CountDown(int fromInt)
{
    while (fromInt > 0)
    {
        Console.WriteLine(fromInt);
        fromInt--;
    }
}

CountDown(10);


void Fibonacci(int number)
{
    int a = 0;
    int b = 1;
    int c;
    
    Console.Write(a + " " + b + " ");
    for (int i = 2; i < number; i++)
    {
        c = a + b;
        Console.Write(c + " ");
        a = b;
        b = c;
    }

}

Fibonacci(30);