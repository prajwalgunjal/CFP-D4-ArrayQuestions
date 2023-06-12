using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
namespace ArrayQuestions
{
    internal class Problem2
    {

   /*   Write a C# Sharp program to read n values in an array and display them in reverse order.
        Test Data :
        Input the number of elements to store in the array :3
        Input 3 number of elements in the array :
        element - 0 : 2
        element - 1 : 5
        element - 2 : 7
        Expected Output:
        The values store into the array are:
        2 5 7
        The values store into the array in reverse are :
        7 5 2*/

        public static void revArray()
        {
            Console.WriteLine("Enter size of the array: - ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of array");
                int element = int.Parse(Console.ReadLine());
                array[i] = element;
            }

            for(int i =size; i >0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
