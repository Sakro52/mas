using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac14_1_
{
    class Program
    {/// <summary>
     /// доп метод
     /// </summary>
     /// <param name="args"></param>
     /// размер масиива
        static int GetSize()
        {
            Console.Write("Вод размера масива ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка");
            }

            return size;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        /// <returns>масив</returns>
        static int[] Input(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"array[{i}]=");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void OutPut(int[]array)
        {
             for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"\n array[{i}]={array[i]}");
            }
               
        }
        
        static void Main(string[] args)
        {
            int size = GetSize();
            int[] array = Input(size);
            OutPut(array);
            Console.ReadKey();

        }
    }
}
