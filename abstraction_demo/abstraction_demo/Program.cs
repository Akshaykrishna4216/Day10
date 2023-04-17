using System;

namespace abstraction_demo
{
    abstract class Figure
    {
        public int dimension;
        public abstract double Area();
        public abstract double Perimeter();
    }
    class Square : Figure
    {
        public override double Area()
        {
            return dimension * dimension;
        }
        public override double Perimeter()
        {
            return 4 * dimension;
        }
        class Circle : Figure
        {
            public override double Area()
            {
                return Math.PI * (dimension * dimension);
            }
            public override double Perimeter()
            {
                return 2 * Math.PI * dimension;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Figure f1 = new Square();
                f1.dimension = 10;
                Console.WriteLine(f1.Area());
                Console.WriteLine(f1.Perimeter());
                Figure f2 = new Circle();
                f2.dimension = 20;
                Console.WriteLine(f2.Area());
                Console.WriteLine(f2.Perimeter());
            }
        }


    }
}
