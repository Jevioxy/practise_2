namespace Practise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                WriteChooseOperation();
            }







        }  
        static void WriteChooseOperation()
        {
            string operation;
            operation = null;
                Console.WriteLine("1. Игра Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Выйти из программы");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    GetRandom();
                    break;
                case "2":
                    Multiplicatiom();
                    break;
                case "3":
                    Delitel();
                    break;
                case "4":
                    
                     Environment.Exit(0);
                    break;









            }


        }
        static void GetRandom() // void ничего не возвращает, static int возвращает целое число; 
        {
            int operation;
            int value;
            Console.WriteLine("Угадай число от 0 до 100");

            Random rnd = new Random();

            value = rnd.Next(0, 100);

            do
            {




                operation = int.Parse(Console.ReadLine()); //я вывел данные из консоли и конвертировал в целое число,потому что консоль возвращает только текст


                if (operation < value)

                {
                    Console.WriteLine("Надо больше");

                }

                else if (operation > value)
                {
                    Console.WriteLine("Надо меньше");

                }


            }
            while (operation != value);
            Console.WriteLine("Ты угадал,молодец ! :3");
        }

        static void Multiplicatiom()
        {
            int[,] nums = new int[9, 9];

            for (int i = 0; i <= 8; i++)
            {
                for (int q = 0; q <= 8; q++)
                {
                    nums[0, q] = 1 * (q + 1);
                    nums[i, 0] = 1 * (i + 1);
                    nums[1, q] = 2 * (q + 1);
                    nums[i, 1] = 2 * (i + 1);
                    nums[2, q] = 3 * (q + 1);
                    nums[i, 2] = 3 * (i + 1);
                    nums[3, q] = 4 * (q + 1);
                    nums[i, 3] = 4 * (i + 1);
                    nums[4, q] = 5 * (q + 1);
                    nums[i, 4] = 5 * (i + 1);
                    nums[5, q] = 6 * (q + 1);
                    nums[i, 5] = 6 * (i + 1);
                    nums[6, q] = 7 * (q + 1);
                    nums[i, 6] = 7 * (i + 1);
                    nums[7, q] = 8 * (q + 1);
                    nums[i, 7] = 8 * (i + 1);
                    nums[8, 8] = 9 * (q + 1);


                }

            }


            for (int i = 0; i <= 8; i++)
            {
                for (int q = 0; q <= 8; q++)
                {
                    Console.Write(nums[i, q] + "\t");


                }
                Console.WriteLine();

            }


        }

        static  void Delitel()
        {
            Console.WriteLine("Введите число :");

            int число = int.Parse(Console.ReadLine());
            for (int i = 1; i <= число; i++)
            {
                if (число % i == 0)//если что можно разделить на i то цикл будет работать и остаток будет 0,%- как раз это и делает
                    Console.WriteLine("Число {0} делится без остатка на {1}", число, i);
            }
        }
    }
}
