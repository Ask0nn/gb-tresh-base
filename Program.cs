using Program.Domashka;

namespace Program
{
    class Program
    {
        private static IDomashka dz = new Dz2();

        static void Main(string[] args)
        {
            while(true) {
            Console.WriteLine("Введите номер задания\t0 - выход");
                            dz.execute(int.Parse(Console.ReadLine()!));    
            }
        }
    }
}