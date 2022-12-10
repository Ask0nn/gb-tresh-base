namespace Program {
    class MultiDimArrays {

        public static int[, ,] getRandomArray(int x, int y, int z) {
            List<int> nums = new List<int>();
            int num;
            var arr = new int[x, y, z];
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    for (int l = 0; l < arr.GetLength(2); l++)
                        while (true) {
                            if (nums.Contains((num = random.Next(10, 99)))) continue;
                            else {
                                arr[i, j, l] = num;
                                nums.Add(num);
                                break;
                            }
                        }
            return arr;
        }

        public static int[, ,] getRandomArray(int n) {
            return getRandomArray(n, n, n);
        }

        public static void printArr(int[, ,] arr) {
            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    for (int l = 0; l < arr.GetLength(2); l++) {
                        Console.Write($"{arr[i, j, l]}({i}, {j}, {l})\t");
                    }                    
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}