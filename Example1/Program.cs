



namespace Exception
{
    class TryCatch
    {
        static void Main()
        {
            // string? str = Console.ReadLine();
            // int num = Convert.ToInt32(str);

            try
            {
                Console.WriteLine("Введите число:");
                string? str = Console.ReadLine();
                int num = Convert.ToInt32(str);

            }
            catch 
            {
                
                Console.WriteLine("Вы ввели неправильные данные");
                Main();
            }
        }
    }
}