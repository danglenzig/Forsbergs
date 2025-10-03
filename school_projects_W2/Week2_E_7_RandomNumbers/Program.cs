Random random = new Random();
int GetRandomDigit()
{
   int thisInt =  random.Next(0, 10);
   return thisInt;
}

void PrintNRandomDigits(int number)
{
   for (int i = 0; i < number; i++)
   {
      int aRando = GetRandomDigit();
      Console.Write($"{aRando} " + " ");
   }
}

PrintNRandomDigits(GetRandomDigit() * 10);