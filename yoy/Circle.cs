class Circle : Figure, IFigure
{
    private Circle(params List<double> sides)
    : base(sides) { }
    public static IFigure Create(params List<double> sides)
    {
        if (sides == null || sides[0] <= 0 || sides.Count > 1)
        {
            return new NullFigure();
        }
        return new Circle(sides);
    }
    public double Area()
    {
        return Math.Round(Math.PI * (sides[0] * sides[0]), 2);
    }
}