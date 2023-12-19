namespace tasks4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество ступеней: ");
            int levels = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= levels; i++)
            {

                Console.Write(new string(' ', levels - i));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}

