namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();

            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            cylinder.Radius = radius;

            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            cylinder.Height = height;

            cylinder.Process();
            cylinder.Result();
        }

        class Cylinder
        {
            public double Radius { get; set; }

            public double Height { get; set; }

            public double BaseArea { get; set; }

            public double LateralArea { get; set; }

            public double TotalArea { get; set; }

            public double Volume { get; set; }

            public Cylinder()
            {
            }

            public Cylinder(double radius, double height)
            {
                Radius = radius;
                Height = height;
            }

            public Cylinder(double radius, double height, double baseArea, double lateralArea, double totalArea, double volume) : this(radius, height)
            {
                BaseArea = baseArea;
                LateralArea = lateralArea;
                TotalArea = totalArea;
                Volume = volume;
            }

            public void Process()
            {
                BaseArea = Radius * Radius * Math.PI;
                LateralArea = 2 * Math.PI * Radius * Height;
                TotalArea = 2 * Math.PI * Radius * (Height * Radius);
                Volume = Math.PI * Radius * Radius * Height;
            }

            public void Result()
            {
                Console.WriteLine("Base Area: " + BaseArea);
                Console.WriteLine("Lateral Area: " + LateralArea);
                Console.WriteLine("Total Area: " + TotalArea);
                Console.WriteLine("Volume: " + Volume);
            }
        }
    }
}