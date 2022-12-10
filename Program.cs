using Program.Domashka;

namespace Program
{
    class Program
    {
        private static IDomashka dz = new Dz9();

        static void Main(string[] args)
        {
            while(true) {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Введите номер задания\t0 - выход");
                    dz.execute(int.Parse(Console.ReadLine()!));
                    Console.ReadLine();
                } catch (FormatException e)
                {
                    Console.Error.WriteLine(e.Message);
                    continue;
                }
            }
        }
    }
}