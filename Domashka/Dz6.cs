namespace Program.Domashka
{
    class Dz6 : IDomashka
    {
        private Random rand = new Random();

        public void execute(int num)
        {
            switch (num)
            {
                case 41:
                    task41();
                    break;
                case 43:
                    task43();
                    break;
                case 44:
                    task44();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого задания нет");
                    break;
            }
        }

        private void task41()
        {
            List<int> nums;
            while (true)
            {
                //Проверок нет
                string str = input("Введите через запятую числа");
                nums = str.Replace(" ", "").Split(',').Select(int.Parse).ToList();
                break;
            }

            Console.WriteLine(nums.Where(n => n > 0).Count());
        }

        private void task43() //Математика за что ты тут
        {
            List<int> nums;
            while (true)
            {
                //Проверок нет
                string str = input("Введите через пробел b1, k1, b2 и k2");
                nums = str.Split(' ').Select(int.Parse).ToList();
                break;
            }
            double b = (nums[0] - nums[2]);
            double k = ((nums[1] - nums[3]) * -1);
            double x = b / k;
            double y = nums[3] * x + nums[2];
            Console.WriteLine("(" + x + " ; " + y + ")");
        }

        private void task44()
        {
            string str = input("Введите что-то");
            Console.WriteLine("длина слова " + findLength(str));
        }

        private int findLength(string str, int count = 0)
        {
            if (String.IsNullOrEmpty(str)) return count;
            str = str.Remove(0, 1);
            return findLength(str, ++count);
        }

        private string input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()!;
        }
    }
}