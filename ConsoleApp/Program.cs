using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДЗ №1
            Console.WriteLine("ДЗ №1");
            Console.WriteLine("Введите сумму покупки:");
            double s = Convert.ToInt32(Console.ReadLine());
            if (s > 1000)
            {
                s = s - (s * 5 / 100);
                Console.WriteLine($"{s} со скидкой 5%");
            }
            else if (s > 500)
            {
                s = s - (s * 3 / 100);
                Console.WriteLine($"{s} со скидкой 3%");
            }
            else
            {
                Console.WriteLine("нет скидок");
            }

            // ДЗ №2
            Console.WriteLine("ДЗ №2");
            Console.WriteLine("Введите первое число:");
            int chislo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int chislo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int chislo3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четвертое число:");
            int chislo4 = Convert.ToInt32(Console.ReadLine());

            if ((chislo1 < chislo2) & (chislo2 < chislo3) & (chislo3 < chislo4))
            {
                Console.WriteLine("Числа расположены по возрастанию");
            }

            else if ((chislo1 == chislo2) & (chislo2 == chislo3) & (chislo3 == chislo4))
            {
                var res = chislo1 * chislo2 * chislo3 * chislo4;
                Console.WriteLine($"Сумма чисел = {res}"); 
            }
            else if ((chislo1 <= chislo2) & (chislo1 <= chislo3) & (chislo1 <= chislo4))
            {
                Console.WriteLine($"Наименьшее число:{chislo1}");
            }
            else if ((chislo2 <= chislo1) & (chislo2 <= chislo3) & (chislo2 <= chislo4))
            {
                Console.WriteLine($"Наименьшее число:{chislo2}");
            }
            else if ((chislo3 <= chislo1) & (chislo3 <= chislo2) & (chislo3 <= chislo4))
            {
                Console.WriteLine($"Наименьшее число:{chislo3}");
            }
            else if ((chislo4 <= chislo1) & (chislo4 <= chislo2) & (chislo4 <= chislo3))
            {
                Console.WriteLine($"Наименьшее число:{chislo4}");
            }

            // ДЗ №3
            Console.WriteLine("ДЗ №3");
            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c:");
            int c = Convert.ToInt32(Console.ReadLine());
           
            if (a <= b & b <= c)
            {
                Console.WriteLine($"{c}>={b}>={a}");
            }
            else if (a >= b & b >= c)
            {
                Console.WriteLine($"{a}>={b}>={c}");
            }
            else if (a >= b & b <= c & c >= a)
            {
                Console.WriteLine($"{c}>={a}>={b}");
            }
            else if (a >= b & b <= c & c <= a)
            {
                Console.WriteLine($"{a}>={c}>={b}");
            }
            else if (a <= b & b >= c & c <= a)
            {
                Console.WriteLine($"{b}>={a}>={c}");
            }
            else if (a <= b & b >= c & c >= a)
            {
                Console.WriteLine($"{b}>={c}>={a}");
            }
           

        }
    }
}
