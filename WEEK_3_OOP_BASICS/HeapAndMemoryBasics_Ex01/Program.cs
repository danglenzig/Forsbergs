/*
class Car
{
    public string brand;
}

class Program
{
    static void Main()
    {
        Car carA = new Car();
        carA.brand = "Volvo";

        Car carB = carA;
        carB.brand = "BMW";
        
        Console.WriteLine(carA.brand); // BMW
        Console.WriteLine(object.ReferenceEquals(carA, carB));  // True
        Console.WriteLine(carA == carB);                        // also True

        int x = 5;
        int y = x;
        y = 10;
        Console.WriteLine(x == y); // False

    }
}
*/

using System.Runtime.InteropServices;

public class Person
{
    public string name;
}

class Program
{
    static void Main()
    {
        Person p1 = new Person();
        p1.name = "Alice";
        
        Person p2 =p1;
        p2.name = "Bob";
        
        Console.WriteLine(p1.name);
        Console.WriteLine(p2.name);
        
        Console.WriteLine(p1 == p2);
        Console.WriteLine(object.ReferenceEquals(p1, p2));
        
        Person p3 = new Person();
        p3.name = "RZA";
        
        Person p4 = new Person();
        p4.name = "Ol' Dirty";
        Console.WriteLine(p3.name);
        Console.WriteLine(p4.name);
        
        Console.WriteLine(p1 == p4);
        Console.WriteLine(object.ReferenceEquals(p3,p4));
        

    }
}