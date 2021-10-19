using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:

//метод void setStart(int x) -устанавливает начальное значение
//метод int getNext() -возвращает следующее число ряда
//метод void reset() -выполняет сброс к начальному значению
//Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
//В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
namespace Lab_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите начальное шаг / знаменатель");
            int n = Convert.ToInt32(Console.ReadLine());
            ArithProgression arith = new ArithProgression(x,n);
            Console.WriteLine($"Арихметическая прогрессия = {arith.getNext()}") ;
            GeomProgression geom = new GeomProgression(x, n);
            Console.WriteLine($"Геометрическая прогрессия = {geom.getNext()}");
            Main(args);
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
        public int n { get; set; }
        public int x { get; set; }
        public ArithProgression (int x, int n)
        {
            this.x = x;
            this.n = n;
        }
        public void setStart(int x)
        {
        }
        public int getNext()
        {
            return x + x * (n - 1);
        }
        public void reset()
        {
        }
    }
    class GeomProgression : ISeries
    {
        public int n { get; set; }
        public int x { get; set; }
        public GeomProgression(int x, int n)
        {
            this.x = x;
            this.n = n;
        }
        public void setStart(int x)
        {
        }
        public int getNext()
        {
            return (int)(x * (Math.Pow(x, n - 1)));
        }
        public void reset()
        {
        }
    }
}

