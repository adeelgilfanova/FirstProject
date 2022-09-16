using System;
namespace Zadachi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задача.1.Выведите Е");
            Console.WriteLine(Math.Round(Math.E, 1));
            Console.ReadKey();

            Console.WriteLine("Задача.2");
            Console.WriteLine(50);
            Console.WriteLine(10);
            Console.ReadKey();


            Console.WriteLine("Задача.3");
            Console.Write("Введите число: ");
            int L = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int R = int.Parse(Console.ReadLine());
            Console.WriteLine($"{L}\n{M}\n{N}\n{R}");
            Console.ReadKey();

            Console.WriteLine("Задача.4");
            Console.Write("Введите число: ");
            int k = int.Parse(Console.ReadLine());
            int w = k + 10;
            Console.WriteLine(w);
            Console.ReadKey();

            Console.WriteLine("Задача.5");
            Console.Write("Введите число: ");
            int f = int.Parse(Console.ReadLine());
            int P = 4 * f;
            Console.WriteLine(P);
            Console.ReadKey();

            Console.WriteLine("Задача.6");
            Console.WriteLine("Введите радиус: ");
            int r = int.Parse(Console.ReadLine());
            string Pi = "П";
            int ocr = 2 * r;
            int S = r * r;
            Console.WriteLine($"{"Длина окружности:" + ocr + Pi}\n{"Площадь:" + S + Pi}");
            Console.ReadKey();

            Console.WriteLine("Задача.7");
            Console.WriteLine("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            if (x >= -1 && x <= 1)
                Console.WriteLine(Math.Cos(x));
            else
                Console.WriteLine($"Нельзя вычислить cos(x)");
            Console.ReadKey();

            Console.WriteLine("Задача.8");
            Console.WriteLine("Введите значение 1 основания: ");
            double osn1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение 2 основания: ");
            double osn2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение высоты: ");
            double vs = double.Parse(Console.ReadLine());
            double i = (osn1 - osn2) / 2; //находим часть основания
            double stor = Math.Sqrt(i * i + vs * vs);
            double Per = osn1 + osn2 + 2 * stor;
            Console.WriteLine($"Периметр равен:" + Per);
            Console.ReadKey();

            Console.WriteLine("Задача.9");
            Console.WriteLine("Введите стоимость 1 кг конфет");
            double konf = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг печенья");
            double pech = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1 кг яблок");
            double ibl = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите колличество кг конфет");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите колличество кг печенья");
            double Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите колличество кг яблок");
            double Z = double.Parse(Console.ReadLine());
            double summ = konf * X + pech * Y + ibl * Z;
            Console.WriteLine($"Сумма покупки : " + summ + "рублей");
            Console.ReadKey();

            Console.WriteLine("Задача.10");
            string mir = "Мир";
            string tr = "Труд";
            string mai = "Май";
            Console.WriteLine(mir + " " + tr + " " + mai);
            Console.WriteLine($"{mir} \n    {tr}  \n          {mai}");
            Console.ReadKey();

            Console.WriteLine("Задача.11");
            Console.WriteLine("Введите 1 переменную:");
            string userInput_1 = Console.ReadLine();
            Console.WriteLine("Введите 2 переменную:");
            string userInput_2 = Console.ReadLine();
            userInput_1 = userInput_1.Replace(',', '.');
            userInput_2 = userInput_2.Replace(',', '.');
            double userNumber_1;
            double userNumber_2;
            bool isVerifyNumber = true;
            if (!double.TryParse(userInput_1, out userNumber_1))
            {
                Console.WriteLine("Неправильный ввод");
                isVerifyNumber = false;
            }
            if (!double.TryParse(userInput_2, out userNumber_2))
            {
                Console.WriteLine("Неправильный ввод");
                isVerifyNumber = false;
            }
            if (isVerifyNumber == true)
            {
                double replace = userNumber_1;
                userNumber_1 = userNumber_2;
                userNumber_2 = replace;
                Console.WriteLine("Они успешно поменялись местами!");
                Console.WriteLine($"Переменная 1: {userNumber_1}");
                Console.WriteLine($"Переменная 2: {userNumber_2}");
            }

            Console.WriteLine("Задача.12");
            Console.WriteLine("Введите номер фигуры, которая вас интересует");
            Console.WriteLine("1: Треугольник");
            Console.WriteLine("2: Четырехугольник");
            Console.WriteLine("3: Круг");
            int userChoose;
            if (!int.TryParse(Console.ReadLine(), out userChoose))
            {
                Console.WriteLine("Вы ввели неправильно");
            }
            if (userChoose == 1)
            {
                bool isVerify = true;
                double storona_1;
                Console.WriteLine("Введите 1-ую сторону");
                if (!double.TryParse(Console.ReadLine(), out storona_1))
                {
                    Console.WriteLine("Вы ввели неправильно");
                    isVerify = false;
                }
                double storona_2;
                Console.WriteLine("Введите 2-ую сторону");
                if (!double.TryParse(Console.ReadLine(), out storona_2))
                {
                    Console.WriteLine("Вы ввели неправильно");
                    isVerify = false;
                }
                double storona_3;
                Console.WriteLine("Введите 3-ью сторону");
                if (!double.TryParse(Console.ReadLine(), out storona_3))
                {
                    Console.WriteLine("Вы ввели неправильно");
                    isVerify = false;
                }
                double h;
                Console.WriteLine("Введите высоту");
                if (!double.TryParse(Console.ReadLine(), out h))
                {
                    Console.WriteLine("Вы ввели неправильно");
                    isVerify = false;
                }
                if (isVerify == true)
                {
                    Console.WriteLine("Периметр: " + (storona_1 + storona_2 + storona_3));
                    Console.WriteLine("Площадь: " + (storona_1 * h / 2));
                }
            }
            else if (userChoose == 2)
            {
                bool isVerify = true;
                double storona_1;
                Console.WriteLine("Введите 1-ую сторону");
                if (!double.TryParse(Console.ReadLine(), out storona_1))
                {
                    Console.WriteLine("Вы ввели неправильно");
                    isVerify = false;
                }
                double storona_2;
                Console.WriteLine("Введите 2-ую сторону");
                if (!double.TryParse(Console.ReadLine(), out storona_2))
                {
                    Console.WriteLine("Вы ввели неправильно");
                    isVerify = false;
                }
                Console.WriteLine("Введите 3-ью сторону");
                double storona_3;
                if (!double.TryParse(Console.ReadLine(), out storona_3))
                {
                    Console.WriteLine("Вы ввели неправильно");
                    isVerify = false;
                }
                double storona_4;
                Console.WriteLine("Введите 4-ую сторону");
                if (!double.TryParse(Console.ReadLine(), out storona_4))
                {
                    Console.WriteLine("Вы ввели неправильно");
                    isVerify = false;
                }
                double h;
                Console.WriteLine("Введите высоту");
                if (!double.TryParse(Console.ReadLine(), out h))
                {
                    Console.WriteLine("Вы ввели неправильно");
                    isVerify = false;
                }
                if (isVerify == true)
                {
                    Console.WriteLine("Периметр:" + (storona_1 + storona_2 + storona_3 + storona_4));
                    Console.WriteLine("Площадь: " + (storona_1 * h));

                }
            }
            else if (userChoose == 3)
            {
                bool isVerify = true;
                double radius;
                Console.WriteLine("Введите радиус");
                if (!double.TryParse(Console.ReadLine(), out radius))
                {
                    Console.WriteLine("Вы ввели неправильно");
                    isVerify = false;
                }
                if (isVerify == true)
                {
                    Console.WriteLine("Периметр(длина) окружности: " + (2 * radius * (Math.PI)));
                    Console.WriteLine("Площадь окружности: " + ((Math.PI) * radius * radius));
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не то число");
            }

            Console.WriteLine("Задача.13");
            Console.WriteLine("Введите число: ");
            double chislo = double.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число: {chislo}");
            Console.ReadKey();

            Console.WriteLine("Задача.14");
            Console.WriteLine($"2 кг \n13 17");
            Console.ReadKey();

            Console.WriteLine("Задача.15");
            Random G = new Random();
            int number_1 = G.Next(0, 1000);
            int number_2 = G.Next(0, 1000);
            int number_3 = G.Next(0, 1000);
            int number_4 = G.Next(0, 1000);
            Console.WriteLine($"{number_1}\n{number_2}\n{number_3}\n{number_4}");
            Console.ReadKey();

            Console.WriteLine("Задача.16");
            Console.WriteLine("Найти корни квадратного уравнения");
            int D;
            double Dd, p, q, x1, x2;// x1,x2-корни;p,q-вычисл;Dis-диск
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int c = int.Parse(Console.ReadLine());
            D = b * b - 4 * a * c;
            Dd = Math.Sqrt(D);
            p = -(b) + Dd;
            x1 = p % 2 * a;
            q = -(b) - Dd;
            x2 = q % (2 * a);
            if (D < 0) //проверка дискриминанта
                Console.WriteLine("Корней неть :( ");
            else if (D == 0)
                Console.WriteLine((-b) / (2 * a));
            else
                Console.WriteLine("Первый и второй корень: " + x1 + " " + x2);
            Console.ReadKey();

            Console.WriteLine("Задача.17");
            Console.WriteLine("Введите 1 число: ");
            double chislo_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число: ");
            double chislo_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию,которая вас интересует");
            Console.WriteLine("1: Среднее арифметическое");
            Console.WriteLine("2: Среднее геометрическое");
            if (!int.TryParse(Console.ReadLine(), out userChoose))
            {
                Console.WriteLine("Вы ввели неправильно");
            }
            if (userChoose == 1)
            {
                Console.WriteLine("Среднее арифметическое: " + ((chislo_1 + chislo_2) / 2));
            }
            else if (userChoose == 2)
            {
                Console.WriteLine("Среднее геометрическое: " + Math.Sqrt(chislo_1 * chislo_2));
            }

            Console.WriteLine("Задача.18");
            Console.WriteLine("Найти расстояние между двумя точками");
            Console.WriteLine("Введите 1 координату по оси x:");
            double x_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 координату по оси x:");
            double x_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 1 координату по оси y:");
            double y_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 координату по оси y:");
            double y_2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(Math.Sqrt(x_1 - x_2) + Math.Sqrt(y_1 - y_2)));
            Console.ReadKey();

            Console.WriteLine("Задача.19");
            Console.WriteLine("Введите значение для переменной а:");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение для переменной в:");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение для переменной с:");
            double c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию,которая вас интересует");
            Console.WriteLine("1: b присвоить значение c, а присвоить значение b, с присвоить значение а");
            Console.WriteLine("2: b присвоить значение а, с присвоить значение b, а присвоить значение с");
            if (!int.TryParse(Console.ReadLine(), out userChoose))
            {
                Console.WriteLine("Вы ввели неправильно");
            }
            if (userChoose == 1)
            {
                double replace_1 = b1; //закидываем в другую переменную,чтобы не потерять
                b1 = c1;
                double replace_2 = a1;
                a1 = replace_1;
                c1 = replace_2;
                Console.WriteLine("Они успешно поменялись местами!");
                Console.WriteLine($"{a1} {b1} {c1}");
            }
            else if (userChoose == 2)
            {
                double replace_1 = b1;
                b1 = a1;
                double replace_2 = c1;
                c1 = replace_1;
                a1 = replace_2;
                Console.WriteLine("Они успешно поменялись местами!");
                Console.WriteLine($"{a1} {b1} {c1}");
            }

            Console.WriteLine("Задача.20");
            Console.WriteLine("Введите сколько секунд прошло с начала суток");
            int secund = int.Parse(Console.ReadLine());
            Console.WriteLine("Столько прошло часов:" + secund / (60 * 60));
            Console.WriteLine("Столько прошло полных минут с начала очер. часа:" + ((secund / 60) - ((secund / 60) / 60) * 60));
            Console.WriteLine("Столько прошло секунд с начала последней минуты:" + secund % 60);
            Console.ReadKey();

            Console.WriteLine("Задача.21");
            Console.WriteLine("Дан прямоугольник с размером 543:130");
            int storona_big = 543;
            int storona_little = 130;
            Console.WriteLine("Нужно найти сколько квадратов со стороной 130 мм может из него получиться");
            int chislo_kvadratov = storona_big / storona_little;
            Console.WriteLine("Вот столько: " + (chislo_kvadratov));
            Console.ReadKey();

            Console.WriteLine("Задача.22");
            Console.WriteLine("Дано трехзначное число: ");
            int chislo_treeznach = int.Parse(Console.ReadLine());
            int last_number = chislo_treeznach % 10;
            int chislo_treeznach_1 = chislo_treeznach / 10;
            Console.WriteLine($"Переделанное число: {last_number}{chislo_treeznach_1}");
            Console.ReadKey();

            Console.WriteLine("Задача.23");
            Console.WriteLine("Введите число больше 999: ");
            int tale = int.Parse(Console.ReadLine());
            Console.WriteLine($"a) число сотен в числе: {(tale / 100) % 10}");
            Console.WriteLine($"a) число тысяч в числе: {tale / 1000}");
            Console.ReadKey();

            Console.WriteLine("Задача.24");
            Console.WriteLine("Введите четырехзначное число: ");
            int chislo_fourznach = int.Parse(Console.ReadLine());
            int nmb_4 = chislo_fourznach % 10;
            int nmb_3 = (chislo_fourznach / 10) % 10;
            int nmb_2 = (chislo_fourznach / 100) % 10;
            int nmb_1 = chislo_fourznach / 1000;
            Console.WriteLine($"a)Число,где его цифры поменялись справа налево: {nmb_4}{nmb_3}{nmb_2}{nmb_1}");
            Console.WriteLine($"б)Число,где поменялись первая и вторая, четвертая и третья цифры: {nmb_2}{nmb_1}{nmb_4}{nmb_3}");
            Console.WriteLine($"в)Число,где поменялись вторая и третья цифры: {nmb_1}{nmb_3}{nmb_2}{nmb_4}");
            int nmb_12 = chislo_fourznach / 100;
            int nmb_34 = chislo_fourznach % 100;
            Console.WriteLine($"г)Число,где поменялись две первые цифры с двумя последними: {nmb_34}{nmb_12}");
            Console.ReadKey();

            Console.WriteLine("Задача.25");
            Console.WriteLine("Введите трехзначное число n");
            Console.WriteLine("Теперь вернем число x: ");
            int n = int.Parse(Console.ReadLine());
            if ((n / 10) % 10 == 0)
            {
                Console.WriteLine("Вводите заново, число десятков не должны равняться 0!");
            }
            else
            {
                int xx1 = (n % 100) * 10;//провели 2 последние операции
                int xx2 = n / 100;
                int xx = xx1 + xx2;
                Console.WriteLine($"Число х = {xx}");
            }

            Console.WriteLine("Задача.26");
            Console.WriteLine("Введите значения переменных hour,minut,secun");
            int hour = int.Parse(Console.ReadLine());
            int minut = int.Parse(Console.ReadLine());
            int secun = int.Parse(Console.ReadLine());
            int summa = (hour * 3600) + (minut * 60) + secun;
            int ugol = summa % 360;
            Console.WriteLine($"Угол равен: {ugol}");
            Console.ReadKey();

            Console.WriteLine("Задача.27");
            int valueOfAngleMinuteArrow = 2 * 2 * 6;
            int hourr = 0;
            int minute = 2 * 2;
            Console.WriteLine($"Значение угла: {valueOfAngleMinuteArrow}\nЗначение часа: {hourr}\nЗначение минуты: {minute}");

            Console.WriteLine("Задача.28");
            Console.WriteLine("Введите 1 число: ");
            double chislo11 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число: ");
            double chislo22 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 число: ");
            double chislo33 = double.Parse(Console.ReadLine());
            if (Math.Abs(chislo11) < Math.Abs(chislo22) & Math.Abs(chislo11) < Math.Abs(chislo33))
            {
                double little_chisllo = chislo11;
                Console.WriteLine($"Меньшее число по модулю: {little_chisllo}");
            }
            else if (Math.Abs(chislo22) < Math.Abs(chislo11) & Math.Abs(chislo22) < Math.Abs(chislo33))
            {
                double little_chisllo = chislo22;
                Console.WriteLine($"Меньшее число по модулю: {little_chisllo}");
            }
            else if (Math.Abs(chislo33) < Math.Abs(chislo11) & Math.Abs(chislo33) < Math.Abs(chislo22))
            {
                double little_chisllo = chislo33;
                Console.WriteLine($"Меньшее число по модулю: {little_chisllo}");
            }

            Console.WriteLine("Задача.29");
            Console.WriteLine("Введите 1 число: ");
            double ch1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 число: ");
            double ch2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 число: ");
            double ch3 = double.Parse(Console.ReadLine());
            if (ch1 < ch2 & ch1 < ch3)
            {
                double little_ch = ch1;
                if (ch2 > ch3)
                {
                    double big_ch = ch2;
                    Console.WriteLine($"Сумма меньшего и большего: {little_ch + big_ch}");
                }
                else if (ch3 > ch2)
                {
                    double big_ch = ch3;
                    Console.WriteLine($"Сумма меньшего и большего: {little_ch + big_ch}");
                }

            }
            else if (ch2 < ch1 & ch2 < ch3)
            {
                double little_ch = ch2;
                if (ch1 > ch3)
                {
                    double big_ch = ch1;
                    Console.WriteLine($"Сумма меньшего и большего: {little_ch + big_ch}");
                }
                else if (ch3 > ch1)
                {
                    double big_ch = ch3;
                    Console.WriteLine($"Сумма меньшего и большего: {little_ch + big_ch}");
                }
            }
            else if (ch3 < ch1 & ch3 < ch2)
            {
                double little_ch = ch3;
                if (ch2 > ch1)
                {
                    double big_ch = ch2;
                    Console.WriteLine($"Сумма меньшего и большего: {little_ch + big_ch}");
                }
                else if (ch1 > ch2)
                {
                    double big_ch = ch1;
                    Console.WriteLine($"Сумма меньшего и большего: {little_ch + big_ch}");
                }

            }

            Console.WriteLine("Задача.30");
            Console.WriteLine("Введите натуральное число");
            int nat_chislo = int.Parse(Console.ReadLine());
            int j = 0;
            int count = 0; //вводим счетчик
            while (j < nat_chislo)
            {
                j = j + 1;
                if (nat_chislo % j == 0)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine($"Количество делителей натурального числа = {count}");
            Console.ReadKey();

            Console.WriteLine("Задача.31");
            Console.WriteLine("Введите 1 коэффицент");
            var kof_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 коэффицент");
            var kof_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 3 коэффицент");
            var kof_3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 4 коэффицент");
            var kof_4 = double.Parse(Console.ReadLine());
            for (int I = -100; I <= 100; I++)
            {
                double resultat = (kof_1 * I * I * I + kof_2 * I * I + kof_3 * I + kof_4);
                if (resultat == 0)
                {
                    Console.WriteLine($"Корень равен: {I}");
                }
            }


            Console.WriteLine("Задача.32");
            Console.WriteLine("Введите 1 элемент последовательности:");
            double elem_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 элемент последовательности:");
            double elem_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента последовательности");
            double nomer_elem = double.Parse(Console.ReadLine());
            double element = elem_1 + ((elem_2 - elem_1) * (nomer_elem - 1));
            Console.WriteLine($"Элемент последовательности, номер которого {nomer_elem} равен {element}");
            Console.ReadKey();

            Console.WriteLine("Задача.33");
            Console.WriteLine("Введите кто вы:");
            Console.WriteLine("1: Студент");
            Console.WriteLine("2: Пенсионер");
            Console.WriteLine("3: И пенсионер и студент");
            int userChoose0;
            if (!int.TryParse(Console.ReadLine(), out userChoose0))
            {
                Console.WriteLine("Вы ввели неправильно");
            }
            if (userChoose0 == 1)
            {
                Console.WriteLine("Вы трудоустроены?:");
                Console.WriteLine("1: Да");
                Console.WriteLine("2: Нет");
                int userChoose1;
                if (!int.TryParse(Console.ReadLine(), out userChoose1))
                {
                    Console.WriteLine("Вы ввели неправильно");
                }
                if (userChoose1 == 1)
                {
                    Console.WriteLine("Вы не получаете кредит!");
                }
                else if (userChoose1 == 2)
                {
                    Console.WriteLine("Вы получаете кредит!");
                }
            }
            else if (userChoose == 2)
            {
                Console.WriteLine("Вы трудоустроены?:");
                Console.WriteLine("1: Да");
                Console.WriteLine("2: Нет");
                int userChoose2;
                if (!int.TryParse(Console.ReadLine(), out userChoose2))
                {
                    Console.WriteLine("Вы ввели неправильно");
                }
                if (userChoose2 == 1)
                {
                    Console.WriteLine("Вы не получаете кредит!");
                }
                else if (userChoose2 == 2)
                {
                    Console.WriteLine("Вы получаете кредит!");
                }
            }
            else if (userChoose == 3)
            {
                Console.WriteLine("Вы не получаете кредит!");
            }
            Console.ReadKey();

            Console.WriteLine("Задача.34");
            Console.WriteLine("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"a){name}");
            Console.WriteLine("Введите свое имя: ");
            string name_1 = Console.ReadLine();
            Console.WriteLine($"б) Здравствуй {name_1}!");
            Console.ReadKey();

            Console.WriteLine("Задача.35");
            Console.ReadLine();
            Console.WriteLine("Дневник: \n Как тебя зовут?");
            string name3 = Console.ReadLine();
            Console.WriteLine($"Дневник: \n Привет, {name3}");
            Console.ReadLine();
            Console.WriteLine("Дневник: \n Да");
            Console.ReadLine();
            Console.WriteLine("Дневник: \n Нет");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Дневник: \n Но могу показать...");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ReadKey();

            Console.WriteLine("Задача.36.a");
            int[] massOfCount = new int[12];
            Random rand = new Random();
            for (int i = 0; i < 12; i++)
            {
                massOfCount[i] = rand.Next(0, 9);
            }
            int sumOfChetNumber = 0;
            int sumOfNotChetNumber = 0;
            for (int i = 0; i < 12; i++)
            {
                if (i%2 == 1)
                {
                    sumOfChetNumber += massOfCount[i];
                }
                else
                {
                    sumOfNotChetNumber += massOfCount[i];
                }
            }
            sumOfChetNumber = sumOfChetNumber * 3;
            int sum = sumOfNotChetNumber + sumOfChetNumber;
            sum = sum % 10;
            sum = 10 - sum;
            Console.WriteLine("Контрольная сумма = " + sum);

            Console.WriteLine("Задача.36.b");
            int[] massOfCountForB = new int[12];
            for (int i = 0; i < 12; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out massOfCountForB[i]))
                {
                    Console.WriteLine("Вы ввели неправильно");
                }
            }
            sumOfChetNumber = 0;
            sumOfNotChetNumber = 0;
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 1)
                {
                    sumOfChetNumber += massOfCountForB[i];
                }
                else
                {
                    sumOfNotChetNumber += massOfCountForB[i];
                }
            }
            sumOfChetNumber = sumOfChetNumber * 3;
            sum = sumOfNotChetNumber + sumOfChetNumber;
            sum = sum % 10;
            sum = 10 - sum;
            Console.WriteLine("Контрольная сумма = " + sum);
        }
    }
}