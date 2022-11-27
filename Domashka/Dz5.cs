namespace Program.Domashka {
    class Dz5 : IDomashka {
        private Random rand = new Random();

        public void execute(int num)
        {
            switch (num)
            {
                case 34:
                    task34();
                    break;
                case 35:
                    task35();
                    break;
                case 36:
                    task36();
                    break;
                case 38:
                    task38();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого задания нет");
                    break;
            }
        }

        private void task34()
        {
            int[] array = Enumerable.Range(0, 333).Select(n => rand.Next(100, 999)).ToArray(); //♂ Ah ♂
            int result = array.Where(n => n % 2 == 0).Count();
            Console.WriteLine(result);
        }

        private void task35()
        {
            int[] array = Enumerable.Range(0, 123).Select(n => rand.Next(0, 123)).ToArray();
            int firstIndex = array.Select((num, i) => new { num, i })
                .First(t => t.num >= 10 && t.num <= 99).i;
            int lastIndex = array.Select((num, i) => new { num, i })
                .Last(t => t.num >= 10 && t.num <= 99).i;
            Console.WriteLine(firstIndex);
            Console.WriteLine(lastIndex);
            Console.WriteLine(lastIndex - firstIndex + 1);            
        }

        private void task36()
        {
            int[] array = Enumerable.Range(0, 500).Select(n => rand.Next(100)).ToArray(); //♂ It's quite big ♂
            int result = array.Select((num, i) => new { num, i })
                .Where(t => t.i % 2 != 0)
                .Select(t => t.num)
                .Sum();
            Console.WriteLine(result);
        }

        private void task38()
        {
            double[] array = Enumerable.Range(0, 500).Select(n => rand.NextDouble()).ToArray();
            double min = array.Min();
            double max = array.Max();
            Console.WriteLine(max - min);
        }

        private string input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()!;
        }
    }
}