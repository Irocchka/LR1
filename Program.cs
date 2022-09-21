using System;

class kh1_3
{
    class Point
    {
        double x;
        double y;
        public double x_x//свойства
        {
            get => x;
        }
        public double y_y
        {
            get => y;
        }
        public Point(double p_x,double p_y)//конструктор
        {
            x = p_x;
            y = p_y;
        }
    }
    class Figure
    {
        Point[] pp;//массив
        public string Name { get; set; }//автосвойство имени
        // конструктор с параметрами для 3 точек
        public Figure(string str, Point A, Point B, Point C)
        {
            pp = new Point[3] { A, B, C };
            Name = str;
        }
        // конструктор с параметрами для 4 точек
        public Figure(string str, Point A, Point B, Point C,Point D)
        {
            pp = new Point[4] { A, B, C, D };
            Name = str;
        }
        // конструктор с параметрами для 5 точек
        public Figure(string str, Point A, Point B, Point C, Point D, Point E)
        {
            pp = new Point[5] { A, B, C, D, E };
            Name = str;
        }
        double LengthSide(Point A,Point B)
        {
            return Math.Sqrt(Math.Pow(B.x_x - A.x_x,2) + Math.Pow(B.y_y - A.y_y,2));
        }
        double PerimeterCalculator()
        {

            double sum = 0;
            for (int i = 1; i < pp.Length; i++)
            {
                sum += LengthSide(pp[i - 1], pp[i]);
            }
            sum += LengthSide(pp[0], pp[pp.Length - 1]);
            return sum;
        }
        // метод для печати имени и периметра
        public int print()
        {
            Console.WriteLine($"{Name} Perimeter is {PerimeterCalculator()}");
            return 0;
        }

    }


    static void Main(string[] args)
        {
        Figure p3 = new Figure("Three Points",
                                  new Point(1, 9),
                                  new Point(2, 0),
                                  new Point(7, 3));
        p3.print();

        Figure p4 = new Figure("Four Points",
                                  new Point(2, 0),
                                  new Point(7, 3),
                                  new Point(2, 10),
                                  new Point(4, 8));
        p4.print();

        Figure p5 = new Figure("Five Points",
                                  new Point(0, 5),
                                  new Point(7, 0),
                                  new Point(5, 35),
                                  new Point(10, 0),
                                  new Point(12, 6));
        p5.print();
    }
}