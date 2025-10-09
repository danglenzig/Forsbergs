

/*
class Animal
{
    public string name;
    public string sound;
    
    
    public Animal(string _name, string _sound)
    {
        name = _name;
        sound = _sound;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"{name} says {sound}");
    }
    
}

class Dog : Animal
{
    public Dog(string _name, string _sound) : base(_name, _sound)
    {
        
    }
}

class Cat : Animal
{
    public Cat(string _name, string _sound) : base(_name, _sound)
    {
        
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animalsList = new List<Animal>();
        animalsList.Add(new Dog("Buddy", "bark bark bark bark bark bark"));
        animalsList.Add(new Cat("Whiskers", "meow"));
        animalsList.Add(new Dog("Normal dog", "woof"));

        foreach (Animal animal in animalsList)
        {
            animal.Speak();
        }
        
    }
}
*/

class Vehicle
{
    public string brand;
    public int speed;

    public Vehicle(string _brand, int _speed)
    {
        brand = _brand;
        speed = _speed;
    }
    
    public virtual void ShowInfo()
    {
        Console.WriteLine($"{brand} goes {speed} km/h");
    }

    public virtual void Start()
    {
        Console.WriteLine("Vehicle starting...");
    }
    
}

class Car : Vehicle
{
    public string model;
    public Car(string _brand, int _speed, string _model) : base(_brand, _speed)
    {
        model = _model;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"\nThe {model} from...");
        base.ShowInfo();
    }

    public override void Start()
    {
        Console.WriteLine($"\n{model} starting...");
    }
}

class Motorcycle : Vehicle
{
    public string model;
    public bool hasSidecar;

    public Motorcycle(string _brand, int _speed, string _model, bool _hasSideCar) : base(_brand, _speed)
    {
        model = _model;
        hasSidecar = _hasSideCar;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"\nThe {model} from...");
        base.ShowInfo();
        Console.WriteLine(hasSideCarString());
    }

    public override void Start()
    {
        Console.WriteLine($"\n{model} starting...");
    }

    private string hasSideCarString()
    {
        if (hasSidecar)
        {
            return "...and has a sidecar!!";
        }
        else
        {
            return "...and has no sidecar :(";
        }
    }
}


class Truck : Vehicle
{
    public string model;
    public double cargoCapacity;

    public Truck(string _brand, int _speed, string _model, double _cargoCapacity) : base(_brand, _speed)
    {
        model = _model;
        cargoCapacity = _cargoCapacity;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"\nThe {model} from...");
        base.ShowInfo();
        Console.WriteLine($"...and has a cargo capacity of: {cargoCapacity}");
    }

    public override void Start()
    {
        Console.WriteLine($"\n{model} starting...");
    }
    
}

class Shape
{
    public virtual double Area()
    {
        return 0;
    }
    public virtual double Perimeter()
    {
        return 0;
    }
}

class Rectangle : Shape
{
    public double width;
    public double height;

    public Rectangle(double _width, double _height)
    {
        width = _width;
        height = _height;
    }

    public override double Area()
    {
        return width * height;
    }
    public override double Perimeter()
    {
        return (width * 2) + (height * 2);
    }
}

class Circle : Shape
{
    public double radius;
    
    public Circle(double _radius)
    {
        radius = _radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}


class Employee
{
    public virtual string Work()
    {
        return "";
    }
}

class MarketingSpecialist : Employee
{
    public override string Work()
    {
        return "I am marking specialist. I fuck around all day!";
    }
}

class Janitor : Employee
{
    public override string Work()
    {
        return "I'm the janitor. I get paid next to nothing to clean up your shit!";
    }
}


class Program
{
    static void Main()
    {
        Car theCorvette = new Car("Chevrolet", 100, "Corvette");
        //theCorvette.ShowInfo();
        
        Motorcycle theCrotchRocky = new Motorcycle("Kawasaki", 5000, "Crotch Rocky", false);
        //theCrotchRocky.ShowInfo();
        
        Truck theMauler = new Truck("Hummer", 10, "Mauler", 100.0);
        //theMauler.ShowInfo();

        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(theCorvette);
        vehicles.Add(theMauler);
        vehicles.Add(theCrotchRocky);

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.ShowInfo();
            vehicle.Start();
        }
        
        Rectangle rectangle01 = new Rectangle(100, 200);
        Rectangle rectangle02 = new Rectangle(200, 300);
        Circle circle01 = new Circle(300);
        Circle circle02 = new Circle(150);
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(rectangle01);
        shapes.Add(rectangle02);
        shapes.Add(circle01);
        shapes.Add(circle02);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"\nA {shape.GetType()} with an area of {shape.Area()}, and a perimeter of {shape.Perimeter()}");
        }
        
        
        MarketingSpecialist marketingSpecialist = new MarketingSpecialist();
        Janitor janitor = new Janitor();
        List<Employee> employees = new List<Employee>();
        employees.Add(janitor);
        employees.Add(marketingSpecialist);
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"\n{employee.ToString()} says: {employee.Work()}");
        }
    }
}

