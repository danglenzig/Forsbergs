void MyFunction()
{
    Console.Write("Name: ");
    string userName = Console.ReadLine();
    if (IsNeo(userName))
    {
        return;
    }
    
    Console.Write("Age: ");
    int age = int.Parse(Console.ReadLine());
    if (!IsOver18(age))
    {
        return;
    }
    
    Console.Write("Do you want in?: ");
    string wantInStr = Console.ReadLine();
    
    if(!StringIsYes(wantInStr))
    {
        return;
    }
    
    Console.Write("Do you want out?: ");
    string wantOutStr = Console.ReadLine();
    if (!StringIsNo(wantOutStr))
    {
        return;
    }
    
    Console.WriteLine("You made it!");

}


bool IsNeo(string inString)
{
    return inString == "Neo";
}

bool IsOver18(int inInt)
{
    return inInt >= 18;
}

bool StringIsYes(string inStr)
{
    return inStr == "Yes";
}

bool StringIsNo(string inStr)
{
    return inStr == "No";
}

MyFunction();