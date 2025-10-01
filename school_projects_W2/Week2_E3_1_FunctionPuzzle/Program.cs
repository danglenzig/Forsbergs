void F1()
{
    // prints A
    Console.Write("A");
}

void F2()
{
    // prints BA
    Console.Write("B");
    F1();
}

void F3()
{
    // prints A-BA
    F1();
    Console.Write("-");
    F2();
}

void F4()
{
    // prints -A
    Console.Write("-");
    F1();
}

/*
F1();
Console.WriteLine("\n");

F2();
Console.WriteLine("\n");

F3();
Console.WriteLine("\n");

F4();
Console.WriteLine("\n");
*/

F2();
F3();
F2();
F1();
F4();
F4();
F3();