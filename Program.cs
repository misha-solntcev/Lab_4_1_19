using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  19. Задан одномерный массив А[1..17]. Определить 
    среднее значение нечетных положительных элементов массива. */

namespace Lab_4_1_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[17];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
            
            // Используем Linq
            var result = ((decimal)array.Where(i => i > 0 && i % 2 != 0).Average());
            Console.WriteLine(result);

            // Классический метод
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] % 2 != 0)
                {
                    sum += array[i];
                    count++;
                }
            }
            double sred = sum / count;
            Console.WriteLine(sred);

            Console.ReadKey();
        }
    }
}
