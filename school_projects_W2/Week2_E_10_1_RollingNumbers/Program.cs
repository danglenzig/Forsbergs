Random random = new Random();
int[] zeroToTen= new int[10];

const int NumberOfRolls = 10000;

for (int i = 0; i < NumberOfRolls; i++)
{
    int randoInt = random.Next(0, 10);
    zeroToTen[randoInt] += 1;
}

for (int j = 0; j < zeroToTen.Length; j++)
{
    Console.WriteLine("I rolled "+ j + " " + zeroToTen[j] + " times.");
}

int sum = 0;
for (int k = 0; k < zeroToTen.Length; k++)
{
    sum += zeroToTen[k];
}
Console.WriteLine();
Console.WriteLine("Total rolls: " + sum);

