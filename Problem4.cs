using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayQuestions
{
    public class Problem4
    {
                /*4. Write a C# Sharp program to copy the elements of one array into another array.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 15
        element - 1 : 10
        element - 2 : 12
        Expected Output:
        The elements stored in the first array are :
        15 10 12
        The elements copied into the second array are :
        15 10 12*/

        public static void copy() {
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

            for (int i =0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            Console.WriteLine("Printing duplicate array");
            for (int i = 0;i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}
