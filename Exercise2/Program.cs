namespace Exercise2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.SetMe("Lion", 200);
            lion.Show();

            Console.WriteLine();

            Tiger tiger = new Tiger();
            tiger.SetMe("Tiger", 100);
            tiger.Show();
        }

        abstract class Animal
        {
            public abstract string Name { get; set; }

            public abstract int Weight { get; set; }

            public abstract void SetMe(string name, int weight);

            public abstract void Show();

            protected Animal()
            {
            }

            protected Animal(string name, int weight)
            {
                Name = name;
                Weight = weight;
            }
        }

        class Lion : Animal
        {
            public override string Name { get; set; }
            public override int Weight { get; set; }

            public Lion() { }

            public Lion(string name, int weight) : base(name, weight)
            {
                name = Name;
                weight = Weight;
            }

            

            public override void SetMe(string name, int weight)
            {
                Name = name;
                Weight = weight;
            }

            public override void Show()
            {
                Console.WriteLine("Name: " + Name + ", Weight: " + Weight);
            }
        }

        class Tiger : Animal
        {
            public override string Name { get; set; }
            public override int Weight { get; set; }

            public Tiger()
            {
            }

            public Tiger(string name, int weight)
            {
                Name = name;
                Weight = weight;
            }

            public override void SetMe(string name, int weight)
            {
                Name = name;
                Weight = weight;
            }

            public override void Show()
            {
                Console.WriteLine("Name: " + Name + ", Weight: " + Weight);
            }
        }
    }
}