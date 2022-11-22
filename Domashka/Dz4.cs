namespace Program.Domashka {
    class Dz4 : IDomashka {
        public void execute(int num)
        {
            switch (num)
            {
                case 25:
                    task25();
                    break;
                case 27:
                    task27();
                    break;
                case 29:
                    task29();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого задания нет");
                    break;
            }
        }

        private void task25()
        {
            int[] nums;
            while (true) {
                //Проверок нет
                string str = input("Введите через запятую 2 числа  (a - возводимое число, n - степень)");
                nums = str.Split(',').Select(int.Parse).ToArray();
                break;
            }
            Console.WriteLine(Math.Pow(nums[0], nums[1]));
        }

        private void task27()
        {
            int num = 0;
            while (true) {
                //Проверок нет
                string str = input("Введите число");
                num = int.Parse(str);
                break;
            }
            int sum = 0;
            while (num != 0) {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }

        private void task29()
        {
            int[] nums;
            while (true) {
                //Проверок нет
                string str = input("Введите через запятую 8 чисел");
                nums = str.Split(',').Select(int.Parse).ToArray();
                break;
            }
            Console.Write("[");
            foreach (int num in nums) {
                Console.Write(num + " ");
            }
            Console.Write("]\n");
        }

        private string input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()!;
        }
    }
}