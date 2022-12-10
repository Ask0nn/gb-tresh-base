namespace Program.Domashka
{
    class Dz9 : IDomashka
    {
        private Random rand = new Random();

        public void execute(int num)
        {
            switch (num)
            {
                case 64:
                    task64();
                    break;
                case 66:
                    task66();
                    break;
                case 68:
                    task68();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого задания нет");
                    break;
            }
        }

        private void task64(int n = 10)
        {
            if (n == 0) return;
            Console.Write(n + "\t");
            task64(--n);
        }

        private void task66(int m = 1, int n = 15)
        {
            int sum = 0;
            for (int i = m; i <= n; sum += i++) ;
            Console.WriteLine("Sum = " + sum);
        }

        private void task68()
        {
            Console.WriteLine("A(n, m) = " + fuckMyBrain(3, 2));
        }

        private int fuckMyBrain(int n, int m) //Я 2 ПОГАННЫХ ЧАСА СИДЕЛ И НЕ ПОНИМАЛ ЭТОТ БРЕД -_- ПРОСТО ПЫЛАЕТ ШО КАПЕЦ
        {
            if (n == 0) return m + 1;
                if (n != 0 && m == 0) return fuckMyBrain(n - 1, 1);
                if (n > 0 && m > 0) return fuckMyBrain(n - 1, fuckMyBrain(n, m - 1));
                return fuckMyBrain(n,m);
        }

        private string input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()!;
        }
    }
}