namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: ");
            double number1 = Convert.ToInt32(Console.ReadLine());
            double number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели два числа: " + number1 + " и " + number2);
            Console.WriteLine("Какое действие выполнить?");
            Console.WriteLine("1. Сложение \n2. Вычитание \n3. Умножение \n4. Деление \n5. Нахождение остатка");
            int number3 = Convert.ToInt32(Console.ReadLine());
            string str1 = number1.ToString();
            string str2 = number2.ToString();

            if (number3 == 1)
            {
                Console.WriteLine("Результат: " + str1 + " + " + str2 + " = " + (number1 + number2));
            }
            else if (number3 == 2)
            {
                Console.WriteLine("Результат: " + str1 + " - " + str2 + " = " + (number1 - number2));
            }
            else if (number3 == 3)
            {
                Console.WriteLine("Результат: " + str1 + " * " + str2 + " = " + (number1 * number2));
            }

            else if (number3 == 4)
            {
                Console.WriteLine("Результат: " + str1 + " / " + str2 + " = " + (number1 / number2));
            }

            else if (number3 == 5)
            {
                Console.WriteLine("Результат: " + str1 + " % " + str2 + " = " + (number1 % number2));
            }

            else
            {
                Console.WriteLine("Такой команды не существует!");
            }


        }
    }
}