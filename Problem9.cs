using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    internal class Problem9
    {
        /*Write a C# Sharp program to find the maximum and minimum elements in an array.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 45
        element - 1 : 25
        element - 2 : 21
        Expected Output :
        Maximum element is : 45
        Minimum element is : 21*/


        public static void minmax()
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
            int min = array[0];
            int max = array[0];

            for (int i=1; i < size; i++)
            {
                
                if (array[i]<min)
                {
                    min= array[i];
                }
                if (array[i]>max)
                {
                    max= array[i];
                }
            }
            Console.WriteLine($"min number is {min}");
            Console.WriteLine($"max number is {max}");
        }

    }
}
