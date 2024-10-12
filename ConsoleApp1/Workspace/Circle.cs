namespace ConsoleApp1.Exam
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}