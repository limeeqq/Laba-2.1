
public class Segment : Line
{
    public Segment() : base() { }

    public Segment(double x1, double y1, double x2, double y2)
        : base(x1, y1, x2, y2) { }

    public Segment(Segment other) : base(other) { }

    public double AngleOX()
    {
        double dx = X2 - X1;
        double dy = Y2 - Y1;
        return Math.Atan2(dy, dx) * 180.0 / Math.PI;
    }

    public override string ToString()
    {
        return $"Segment: ({X1},{Y1}) -> ({X2},{Y2})";
    }
}

