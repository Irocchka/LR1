using System;

class Lab_01_2
{
    class Rectangle
    {
        // поля класса
        double side1;
        double side2;

        // конструктор с параметрами
        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }

        public double Area { get { return AreaCalculator(); }  }

        // методы для подсчёта площади и периметра
        public double AreaCalculator() => side1 * side2;
        public double PerimeterCalculator() => side1 * 2 + side2 * 2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Side 1:");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Side 2:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle rec = new Rectangle(side1, side2);

        Console.WriteLine($"Perimeter: {rec.PerimeterCalculator()} \n" +
                          $"Area: {rec.AreaCalculator()}");
    }
}
