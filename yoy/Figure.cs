abstract class Figure
{
    public List<double> sides { get; }
    public Figure(params List<double> sides)
    {
        this.sides = sides;
    }
}