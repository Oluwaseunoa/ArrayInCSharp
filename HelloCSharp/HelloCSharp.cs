using System;
namespace TutorialsPoint_ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //creation and initialization of the array

            int[] arr = new int[] { 7, 3, 5, 1, 9, 2 };

            // sorting the array in ascending order and displaying all the members of the array
            Array.Sort(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            //Taking and input and checking if it's part of the array

            Console.WriteLine("Enter the number to search: ");

            int num = int.Parse(Console.ReadLine());
           
            bool isFound = false;

            for(int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
                Console.WriteLine("Element found!");
            else
                Console.WriteLine("Uh no Element not found");

        }
    }
}