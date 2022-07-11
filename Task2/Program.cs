// 2. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.




namespace Seminar6
{
    class Task2
    {
        static void Main(string[] args)
        {
            int[] array = new int[new Random().Next(5,11)];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            PrintArray(Copy(array));
            

        }
        static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0,21);
            }
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        
        }
        static int[] Copy(int[] array)
        {
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            return copy;
        } 
    }
}