using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    internal class Problem12
    {
        /* Write a C# Sharp program to sort array elements in descending order.
        Test Data :
        Input the size of array : 3
        Input 3 elements in the array :
        element - 0 : 5
        element - 1 : 9
        element - 2 : 1
        Expected Output :
        Elements of the array in sorted descending order:
        9 5 1*/

        public static void sortdece()
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
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] < array[j])
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
