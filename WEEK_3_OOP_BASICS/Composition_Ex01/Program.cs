class Person
{
    public string name;
    public int age;
    public Address address;
}

class Address
{
    public string street;
    public string city;
    public string country;
}

class Book
{
    public string title;
    public string author;
    public int year;
    public Publisher publisher;

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Year: {year}, Publisher: {publisher.name} {publisher.country}");
    }
    
}
class Publisher
{
    public string name;
    public string country;
}

class Computer
{
    public string processor;
    public int ram;
    public int storage;
    
    public Monitor monitor;
    public Keyboard keyboard;
    public Mouse mouse;

    public void ShowInfo()
    {
        Console.WriteLine($"Processor: {processor}, RAM: {ram}, Storage: {storage}, monitor size: {monitor.size}, keyboard language: {keyboard.language}, mouse buttons: {mouse.buttons}");
    }
    
}

class Monitor
{
    public int size;
}

class Keyboard
{
    public string language;
}

class Mouse
{
    public int buttons;
}

class Program
{
    static void Main()
    {
        Person p1 = new Person();
        p1.name = "John";
        p1.age = 25;
        p1.address = new Address();
        p1.address.street = "Yngve Östbergs väg 28A";
        p1.address.city = "Simrishamn";
        p1.address.country = "Sweden";
        
        Console.WriteLine($"{p1.name} is {p1.age} years old, and lives at {p1.address.street} in {p1.address.city} {p1.address.country}.");
        
        Book myBook = new Book();
        myBook.title = "Deez Nuts";
        myBook.author = "Jonathan";
        myBook.year = 2021;
        myBook.publisher = new Publisher();
        myBook.publisher.name = "WuTang Press";
        myBook.publisher.country = "Staten Island";
        myBook.ShowInfo();
        
        Computer myComputer = new Computer();
        myComputer.processor = "Braino-tron 900 HellaHz";
        myComputer.ram = 9001;
        myComputer.storage = 123;
        myComputer.monitor = new Monitor();
        myComputer.keyboard = new Keyboard();
        myComputer.mouse = new Mouse();
        myComputer.monitor.size = 100;
        myComputer.keyboard.language = "English";
        myComputer.mouse.buttons = 1;
        myComputer.ShowInfo();

    }
}