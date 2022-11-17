namespace Program.Domashka {
    class Dz1 : IDomashka
    {
        public void execute(int num) {
            switch(num) {
                    case 2:
                        task2();
                        break;
                    case 4:
                        task4();
                        break;
                    case 6:
                        task6();
                        break;
                    case 8:
                        task8();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Такого задания нет");
                        break;
                }
        }

        private void task2()
        {
            Console.WriteLine("Введите 2 числа через пробел для сравнения");
            int[] array = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            int max = array[0];
            foreach (int el in array) max = max < el ? el : max;
            Console.WriteLine("Max is " + max);
        }

        private void task4()
        {
            Console.WriteLine("Введите 3 числа через пробел для сравнения");
            int[] array = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            int max = array[0];
            foreach (int el in array) max = max < el ? el : max;
            Console.WriteLine("Max is " + max);
        }

        private void task6()
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine()!);
            Console.WriteLine(String.Format("Число {0} - {1}", num, num % 2 == 0 ? "Четное" : "Нечетное"));
        }

        private void task8()
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine()!);
            List<int> resultArray = new List<int>();
            for (int i = 1; i <= num; i++) if (i % 2 == 0) resultArray.Add(i);
            Console.WriteLine("Результат:");
            resultArray.ForEach(Console.WriteLine);
        }
    }
}