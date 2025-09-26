class Program {
    static void Main()
    {
        var circle = Circle.Create(10.233);
        Console.WriteLine(circle.Area());

        var circle2 = Circle.Create(0);
        Console.WriteLine(circle2.Area());

        var circle3 = Circle.Create(null);
        Console.WriteLine(circle3.Area());

        var triangle = Triangle.Create(10, 10, 10);
        Console.WriteLine(triangle.Area());

        var triangle2 = Triangle.Create(10);
        Console.WriteLine(triangle2.Area());
        
        var triangle3 = Triangle.Create(null);
        Console.WriteLine(triangle3.Area());
    }
}