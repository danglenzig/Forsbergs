int timer = 5;

void CountDown()
{
    Console.WriteLine(timer);
    timer -= 1;
    if (timer >= 0)
    {
        CountDown();
    }
}

CountDown();