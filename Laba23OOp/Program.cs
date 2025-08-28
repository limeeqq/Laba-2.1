namespace GeometryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Segment s = new Segment(0, 0, 3, 4);

            Console.WriteLine(s.ToString());
            Console.WriteLine($"Length = {s.Length():F2}");
            Console.WriteLine($"Angle with OX = {s.AngleOX():F2} degrees");
        }
    }
}