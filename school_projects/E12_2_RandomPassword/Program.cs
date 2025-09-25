using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Random random = new Random();

bool hasUpper = false;
bool hasLower = false;
bool hasNumber = false;
bool hasSpecial = false;

string temp_password = "";
for (int i = 0; i < 6; i++)
{
    int aRando = -1;
    if (!hasUpper)
    {
        aRando = random.Next(65, 91);
        hasUpper = true;
    }
    else if (!hasLower)
    {
        aRando = random.Next(97, 123);
        hasLower = true;
    }
    else if (!hasNumber)
    {
        aRando = random.Next(48, 58);
        hasNumber = true;
    }
    else if (!hasSpecial)
    {
        aRando = random.Next(58, 65);
        hasSpecial = true;
    }
    else
    {
        aRando = random.Next(48, 127);
    }
    
    char thisChar = (char)(aRando);
    temp_password += thisChar;
}

random = new Random();
string password = new string(temp_password.ToCharArray().OrderBy(c => random.Next()).ToArray());

Console.WriteLine(password);