using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    internal class Problem10
    {
        /*Write a program in C# Sharp to separate odd and even integers into separate arrays.
        Test Data :
        Input the number of elements to be stored in the array :5
        Input 5 elements in the array :
        element - 0 : 25
        element - 1 : 47
        element - 2 : 42
        element - 3 : 56
        element - 4 : 32
        Expected Output:
        The Even elements are:
        42 56 32
        The Odd elements are :
        25 47*/

        public static void findOddEven()
        {
            Console.WriteLine("Enter size of the array: - ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int[] oddarray = new int[size];
            int[] evenNumberarray = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter {i + 1} element of first array");
                int element = int.Parse(Console.ReadLine());
                array[i] = element;
            }
            int oddcounter=0, evencounter=0;
            for(int i=0;i< size; i++)
            {
                if (array[i] % 2!= 0)
                {
                    oddarray[oddcounter]= array[i];
                    oddcounter++;
                }
                else
                {
                    evenNumberarray[evencounter]= array[i];
                    evencounter++;
                }
            }


            string oddarray1 = string.Join(",", oddarray);
            string evenarray = string.Join(",", evenNumberarray);
            Console.WriteLine($"printing odd number array{oddarray1}");
            Console.WriteLine($"printing even number array{evenarray}");
        }
    }
}
