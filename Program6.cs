using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    internal class Program6
    {
        /*6. Write a program in C# Sharp to print all unique elements in an array.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 1
        element - 1 : 5
        element - 2 : 1
        Expected Output :
        The unique elements found in the array are :
        5*/


        public static void duplicate()
        {
            int count = 0;
            Console.WriteLine("Enter size of the array: - ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int[] array2 = new int[array.Length];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of array");
                int element = int.Parse(Console.ReadLine());
                array[i] = element;
            }
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.WriteLine(array[i]);
                }
            }
            /*
                        for (int i = 0; i < array.Length; i++)
                        {
                            for (int j = i + 1; j < array.Length; j++)
                            {
                                if (array[i] == array[j])
                                {
                                    continue;
                                }
                                else
                                {
                                    array2[i] = array[i];
                                }
                            }
                        }
                        string result = string.Join(", ", array2.Take(array2.Length));
                        Console.WriteLine($"Total number of duplicate elements found in the array is : {result}");
            */
        }
    }
}
