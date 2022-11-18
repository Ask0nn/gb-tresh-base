using Program.Domashka;

namespace Program
{
    class Program
    {
        private static IDomashka dz = new Dz3();

        static void Main(string[] args)
        {
            while(true) {
                Console.Clear();
                Console.WriteLine("Введите номер задания\t0 - выход");
                            dz.execute(int.Parse(Console.ReadLine()!));
                Console.ReadLine();
            }
        }
    }
}