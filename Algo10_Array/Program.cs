using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo10_Array
{
    class Program
    {
        //функция для ввода целого числа (если вводим не целое число то повторный ввод)
        static int InputInteger()
        {
            int num; //само число
            bool success; //признак успеха преобразования
            do
            {
                //возвращает успех или неуспех операции преобразовани а через out параметр возвращает результат преобразования
                success = int.TryParse(Console.ReadLine(), out num);
                if (success == false) //если не успех
                    Console.WriteLine("Неверный ввод. Повторите!");
            } 
            while (success == false); //пока пользователь не введет целое число

            return num; //возврат результата
        }

        static void Main(string[] args)
        {
            Console.WriteLine("_________Программа для ввода элементов массива неизвестой длины____________\n");

            const int SIZE = 20; //максимальный размер массива (константа)
            const int FINISH = 0; //признак окончания ввода

            int[] a = new int[SIZE]; //создание массива (выделение памяти под массив размера SIZE)
            int n = 0; //счетчик
            int t;

            do
            {
                Console.WriteLine("Введите элемент массива");
                t = InputInteger(); //вызов функции ввода целого числа
                if (t != FINISH) //если ввели не стоп число
                {
                    a[n] = t; //заносим элемент в массив по индексу n
                    n++; //увеличиаем счетчик
                }
            } 
            while (t != FINISH && n < SIZE); //пока не достигли максим размера массива или пока пользователь не ввел 0

            if (t == FINISH) //если вышли по стоп числу (ввели 0)
            {
                Console.WriteLine("Вы ввели стоп число. Размер массива = " + n);
            }
            else
            {
                Console.WriteLine("Массив полностью заполнен. Размер массива = " + n);
            }

            //вывод массива (перебор всех эл-тов и вывод по одному через пробел)
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
