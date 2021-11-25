using System;

namespace Zadanie_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Okrugnost.Dlina();
            Okrugnost.Ploshad();
            Okrugnost.Tochka();
            Console.ReadKey();
           
        }
    }
    static class Okrugnost
    {
        public static double r=1;
        public static int x0=2;
        public static int y0=6;
        public static int x1=7;
        public static int y1=3;
        public const double p = Math.PI;
        public static void Dlina()
        {
            double d = 2 * p * r;
            Console.WriteLine(" Длина окружности равна {0:f2}", Math.Round(d,2));
        }
        public static void Ploshad()
        {
            double  s = p * Math.Pow(r,2);
            Console.WriteLine("Площадь круга равна {0:f2}", Math.Round(s, 2));
        }
        public static void Tochka()
        {
            double l = Math.Sqrt(Math.Pow((x1 - x0), 2) + Math.Pow((y1 - y0), 2));
            if (l==r)
            {
              Console.WriteLine("Точка с координатами x1={0}, y1={1} находится на окружности", x1, y1);
            }
            else
            {
            Console.WriteLine("Точка с координатами x1={0}, y1={1} находится  вне окружности", x1, y1);
            }
        }
    }
}
