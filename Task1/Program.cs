// 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]




namespace Seminar6
{
    class Task1
    {
        static void Main(string[] args)
        {
            int[] array = new int[new Random().Next(5,11)];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            PrintArray(Reverse(array));

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
        static int[] Reverse(int[] array)
        {
            int[] reverse = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reverse[i] = array[array.Length -i -1];
            }
            return reverse;
        } 

    }
}