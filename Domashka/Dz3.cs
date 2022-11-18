namespace Program.Domashka
{
    class Dz3 : IDomashka
    {
        public void execute(int num)
        {
            switch (num)
            {
                case 19:
                    task19();
                    break;
                case 21:
                    task21();
                    break;
                case 23:
                    task23();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого задания нет");
                    break;
            }
        }

        private void task19()
        {
            string str;
            while ((str = input("Введите число длиной в 5 чисел")).Length != 5) Console.WriteLine("Больше или меньше 5 символов");
            int strLength = str.Length;
            for (int i = 0; i < strLength; i++)
            {
                if (!str[i].Equals(str[strLength - 1 - i]))
                {
                    Console.WriteLine(str + " - Не палиндром");
                    return;
                }
                if (i == strLength - 1 - i || i >= strLength - 1 - i) break;
            }
            Console.WriteLine(str + " - Палиндром");
        }

        private void task21()
        {
            int[] coords;
            while (true) {
                string str = input("Введите через запятую 6 чисел  (x1,y1,z1,x2,y2,z2)");
                //Короче тут типо проверки ввода (супер лень их делать)
                coords = str.Split(',').Select(int.Parse).ToArray();
                //Тут типо тоже проверки бла бла бла....
                break;
            }
            double result = Math.Sqrt(Math.Pow((coords[3] - coords[0]), 2) + Math.Pow((coords[4] - coords[1]), 2) + Math.Pow((coords[5] - coords[2]), 2));
            result = Math.Round(result, 2);
            Console.WriteLine("Расстояние между точками - " + result);
        }

        private void task23()
        {
            int num;
            while (true)
            {
                string str = input("Введите число ");
                if (int.TryParse(str, out num))
                    if (num < 0)
                        Console.WriteLine("Число меньше нуля");
                    else break;
            }
            Console.Write(" -> ");
            for (int i = 1; i <= num; Console.Write("\t" + Math.Pow(i++, 3)));
        }

        private string input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()!;
        }
    }
}