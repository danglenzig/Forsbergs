public class Animal
{
    
    public string name;
    public int age;

    public Animal()
    {
        name = "unknown";
        age = -1;
    }
    
    public Animal(string _name)
    {
        name = _name;
        age = -1;
    }

    public Animal(string _name, int _age)
    {
        name = _name;
        age = _age;
    }
    
    public virtual void Speak()
    {
        Console.WriteLine("Generic animal sound");
    }
}
public class Dog : Animal
{
    
    public string breed;
    
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

class Program
{
    static void Main()
    {
        Animal buddy = new Dog();
        buddy.Speak();
    }
}