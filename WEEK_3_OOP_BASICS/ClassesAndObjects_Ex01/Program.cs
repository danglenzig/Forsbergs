/*
class Car
{
    public string brand;
    public string color;
    public int year;
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.brand = "Volvo";
        myCar.color = "Red";
        myCar.year = 2020;
        
        
        Car yourCar = new Car();
        yourCar.brand = "Toyota";
        yourCar.color = "Blue";
        yourCar.year = 2018;
        
        Console.WriteLine($"My car is a {myCar.color} {myCar.brand} from {myCar.year}.");
        Console.WriteLine($"Your car is a {yourCar.color} {yourCar.brand} from {yourCar.year}.");
    }
}
*/

class Book
{
    public string title;
    public string author;
    public int pages;
}

class Program
{
    static void Main()
    {
        Book book1 = new Book();
        Book book2 = new Book();
        
        book1.title = "Deez Nutz";
        book1.author = "Michelle";
        book1.pages = 100;
        
        book2.title = "Deez Nutz: Da Sequel";
        book2.author = "Still Michelle";
        book2.pages = 200;
        
        Console.WriteLine($"First book is {book1.title}, by {book1.author}, at {book1.pages} pages.");
        Console.WriteLine($"Second book is {book2.title}, by {book2.author}, at {book2.pages} pages.");
    }
}