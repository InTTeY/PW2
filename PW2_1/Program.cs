using System;
namespace PW2_1
{
    class SquareEquation
    {
        public double a;
        public double b;
        public double c;
        private double D;
        private double x1;
        private double x2;

        public void Calculations()
        {
            Discriminant();
            CalculateRoots();
        }
        private void Discriminant()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
        }
        private void CalculateRoots()
        {
            if (D < 0)
            {
                Console.WriteLine("Корней нет, так как дискриминант меньше 0");
            }
            else
            {
                if (D == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Так как дискриминант равен 0, то есть 1 корень - {0}", x);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("Имеется 2 корня:\nПервый корень - {0}\nВторой корень - {1}", x1, x2);
                }
            }
        }
    }
    class program
    {
        static void Main()
        {
            Console.Write("Введите данные для решения уравнения типа ax^2+bx+c=0\n");
            SquareEquation squareEquation = new SquareEquation();
            Console.Write("Введите значение: a = ");
            squareEquation.a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение: b = ");
            squareEquation.b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение: c = ");
            squareEquation.c = Convert.ToDouble(Console.ReadLine());
            squareEquation.Calculations();
            Console.ReadKey();
        }
    }
}