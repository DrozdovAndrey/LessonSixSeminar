



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
                // if (str != "" && str != null)
                // {
                //     //какой то код
                // }
                // // эта штука не пригодиться. один символ, он проверяет все, вне зависимотси тру уже или фолз 
                // if (str != "" & str != null)
                // {
                //     //какой то код
                // }

            }
            catch 
            {
                
                Console.WriteLine("Вы ввели неправильные данные");
                Main();
            }
            finally
            {
                // будет просто 
                Console.WriteLine("finally");
            }
        }
    }
}