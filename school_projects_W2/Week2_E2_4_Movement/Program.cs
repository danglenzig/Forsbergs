

MoveForwandNTimes(3);
MoveRightNTimes(2);
MoveForwandNTimes(3);
MoveRightNTimes(3);
MoveForwandNTimes(3);
MoveRightNTimes(3);
MoveForwandNTimes(1);
MoveRightNTimes(2);
MoveForwandNTimes(1);

void MoveForwandNTimes(int repeat)
{
    for (int i = 0; i < repeat; i++)
    {
        Console.WriteLine("Move Forward");
    }
}

void MoveRightNTimes(int repeat)
{
    for (int i = 0; i < repeat; i++)
    {
        Console.WriteLine("Move Right");
    }
}