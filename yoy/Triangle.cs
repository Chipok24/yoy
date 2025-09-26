class Triangle : Figure, IFigure
{
    private Triangle(params List<double> sides)
    :base(sides){}
    public static IFigure Create(params List<double> sides)
    {
        if (sides == null || sides.Count != 3)
        {
            return new NullFigure();
        }
        double a = sides[0];
        double b = sides[1];
        double c = sides[2];
        if ((a < 0 || b < 0 || c < 0)
        || (a + b <= c || a + c <= b || c + b <= a))
        {
            return new NullFigure();
        }
        return new Triangle(sides);
    }
    public double Area()
    {
        double p = (sides[0] + sides[1] + sides[2]) / 2.0;
        return Math.Round(Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2])), 2);
    }
}