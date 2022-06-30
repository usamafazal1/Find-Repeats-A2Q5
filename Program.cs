using System;

namespace A2Q5
{
    internal class Program
    {
        
        // method to find the repeat elements
        static void Repeating(int[] myArray, int size)
        {
            //declare two variables we use later
            int i, j;

            
            Console.Write("Repeated Elements are :");
            
            //nested for loop to compare elements of the array
            for (i = 0; i < size - 1; i++)
            {
                //each index is compared with every index that comes after it
                for (j = i + 1; j < size; j++)
                {
                    if (myArray[i] == myArray[j])
                        Console.Write(myArray[i] + " ");
                }
            }
        }
        
        // this main functino uses the above method to find the repeat numbers
        
        public static void Main()
        {
            //declare an array and declare a variable which stores array's size
            int[] myArray = { 7, 4, 2, 4, 5, 2, 3, 1, 7 };
            int myArray_size = myArray.Length;
            
            //input the parameters for the 'Repeated' function that we made above
            Repeating(myArray, myArray_size);
        }
    }
}
