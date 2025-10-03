void HandleTimer(int timer)
{
    if (timer <= 0)
    {
        return;
    }
    Console.WriteLine(timer);
    timer -= 1;
    HandleTimer(timer);
}

HandleTimer(6);
