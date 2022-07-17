using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home6
{
    class Program
    {
        static void Main(string[] args)
        {/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            0, 7, 8, -2, -2-> 2
            1, -7, 567, 89, 223-> 3*/
            int[] Create_Array(int[] arr)
            {
                for(int i=0;i<arr.Length;)
                {
                    int j = i;
                    Console.Write("введите " + ++j + " число:");
                   bool result= int.TryParse(Console.ReadLine(),out arr[i]);
                    if (result)
                        i++;
                    

                }
                return arr;
            }
            double Cross(double[] vs)
            {
                double Res;
                Res = vs[1] - vs[3];
                Res /= vs[0] - vs[2];
                return -Res;
            }
            double Cross2(double Y,double[] vs)
            {
                Y = vs[2] * Y + vs[3];
                return Y;
            }

           /* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
            значения b1, k1, b2 и k2 задаются пользователем.
            b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)*/
            int M,count=0;
            int[] array= { };
            Console.WriteLine("задача 1. Пользователь вводит с клавиатуры M чисел. " +
                "Посчитайте, сколько чисел больше 0 ввёл пользователь.");
            Console.Write("введите количество чисел: ");
          ret:
            try
            {
                M = Convert.ToInt32(Console.ReadLine());
                array = new int[M];
            }
            catch
            {
                Console.WriteLine("не верный ввод, попробуте снова.");
                goto ret;
            }
                array=Create_Array(array);
            for(int i=0;i<array.Length;i++)
            {
                if (array[i] > 0)
                    count++;

            }
            Console.WriteLine("вы ввели "+count+" чисел больше 0");
            Console.ReadKey();
            Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, " +
                "заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;" +
                " значения b1, k1, b2 и k2 задаются пользователем.");

            double[] arrayDub = new double[4];
            Console.WriteLine("разделитель дробной части при вводе ',' ");
            Console.Write("введите значение k1: ");
            arrayDub[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите значение b1: ");
            arrayDub[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите значение k2: ");
            arrayDub[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите значение b2: ");
            arrayDub[3] = Convert.ToDouble(Console.ReadLine());
            if (arrayDub[0] == arrayDub[2] & arrayDub[1] == arrayDub[3])
                Console.WriteLine("прямые совпадают");
            else if (arrayDub[0] == arrayDub[2])
                Console.WriteLine("прямые парралельны");
            else
            {
               Console.WriteLine( Cross(arrayDub)+" : "+Cross2(Cross(arrayDub),arrayDub));
            }
                Console.ReadKey();
        }
    }
    }

