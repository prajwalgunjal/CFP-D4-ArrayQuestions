using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    internal class Problem11
    {
        public static void sortace()
        {
            Console.WriteLine("Enter size of the array: - ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of first array");
                int element = int.Parse(Console.ReadLine());
                array[i] = element;
            }
            for(int i=0;i < size;i++)
            {
                for(int j=i+1;j<size;j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            string sorted = string.Join(", ", array);
            Console.WriteLine(sorted);
        }
    }
}
