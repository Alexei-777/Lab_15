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
            ArithProgression arith = new ArithProgression();
            Random rnd = new Random();
            arith.setStart(rnd.Next(1, 100));
            Console.WriteLine($"Следующее число арихметической прогресии = {arith.getNext()}");
            arith.reset();
            Console.WriteLine();
            GeomProgression geom = new GeomProgression();
            geom.setStart(rnd.Next(1, 100));
            Console.WriteLine($"Следующее число геометрической прогресии = {geom.getNext()}");
            geom.reset();
            Console.ReadKey();
            Console.WriteLine();
            Main(args);
        }
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
    public int x { get; set; }
    public int n { get; set; }
    public int a { get; set; }
    public int getNext()
    {
        Random rnd = new Random();
        n = rnd.Next(1, 10); // шаг
        Console.WriteLine($"Шаг равен = {n}");
        return x = x + n;
    }
    public void reset()
    {
        this.x = a;
        Console.WriteLine($"Число сброшено на начало арихметической прогресии = {x}");
    }

    public void setStart(int x)
    {
        this.x = x;
        this.a = x;
        Console.WriteLine($"Начальное число арихметической прогресии = {x}");
    }
}
class GeomProgression : ISeries
{
    public int x { get; set; }
    public int n { get; set; }
    public int a { get; set; }
    public int getNext()
    {
        Random rnd = new Random();
        n = rnd.Next(1, 10); // шаг
        Console.WriteLine($"Знаменатель равен = {n}");
        return x = x * n;
    }
    public void reset()
    {
        this.x = a;
        Console.WriteLine($"Число сброшено на начало геометрической прогресии = {x}");
    }

    public void setStart(int x)
    {
        this.x = x;
        this.a = x;
        Console.WriteLine($"Начальное число геометрической прогресии = {x}");
    }
}

