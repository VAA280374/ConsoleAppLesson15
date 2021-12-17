using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;

            Console.Write("Введите шаг арифметической прогрессии : ");
            temp = Convert.ToInt32(Console.ReadLine());
            ArithProgression arithProgression = new ArithProgression(temp);
            Console.Write("Введите начальный член арифметической прогрессии : ");
            temp = Convert.ToInt32(Console.ReadLine());
            arithProgression.setStart(temp);
            Console.Write("Введите число членов арифметической прогрессии : ");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Арифметическая прогрессия с начальным членом {0} :", arithProgression.X0);

            for (int i = 0; i < temp; i++)
            {
                Console.WriteLine(arithProgression.getNext());
            }
            Console.WriteLine();

            Console.Write("Введите коэффициент геометрической прогрессии : ");
            temp = Convert.ToInt32(Console.ReadLine());
            GeomProgression geomProgression = new GeomProgression(temp);
            Console.Write("Введите начальный член геометрической прогрессии : ");
            temp = Convert.ToInt32(Console.ReadLine());
            geomProgression.setStart(temp);
            Console.Write("Введите число членов геометрической прогрессии : ");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Арифметическая прогрессия с начальным членом {0} :", geomProgression.X0);

            for (int i = 0; i < temp; i++)
            {
                Console.WriteLine(geomProgression.getNext());
            }

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public int X0 { get; set; } = 0; // Начальное значение
        public int a { get; set; } // шаг орифметической прогрессии
        public int X { get; set; } = 0; // Текущее значение
        public ArithProgression(int a)
        { this.a = a; }
        public int getNext()
        {
            X += a;
            return X;
        }

        public void reset()
        {
            this.X = this.X0;
        }

        public void setStart(int x)
        {
            this.X0 = x;
            this.X = x;
        }

    }
    class GeomProgression : ISeries
    {
        public int X0 { get; set; } = 0; // Начальное значение
        public int a { get; set; } // коэффициент геометрической прогрессии
        public int X { get; set; } = 0; // Текущее значение
        public GeomProgression(int a)
        { this.a = a; }
        public int getNext()
        {
            X *= a;
            return X;
        }

        public void reset()
        {
            this.X = this.X0;
        }

        public void setStart(int x)
        {
            this.X0 = x;
            this.X = x;
        }
    }
}
