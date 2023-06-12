using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayQuestions
{
    internal class Problem3
            {/*
                Write a program in C# Sharp to find the sum of all array elements.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 2
        element - 1 : 5
        element - 2 : 8
        Expected Output :
        Sum of all elements stored in the array is : 15*/
        static int sum = 0;
        public static void sumofelement() {

            Console.WriteLine("Enter size of the array: - ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of array");
                int element = int.Parse(Console.ReadLine());
                array[i] = element;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                sum+=array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
