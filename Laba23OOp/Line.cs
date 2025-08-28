namespace GeometryApp
{
    public class Line
    {
        protected double x1, y1, x2, y2;

        public Line()
        {
            x1 = y1 = x2 = y2 = 0;
        }

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
        }

        public Line(Line other)
        {
            x1 = other.x1; y1 = other.y1;
            x2 = other.x2; y2 = other.y2;
        }

        public double X1 => x1;
        public double Y1 => y1;
        public double X2 => x2;
        public double Y2 => y2;

        public double Length()
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
    }
}