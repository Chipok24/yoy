class NullFigure : Figure, IFigure
{
    public NullFigure()
    : base(-1)
    { }
    public double Area()
    {
        return -1;
    }
}