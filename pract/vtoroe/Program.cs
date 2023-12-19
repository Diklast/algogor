using System.Linq;

namespace tasks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пять числел: ");
            double[] many = { 1, 2, 3, 4, 5 };
            double number1 = Convert.ToInt32(Console.ReadLine());
            double number2 = Convert.ToInt32(Console.ReadLine());
            double number3 = Convert.ToInt32(Console.ReadLine());
            double number4 = Convert.ToInt32(Console.ReadLine());
            double number5 = Convert.ToInt32(Console.ReadLine());
            many[1] = number1;
            many[2] = number2;
            many[3] = number3;
            many[4] = number4;
            many[0] = number5;
            double qqq = many.Max();
            double ddd = many.Min();
            Console.WriteLine("Максимальное число: " + qqq);
            Console.WriteLine("Минимальное число: " + ddd);
        }
    }
}