using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 12);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("red", 3, 4);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("green", 5);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
    }
}