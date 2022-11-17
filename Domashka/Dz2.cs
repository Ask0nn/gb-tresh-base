namespace Program.Domashka
{
    //Рубрика тупой тупее тупого открыта 
    class Dz2 : IDomashka
    {
        public void execute(int num)
        {
            switch (num)
            {
                case 10:
                    task10();
                    break;
                case 13:
                    task13();
                    break;
                case 15:
                    task15();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого задания нет");
                    break;
            }
        }

        private void task10()//ПРОСТО СУПЕР СЛОЖНОСТЬ УРОВЕНЬ SENIOR мммм.... вкусна
        {
            string str;
            while ((str = input("Введите трехзначное число ")).Length < 3) ;
            Console.WriteLine("Второе число - " + str[1]);
        }

        private void task13() //ВАУ КАК СЛОЖНА
        {
            string str;
            if ((str = input("Введите число ")).Length < 3) Console.WriteLine("Третьей цифры нет.");
            else Console.WriteLine("Третье число - " + str[2]);
        }

        private void task15()
        {
            int num;
            while (true)
            {
                string str = input("Введите день недели от 0 до 6 где \t0 - Воскресенье\t6 - Суббота");
                if (int.TryParse(str, out num))
                    if (str.Length > 1 && num < 7)
                        Console.WriteLine("Вы ввели больше 1 числа или ваше число больше 8");
                    else break;
            }
            Console.WriteLine(String.Format("Вы ввели {0} - это {1} и он {2} выходным днем.",
                num,
                Enum.GetName(typeof(DayOfWeek), num),
                num == 0 || num == 6 ? "является" : "не является")); /* 
                                                                    *   Вот тут скажут что-то типо надо было чтоб русское название было
                                                                    *   а также что надо было не 0 и 6 а чтоб прям от 1 до 7 пользователь вводил
                                                                    *   какая же хрень боже......
                                                                    */
        }

        private string input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()!;
        }
    }
}