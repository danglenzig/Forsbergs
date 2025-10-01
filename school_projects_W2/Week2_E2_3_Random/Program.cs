Random random = new Random();


PrintRandomInteger();
PrintRandomInteger();
PrintRandomInteger();
PrintRandomInteger();
PrintRandomInteger();
PrintRandomInteger();
PrintRandomInteger();

void PrintRandomInteger()
{
    int randoInt =  random.Next(0,101);
    Console.WriteLine(randoInt);
}