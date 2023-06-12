using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    internal class Problem5
    {


        /* Write a C# Sharp program in to count duplicate elements in an array.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 5
        element - 1 : 1
        element - 2 : 1
        Expected Output :
        Total number of duplicate elements found in the array is : 1*/

        public static void findduplicate()
        {
            int count = 0;
            Console.WriteLine("Enter size of the array: - ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of array");
                int element = int.Parse(Console.ReadLine());
                array[i] = element;
            }

            for(int i=0;i< array.Length; i++)
            {
                for(int j=i+1; j< array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Total number of duplicate elements found in the array is : {count}");


        }
    }
}
