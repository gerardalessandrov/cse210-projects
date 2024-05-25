public class Rectangle : Shape
{
    protected double _length;
    protected double _width;
    public Rectangle(string color, double length, double width)
    {
        _color = color;
        _length = length;
        _width = width;

    }
    public override double GetArea()
    {
        return _length * _width;
    }
}