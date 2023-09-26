using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebotnya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[12];
            Rand(1, 10);

            int[] printed = new int[array.Length];
            int count = 0;

            Console.WriteLine("Повторяющиеся числа в массиве:");
            for (int i = 0; i < array.Length; i++)
            {
                bool isRepeated = false;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        isRepeated = true;
                        break;
                    }
                }
                if (isRepeated)
                {
                    bool isPrinted = false;
                    for (int k = 0; k < count; k++)
                    {
                        if (array[i] == printed[k])
                        {
                            isPrinted = true;
                            break;
                        }
                    }
                    if (!isPrinted)
                    {
                        Console.WriteLine(array[i]);
                        printed[count] = array[i];
                        count++;
                    }
                }
            }


            void Rand(int count1, int count2)
            {
                Random rand = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(count1, count2);
                    Console.Write(array[i] + " ");
                }
                Console.Write("\n");

            }

        }
    }
}
