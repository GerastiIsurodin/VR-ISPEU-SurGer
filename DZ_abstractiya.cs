namespace Shapes
{
    //абстрактный класс для фигур
    public abstract class Shape
    {
        //абстрактный метод для расчета площади или объема
        public abstract double CalculateAreaOrVolume();
    }

    //прямоугольник
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateAreaOrVolume()
        {
            return Width * Height;
        }
    }

    //окружность
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateAreaOrVolume()
        {
            return Math.PI * Radius * Radius;
        }
    }

    //цилиндр
    public class Cylinder : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double CalculateAreaOrVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("1. Прямоугольник");
                Console.WriteLine("2. Окружность");
                Console.WriteLine("3. Цилиндр");
                Console.WriteLine("0. Выход");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 0) break;

                Shape shape = null;

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите длину прямоугольника: ");
                        double rectWidth = double.Parse(Console.ReadLine());
                        Console.Write("Введите ширину прямоугольника: ");
                        double rectHeight = double.Parse(Console.ReadLine());
                        shape = new Rectangle(rectWidth, rectHeight);
                        break;

                    case 2:
                        Console.Write("Введите радиус окружности: ");
                        double circleRadius = double.Parse(Console.ReadLine());
                        shape = new Circle(circleRadius);
                        break;

                    case 3:
                        Console.Write("Введите радиус цилиндра: ");
                        double cylinderRadius = double.Parse(Console.ReadLine());
                        Console.Write("Введите высоту цилиндра: ");
                        double cylinderHeight = double.Parse(Console.ReadLine());
                        shape = new Cylinder(cylinderRadius, cylinderHeight);
                        break;

                    default:
                        Console.WriteLine("Неверный выбор");
                        continue;
                }

                Console.WriteLine($"Результат: {shape.CalculateAreaOrVolume():F2}");
                Console.WriteLine();
            }
        }
    }
}