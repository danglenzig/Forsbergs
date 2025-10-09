/*
class Car
{
    public string brand;
    public int speed;
    
    // default constructor
    public Car()
    {
        brand = "Unknown";
        speed = 0;
        Console.WriteLine("Car created with default values");
    }
    
    // paramaterized constructor
    public Car(string _brand, int _speed)
    {
        brand = _brand;
        speed = _speed;
        Console.WriteLine($"Car created with brand: {brand}, speed: {speed}");
    }

    public void Drive()
    {
        Console.WriteLine($"Car driven with brand: {brand}, speed: {speed}");
    }
    
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        car1.Drive();

        Car car2 = new Car("Toyota", 50);
        car2.Drive();
        
        Car car3 = new Car("Ferrari", 120);
        car3.Drive();
    }
}
*/

public class Animal
{
    public string species;
    public int age;

    public Animal()
    {
        species = "unknown";
        age = -1;
    }
    public Animal(string _species, int _age)
    {
        species = _species;
        age = _age;
    }

    public Animal(string _species)
    {
        species = _species;
        age = -1;
    }

    public Animal(int _age)
    {
        species = "unknown";
        age = _age;
    }
    
}

class Program
{
    static void Main()
    {
        Animal unknownAnimal = new Animal();
        Console.WriteLine($"An animal of species: {unknownAnimal.species}, of age: {unknownAnimal.age}");
        // An animal of species: unknown, of age: -1

        Animal twoYearOldWolf = new Animal("wolf", 2);
        Console.WriteLine($"An animal of species {twoYearOldWolf.species}, of age {twoYearOldWolf.age}");
        // An animal of species wolf, of age 2
        
        Animal wolfOfUnknownAge = new Animal("wolf");
        Console.WriteLine($"An animal of species {wolfOfUnknownAge.species}, of age {wolfOfUnknownAge.age}");
        // An animal of species wolf, of age -1
        
        Animal unknownTwoYearOldAnimal = new Animal(6);
        Console.WriteLine($"An animal of species {unknownTwoYearOldAnimal.species}, of age {unknownTwoYearOldAnimal.age}");
        // An animal of species unknown, of age 6
    }
    
}