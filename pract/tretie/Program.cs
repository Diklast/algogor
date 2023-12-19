namespace tasks3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double i = Math.Sqrt(x * 2 - 1);
            double num = x / i;
            Console.WriteLine(num);
            Console.WriteLine("Задача выполнена!");
        }
    }
}