using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter seed: ");
int seed = int.Parse(Console.ReadLine());

Random random = new Random(seed);

int valueOneA = random.Next(0, 5);
int valueOneB = random.Next(0, 5);
int valueOneC = random.Next(0, 5);
Console.WriteLine($"{valueOneA}, {valueOneB}, {valueOneC}");

double valueTwoA = random.NextDouble() * 0.5;
double valueTwoB = random.NextDouble() * 0.5;
double valueTwoC = random.NextDouble() * 0.5;
Console.WriteLine($"{valueTwoA}, {valueTwoB}, {valueTwoC}");

double valueThreeA = (random.NextDouble() * 0.5) + 0.2;
double valueThreeB = (random.NextDouble() * 0.5) + 0.2;
double valueThreeC = (random.NextDouble() * 0.5) + 0.2;
Console.WriteLine($"{valueThreeA}, {valueThreeB}, {valueThreeC}");

Console.Write("Enter crit chance: ");
double critChance = Convert.ToDouble(Console.ReadLine());
if (critChance < 0.0)
{
    critChance = 0;
}

if (critChance > 1.0)
{
    critChance = 1.0;
}

double attackOneRando = random.NextDouble();
double attackTwoRando = random.NextDouble();
double attackThreeRando = random.NextDouble();
double attackFourRando = random.NextDouble();
double attackFiveRando = random.NextDouble();

bool attackOneHits = attackOneRando <= critChance;
bool attackTwoHits = attackTwoRando <= critChance;
bool attackThreeHits = attackThreeRando <= critChance;
bool attackFourHits = attackFourRando <= critChance;
bool attackFiveHits = attackFiveRando <= critChance;

string attackOneResultString = (attackOneHits) ? "Crit" : "No Crit";
string attackTwoResultString = (attackTwoHits) ? "Crit" : "No Crit";
string attackThreeResultString = (attackThreeHits) ? "Crit" : "No Crit";
string attackFourResultString = (attackFourHits) ? "Crit" : "No Crit";
string attackFiveResultString = (attackFiveHits) ? "Crit" : "No Crit";

Console.WriteLine(attackOneResultString);
Console.WriteLine(attackTwoResultString);
Console.WriteLine(attackThreeResultString);
Console.WriteLine(attackFourResultString);
Console.WriteLine(attackFiveResultString);
