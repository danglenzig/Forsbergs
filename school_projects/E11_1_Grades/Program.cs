using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.Write("Enter numerical grade: ");
string inStr = Console.ReadLine();
int numGrade = int.Parse(inStr);

if (numGrade > 100) {
numGrade = 100;
}
else if (numGrade < 0) {
numGrade = 0;
}

string letterGrade = "F";

/*
if (numGrade >= 90)
{
    letterGrade = "A";
}
else if (numGrade >= 80)
{
    letterGrade = "B";
}
else if (numGrade >= 70)
{
    letterGrade = "C";
}
else if (numGrade >= 60)
{
    letterGrade = "D";
}
else if (numGrade >= 50)
{
    letterGrade = "E";
}
else
{
    letterGrade = "F";
}
*/

switch (numGrade)
{
    case >= 90:
        letterGrade = "A";
        break; 
    case >= 80:
        letterGrade = "B";
        break;
    case >= 70:
        letterGrade = "C";
        break;
    case >= 60:
        letterGrade = "D";
        break;
    case >= 50:
        letterGrade = "E";
        break;
    default:
        letterGrade = "F";
        break;
}

Console.WriteLine("Letter grade: " + letterGrade);