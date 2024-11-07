using System;
using System.Diagnostics.Eventing.Reader;

namespace дзшка1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная работа упр 2.1 Написать программу, которая спрашивает имя пользователя, затем приветствует его 
            
            Console.WriteLine("Лабораторная 1");
            Console.WriteLine("Как вас зовут?");
            string n = Console.ReadLine();  //считывает имя пользователя с клавиатуры и закладывает эти данные в переменную
            Console.WriteLine($"Бонжур, {n}");
            Console.ReadLine();


            //Упр 2.2 На вход подается 2 целых числа, на выходе - результат деления одного на другое

            Console.WriteLine("Лабораторная 2");
            Console.WriteLine("Введите целое делимое");
            int a = Convert.ToInt32(Console.ReadLine());  //считывает данные и конвертирует в инт для счета
            Console.WriteLine("Введите целый делитель");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b != 0)  //знаменатель не должен быть 0 
            {
                double d = (double)a / b; //переделываем а в число с плавающей точкой, чтобы ответ не округлялся как хочет
                Console.WriteLine($"Ответ: {d}");
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя, дурень");
            }
            Console.ReadLine();


            //Дз 2.1 Прочитать букву с экрана и вывести за ней в печать следующую букву а алфавитном порядке
            Console.WriteLine("Дзшка 1");
            Console.WriteLine("Введите букву");
            char bukva = Console.ReadLine()[0]; // считываем букву и суем ей индекс 0, она первая по счету
            if (char.IsLetter(bukva)) // смотрим, а буква ли наша буква вообще
            {
                char bukva2;
                if (bukva == 'z')
                {
                    Console.WriteLine("Алфавит закончился");
                }
                else if (bukva == 'Z')
                {
                    Console.WriteLine("Алфавит закончился");
                }
                else if (bukva == 'Я')
                {
                    Console.WriteLine("Алфавит закончился");
                }
                else if (bukva == 'я')
                {
                    Console.WriteLine("Алфавит закончился");
                }
                else
                {
                    bukva2 = (char)(bukva + 1); //получили номер следующей буквы и вернули ей тип чар
                    Console.WriteLine(bukva2);
                } 

            }
            else  // если буква все таки не буква
            {
                Console.WriteLine("Введите БУКВУ");
            }
            Console.ReadLine();
        }  
        
     }
}
