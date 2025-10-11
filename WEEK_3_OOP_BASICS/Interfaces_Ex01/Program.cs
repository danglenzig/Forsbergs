interface ISwimable
{
    void Swim();
}

interface IDrawable
{
    void Draw();
}

class Fish:ISwimable
{
    public string fishName;
    public Fish(string _fishName) {fishName = _fishName;}
    public void Swim() => Console.WriteLine("What the hell is 'water'?");
}

class Circle : IDrawable
{
    public int radius;
    public Circle(int _radius) {radius = _radius;}
    public void Draw() => Console.WriteLine("I'm a Circle");
}

class Rectangle : IDrawable
{
    public int width;
    public int height;
    public Rectangle(int _width, int _height) {width = _width; height = _height;}
    public void Draw() => Console.WriteLine("I'm a Rectangle");
}

class Triangle : IDrawable
{
    public int width;
    public int height;
    public Triangle(int _width, int _height) {width = _width; height = _height;}
    public void Draw() => Console.WriteLine("I'm a Triangle");
}

class Program
{
    static void Main()
    {
        Fish f = new Fish("Bob");
        f.Swim();
        
        Triangle tr = new Triangle(10, 20);
        Circle c = new Circle(20);
        Rectangle r = new Rectangle(10, 20);
        tr.Draw();
        c.Draw();
        r.Draw();
    }
}