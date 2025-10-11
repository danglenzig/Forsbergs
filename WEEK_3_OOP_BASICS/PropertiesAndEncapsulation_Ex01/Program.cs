class Player
{
    private string name;
    private int health;
    private int level;

    public Player(string _name, int _level)
    {
        name = _name;
        level = _level;
    }
    
    public int Health
    {
        get =>health;
        set
        {
            if (value < 0) health = 0;
            if (value > 100) health = 100;
            else health = value;
        }
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
    }

    public void Heal(int amount)
    {
        Health += amount;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"Health: {health}");
    }

    public void SetHealth(int _health)
    {
        Health = _health;
    }
    
}

class ShopItem
{
    public string Name;
    public int Price;

    public bool IsExpensive
    {
        get => Price > 100;
    }

    public ShopItem(string _name, int _price)
    {
        Name = _name;
        Price = _price;
    }
}

class Car
{
    private int fuel;
    
    public string Brand;
    public int Fuel
    {
        get => fuel;
        set
        {
            if (value < 0) fuel = 0;
            else fuel = value;
        }
    }

    public bool IsEmpty
    {
        get => fuel <= 0;
    }

    public Car(string _brand, int _fuel)
    {
        Brand = _brand;
        Fuel = _fuel;
    }

    public void ReduceFuel(int _amount)
    {
        Fuel -= _amount;
    }

    public void IncreaseFuel(int _amount)
    {
        Fuel += _amount;
    }

    
    
    
}

class Program
{
    static void Main()
    {
        
        Player player = new Player("bob", 2);
        
        player.SetHealth(100);
        player.PrintHealth();
        Console.WriteLine();
        
        player.TakeDamage(60);
        player.PrintHealth(); // should print "Health: 40"
        Console.WriteLine();
        
        player.TakeDamage(60);
        player.PrintHealth(); // should print "Health: 0"
        Console.WriteLine();
        
        player.Heal(20);
        player.PrintHealth(); // should print "Health: 20
        Console.WriteLine();
        
        Console.WriteLine("--------------------------------------");
        
        ShopItem cheapItem = new ShopItem("Pepperoni", 10);
        ShopItem expensiveItem = new ShopItem("Caviar", 200);
        
        Console.WriteLine($"{cheapItem.Name} costs {cheapItem.Price}. Is expensive? {cheapItem.IsExpensive}");
        Console.WriteLine($"{expensiveItem} costs {expensiveItem.Price}. Is expensive? {expensiveItem.IsExpensive}");
        
        Console.WriteLine("--------------------------------------");
        
        Car car = new Car("Corvette", 100);
        Console.WriteLine($"{car.Brand} has {car.Fuel} litres. Is empty? {car.IsEmpty}");
        Console.WriteLine();
        
        car.ReduceFuel(60);
        Console.WriteLine($"{car.Brand} has {car.Fuel} litres. Is empty? {car.IsEmpty}");
        Console.WriteLine();
        
        car.ReduceFuel(60);
        Console.WriteLine($"{car.Brand} has {car.Fuel} litres. Is empty? {car.IsEmpty}");
        Console.WriteLine();
        
        car.IncreaseFuel(20);
        Console.WriteLine($"{car.Brand} has {car.Fuel} litres. Is empty? {car.IsEmpty}");
        Console.WriteLine();
        
        
    }
}