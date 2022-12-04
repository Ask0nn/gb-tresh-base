namespace Program {
    class MatrixHelp {
        public static int[,] getRandomMatrix(int m, int n)
        {
            var matrix = new int[m, n];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = random.Next(-20, 20);
            return matrix;
        }

        public static int[,] userInputMatrix()
        {
            List<int> nm = input("Введите через пробел M N (MxN)").Split(' ').Select(int.Parse).ToList();
            var matrix = new int[nm[0], nm[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = int.Parse(input($"Введите a[{i}, {j}]"));
            return matrix;
        }

        public static void printMatrix(int[,] matrix)
        {
            Console.WriteLine($"a[{matrix.GetLength(0)} x {matrix.GetLength(1)}] = \n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void printElement(int[,] matrix, int i, int j)
        {
            if (i > matrix.GetLength(0) || j > matrix.GetLength(1))
            {
                Console.WriteLine("Такого числа в массиве нет");
                return;
            }
            Console.WriteLine($"a[{i}, {j}] = {matrix[i, j]}");
        }

        public static int[] getColumn(int[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

        public static int[] getRow(int[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
        }

        private static string input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()!;
        }
    }
}