namespace c_sharp_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player codeMonkeyPlayer = new Player("Hideo Kojima");
            Player ironManPlayer = new Player("Tony Stark");
            codeMonkeyPlayer.SayHello();

            Console.WriteLine("");
        }

        class Player
        {
            public static string name = "-";
            public static void SayHello()
            {
                Console.WriteLine($"Hello {name}!");
            }
        }
    }
}
