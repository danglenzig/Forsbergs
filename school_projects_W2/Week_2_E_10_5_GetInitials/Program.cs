Console.Write("Enter your first and last name, separated by a space: ");
string firstAndLastName = Console.ReadLine();
string[] firstAndLastNameSplit = firstAndLastName.Split(' ');
string firstName =  firstAndLastNameSplit[0];
string lastName =  firstAndLastNameSplit[1];

Console.Write(firstName + " " + lastName);
char firstInitial = firstName[0];
char lastInitial = lastName[0];
Console.Write(", but my friends call me " + firstInitial + "." + lastInitial + ".");