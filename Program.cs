namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) {
            Console.WriteLine("Введите номер задания\t0 - выход");
                int num = int.Parse(Console.ReadLine());
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
                        return;
                    default:
                        Console.WriteLine("Такого задания нет");
                        break;
                }
            }
        }

        static void task2()
        {
            Console.WriteLine("Введите 2 числа через пробел для сравнения");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = array[0];
            foreach (int el in array) max = max < el ? el : max;
            Console.WriteLine("Max is " + max);
        }

        static void task4()
        {
            Console.WriteLine("Введите 3 числа через пробел для сравнения");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = array[0];
            foreach (int el in array) max = max < el ? el : max;
            Console.WriteLine("Max is " + max);
        }

        static void task6()
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("Число {0} - {1}", num, num % 2 == 0 ? "Четное" : "Нечетное"));
        }

        static void task8()
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            List<int> resultArray = new List<int>();
            for (int i = 1; i <= num; i++) if (i % 2 == 0) resultArray.Add(i);
            Console.WriteLine("Результат:");
            resultArray.ForEach(Console.WriteLine);
        }
    }
}