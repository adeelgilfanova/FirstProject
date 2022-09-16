using System;
namespace LabaTumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр.1.Приветствие");
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.Write($"Привет {name}!");
            Console.ReadKey();


            Console.WriteLine("Упр.2.Разделите два числа ");
            Console.Write("Введите число: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write(" Введите число: ");
            int r = int.Parse(Console.ReadLine());
            if (f == 0 || r == 0)
                Console.WriteLine("На ноль делить низяя!");
            else
                Console.WriteLine($"Деление: =" + (f / r));
            Console.ReadKey();

            Console.WriteLine("Дз.1.Алфавит");
            Console.Write("Введите букву: ");
            char letter = char.Parse(Console.ReadLine());
            int l = Convert.ToInt32(letter);
            int m = l + 1;
            char let = (char)m;
            Console.Write($"Следующая буква Алфавита:{let}");
            Console.ReadKey();

            Console.WriteLine("Дз.2.Решаем квадратное уравнение");
            int D;
            double Dd, i, q, x1, x2;// x1,x2-корни;i,q-вычисл;Dis-диск
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int c = int.Parse(Console.ReadLine());
            D = b * b - 4 * a * c;
            Dd = Math.Sqrt(D);
            i = -(b) + Dd;
            x1 = i % 2 * a;
            q = -(b) - Dd;
            x2 = q % (2 * a);
            if (D < 0) //проверка дискриминанта
                Console.WriteLine("Корней неть :( ");
            else if (D == 0)
                Console.WriteLine((-b) / (2 * a));
            else
                Console.WriteLine("Первый и второй корень: " + x1 + " " + x2);
            Console.ReadKey();
        }
    }
}





