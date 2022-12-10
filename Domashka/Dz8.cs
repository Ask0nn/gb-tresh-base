namespace Program.Domashka
{
    class Dz8 : IDomashka
    {
        private Random rand = new Random();

        public void execute(int num)
        {
            switch (num)
            {
                case 54:
                    task54();
                    break;
                case 56:
                    task56();
                    break;
                case 58:
                    task58();
                    break;
                case 60:
                    task60();
                    break;
                case 62:
                    task62();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Такого задания нет");
                    break;
            }
        }

        private void task54()
        {
            var matrix = MatrixHelp.getRandomMatrix(4, 4);
            Console.WriteLine("Исходная матрица:");
            MatrixHelp.printMatrix(matrix);
            
            Console.WriteLine("Отсортированная матрица:");
            for(int i = 0; i < matrix.GetLength(0); i++) { // Multidimensional arrays aren't enumerable. очень смешно глупый C# 
                var row = MatrixHelp.getRow(matrix, i);
                row.OrderByDescending(s => s).ToList().ForEach(s => Console.Write(s + "\t"));
                Console.WriteLine();
            }
        }

        private void task56()
        {
            int lastIndex = 0, min = int.MaxValue;
            var matrix = MatrixHelp.getRandomMatrix(4, 5); // Если что в примере матрица 4 на 4 и это вообще не прямоугольная -_-
            Console.WriteLine("Исходная матрица:");
            MatrixHelp.printMatrix(matrix);

            for(int i = 0; i < matrix.GetLength(0); i++) {
                var row = MatrixHelp.getRow(matrix, i);
                var sum = row.Sum();
                if (sum < min) {
                    min = sum;
                    lastIndex = i;
                }
            }
            Console.WriteLine("Строка #" + (lastIndex + 1));
        }

        private void task58()
        {
            var matrix1 = MatrixHelp.getRandomMatrix(2, 2);
            Console.WriteLine("Матрица1:");
            MatrixHelp.printMatrix(matrix1);

            var matrix2 = MatrixHelp.getRandomMatrix(2, 2);
            Console.WriteLine("Матрица2:");
            MatrixHelp.printMatrix(matrix2);

            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1)) return;

            Console.WriteLine("Результат сложения a1 и a2");
            for (int i = 0; i < matrix1.GetLength(0); i++) {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    Console.Write((matrix1[i, j] + matrix2[i, j]) + "\t");
                Console.WriteLine();
            }
        }

        private void task60()
        {
            var arr = MultiDimArrays.getRandomArray(3);
            MultiDimArrays.printArr(arr);
        }

        private void task62()
        {
            var matrix = new int[4, 4];
            int n = matrix.GetLength(0);
            int count = n;
            int value = -n;            
            int sum = -1;
            int num = 1;
            do
            {
                value = -1 * value / n;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    matrix[sum / n, sum % n] = num++;
                }
                value *= n;
                count--;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    matrix[sum / n, sum % n] = num++;
                }
            } while (count > 0);
            
            MatrixHelp.printMatrix(matrix);
        }

        private string input(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()!;
        }
    }
}