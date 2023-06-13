using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    internal class problem7
    {
        /*Write a C# Sharp program to merge two arrays of the same size sorted in ascending order.
        Test Data :
        Input the number of elements to be stored in the first array :3
        Input 3 elements in the array :
        element - 0 : 1
        element - 1 : 2
        element - 2 : 3
        Input the number of elements to be stored in the second array :3
        Input 3 elements in the array:
        element - 0 : 1
        element - 1 : 2
        element - 2 : 3
        Expected Output:
        The merged array in ascending order is :
        1 1 2 2 3 3*/

        public static void merge()
        {
            Console.WriteLine("Enter size of the array: - ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int[] array2 = new int[array.Length];
            //int[] mergedArray = new int[array.Length+array2.Length];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of first array");
                int element = int.Parse(Console.ReadLine());
                array[i] = element;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of second array");
                int element = int.Parse(Console.ReadLine());
                array2[i] = element;
            }
            int length1 = array.Length;
            int length2 = array2.Length;

            int[] mergedArray = new int[length1 + length2];

            for (int i = 0; i < length1; i++)
            {
                mergedArray[i] = array[i];
            }
            
            for (int j = 0; j < length2; j++)
            {
                mergedArray[length1 + j] = array2[j];
                
            }
            for (int i = 0; i < mergedArray.Length; i++)
            {
                Console.WriteLine(mergedArray[i]);
            }
        }
    }
}
