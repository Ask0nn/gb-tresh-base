namespace Program.Domashka
{
    class Dz7 : IDomashka
    {
        private Random rand = new Random();

        public void execute(int num)
        {
            switch (num)
            {
                case 47:
                    task47();
                    break;
                case 50:
                    task50();
                    break;
                case 52:
                    task52();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого задания нет");
                    break;
            }
        }

        private void task47()
        {
            var matrix = MatrixHelp.getRandomMatrix(3, 4);
            MatrixHelp.printMatrix(matrix);
        }

        private void task50()
        {
            var matrix = MatrixHelp.getRandomMatrix(7, 12);
            MatrixHelp.printMatrix(matrix);
            Console.WriteLine();
            List<int> cords = input("Введите через пробел i j").Split(' ').Select(int.Parse).ToList();
            MatrixHelp.printElement(matrix, cords[0] - 1, cords[1] - 1);
        }

        private void task52()
        {
            var matrix = MatrixHelp.getRandomMatrix(7, 12);
            MatrixHelp.printMatrix(matrix);
            Console.WriteLine();
            List<double> result = new List<double>();
            for(int j = 0; j < matrix.GetLength(1); j++) {
                int[] col = MatrixHelp.getColumn(matrix, j);
                result.Add(col.Average());
            }
            Console.WriteLine("Среднее арифметическое столбцов: ");
            result.ForEach(Console.WriteLine);
        }

        private string input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()!;
        }
    }
}