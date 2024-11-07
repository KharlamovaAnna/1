using System;

namespace Файлик
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1. Вывести на экран число e с точностью до десятых
            Console.WriteLine("Задание 1");
            
            double e = Math.E; // Получаем значение e через класс маф
            Console.WriteLine("Число e с точностью до десятых: {0:F1}", e); //F1 ограничивает число на 1 значение после запятой
            Console.ReadLine();
            
            // Задание 2. Вывести на экран числа 50 и 10 одно под другим
            Console.WriteLine("Задание 2");
            
            Console.WriteLine(50);
            Console.WriteLine(10);
            Console.ReadLine();


            // Задание 3. Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine("Задание 3");

            Console.WriteLine(0);
            Console.WriteLine(1);
            Console.WriteLine(4);
            Console.WriteLine(3);
            Console.ReadLine();


            // Задание 4. Пользователь вводит число, выведите на экран число, большее на 10
            Console.WriteLine("Задание 4");

            Console.WriteLine("Введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Данное число + 10 = {a + 10}");
            Console.ReadLine();

            // Задание 5. Дана сторона квадрата, найдите его периметр
            Console.WriteLine("Задание 5");

            Console.WriteLine("Введите сторону квадрата");
            double b = Convert.ToDouble(Console.ReadLine());
            b = 4 * b;
            if (b <= 0)
            {
                Console.WriteLine("Такой квадрат невозможен");
            }
            else
            {
                Console.WriteLine($"Периметр квадрата с данной стороной: {b}");
            }
            Console.ReadLine();


            // Задание 6. Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("Задание 6");

            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            double L = 2 * r * Math.PI;
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Длина окружности с данным радиусом: {0:F2}", L);  //ставим ограничения на количество знаков после запятой (2 знака)
            Console.WriteLine("Площадь круга: {0:F2}", S);
            Console.ReadLine();


            // Задание 7. Найти значение y=cos(x)
            Console.WriteLine("Задание 7");

            Console.WriteLine("Введите значение x в градусах для нахождения y=cosx");
            double xd = Convert.ToDouble(Console.ReadLine());   //считываем значение х в градусах
            double xr = xd * Math.PI / 180; //переводим в радианы  
            double y = Math.Cos(xr);
            Console.WriteLine("Если x = {0}, то y={1:F2}", xd, y);
            Console.ReadLine();


            // Задание 8. Даны основания и высота равнобедренной трапеции. Найти ее периметр
            Console.WriteLine("Задание 8");

            Console.WriteLine("Введите длину нижнего основания трапеции");
            double down = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину верхнего основания трапеции");
            double up = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту трапеции");
            double h = Convert.ToDouble(Console.ReadLine());
            double popit = Math.Sqrt(Math.Pow(h, 2) + Math.Pow((down - up) / 2, 2));   //теорема пифагора
            double prmt = down + up + 2 * popit;
            Console.WriteLine("Периметр данной трапеции: {0:F2}", prmt);
            Console.ReadLine();


            // Задание 9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки
            Console.WriteLine("Задание 9");

            Console.WriteLine("Введите стоимость 1кг конфет");
            double k = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Сколько кг конфет купили?");
            double ak = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стоимость 1кг печенья");
            double t = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Сколько кг печенья купили?");
            double at = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите стоимость 1кг яблок");
            double u = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сколько кг яблок купили?");
            double au = Convert.ToDouble(Console.ReadLine());

            double sum = k * ak + t * at + u * au;
            Console.WriteLine($"Сумма за всю покупку: {sum}");
            Console.ReadLine();


            // Задание 10. Мир, труд, май
            Console.WriteLine("Задание 10");

            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("\"{0,8}\"", "Труд");
            Console.WriteLine("\"{0,15}\"", "Май");
            Console.ReadLine();


            // Задание 13. Составить программу вывода на экран числа, вводимого с клавиатуры.
            Console.WriteLine("Задание 13");

            Console.WriteLine("Введите любое число");
            double chislo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {chislo}");
            Console.ReadLine();


            // Задание 14. Составить программу вывода на экран следующей информации
            Console.WriteLine("Задание 14");

            Console.WriteLine(2 + " кг");
            Console.WriteLine("13 17");
            Console.ReadLine();


            // Задание 17. найти среднее арифметическое/геометрическое двух чисел
            Console.WriteLine("Задание 17");

            Console.WriteLine("Введите первое число");
            int f1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int f2 = Convert.ToInt32(Console.ReadLine());
            int ff = (f1 + f2) / 2;  //находим среднее арифметическое
            double ff1 = f1 * f2;
            ff1 = Math.Sqrt(ff1);  //и среднее геометрическое тоже найдем
            Console.WriteLine("Срееднее арифмитическое этой пары чисел: {0:F2}", ff);
            Console.WriteLine("Срееднее геометрическое этой пары чисел: {0:F2}", ff1);  //возьмем два знака после запятой
            Console.ReadLine();


            //Задание 34.
            Console.WriteLine("Задание 34");

            Console.WriteLine("Как вас зовут?");
            string n = Console.ReadLine();
            Console.WriteLine(n);
            Console.WriteLine("Как вас зовут?");
            string w = Console.ReadLine();
            Console.WriteLine($"Нихао, {w}");
            Console.ReadLine();










        }




    }
}
