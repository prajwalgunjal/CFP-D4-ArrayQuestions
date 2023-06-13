using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestions
{
    internal class Problem13
    {
        /*. Write a C# Sharp program to insert an additional value into an array (sorted list).
        Test Data :
        Input the size of array : 3
        Input 3 elements in the array in ascending order:
        element - 0 : 5
        element - 1 : 7
        element - 2 : 9
        Input the value to be inserted : 8
        Expected Output :
        The exist array list is :
        5 7 9
        After Insert the list is :
        5 7 8 9*/
        public static int[] array; 
        public static void modifyarray()
        { 
            Console.WriteLine("Enter size of the array: - ");
            int size = int.Parse(Console.ReadLine());
            array= new int[size];
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
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            string sorted = string.Join(", ", array);
            Console.WriteLine("Printing original array"+sorted);
            addmore(array);
        }
        public static void addmore(int[] array)
        {
            Console.WriteLine("do you want to add more element in array ?? 1) yes 2) no");
            int input = int.Parse(Console.ReadLine());  
            if(input == 1)
            {
                Console.WriteLine("How many elemet you want to add :- ");
                int update = int.Parse(Console.ReadLine());
                int newsize = array.Length+update;
                int oldarraylenght = array.Length;
                Array.Resize(ref array, oldarraylenght + update);

                for (int i= oldarraylenght; i< array.Length; i++)
                {
                    Console.WriteLine("Enter element:- ");
                    int element = int.Parse(Console.ReadLine());
                    array[i] = element;
                }
               Array.Sort(array);
                string sorted = string.Join(", ", array);
                Console.WriteLine("Printing modified array: "+sorted);
            }
        }


    }
}
