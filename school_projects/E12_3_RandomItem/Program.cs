using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

string item1 = "Health Potion";
string item2 = "Stamina Potion";
string item3 = "Ammo Pack";
string item4 = "Mana Potion";
string item5 = "Loot Box";

int item1Percent = 50;
int item2Percent = 20;
int item3Percent = 15;
int item4Percent = 10;
int item5Percent = 5;

Random random = new Random();
int randoInt = random.Next(1, 101);

string droppedItemString = "";

if (randoInt >= item1Percent)
{
    droppedItemString = item1;
}
else if (randoInt >= item2Percent)
{
    droppedItemString = item2;
}
else if (randoInt >= item3Percent)
{
    droppedItemString = item3;
}
else if (randoInt >= item4Percent)
{
    droppedItemString = item4;
}
else
{
    droppedItemString = item5;
}

Console.WriteLine(randoInt);
Console.WriteLine(droppedItemString);