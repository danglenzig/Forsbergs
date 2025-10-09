/*
class Car
{
    public string brand;
    public int speed;

    public void Drive(int increment)
    {
        speed += increment;
        Console.WriteLine($"{brand} drives at speed: {speed}");
    }

    public void Brake(int decrement)
    {
        speed -= decrement;
        if (speed < 0)
        {
            speed = 0;
        }
        Console.WriteLine($"{brand} slows down to speed: {speed}");
    }

    public bool IsMoving()
    {
        return speed > 0;
    }
    
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.brand = "Honda";
        myCar.speed = 0;
        
        myCar.Drive(30);
        myCar.Drive(20);
        myCar.Drive(15);
        
        bool moving = myCar.IsMoving();
        
        Console.WriteLine($"Is the car moving? {moving}");
        
        myCar.Brake(70);
        Console.WriteLine($"Is the car braking? {myCar.IsMoving()}");
    }
}
*/

public class Lamp
{
    public bool isOn;

    public void TurnOn()
    {
        isOn = true;
        Console.WriteLine("Lamp is on");
    }

    public void TurnOff()
    {
        isOn = false;
        Console.WriteLine("Lamp is off");
    }

    public void Toggle()
    {
        isOn = !isOn;
        if (isOn)
        {
            Console.WriteLine("Lamp is on");
        }
        else
        {
            Console.WriteLine("Lamp is off");
        }
    }
}

class Program
{
    static void Main()
    {
        Lamp myLamp = new Lamp();
        
        myLamp.TurnOn();
        myLamp.Toggle();
        myLamp.Toggle();
        myLamp.TurnOff();
        
    }
}