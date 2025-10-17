namespace c_sharp_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player codeMonkeyPlayer = new Player("Hideo Kojima");
            codeMonkeyPlayer.SayHello();
            Player ironManPlayer = new Player("Tony Stark");
            ironManPlayer.SayHello();
        }

        class Player
        {
            public string name = "-";
            public Player(string name)
            {
                this.name = name;
                Console.WriteLine($"Creating player {name}!");
            }

            public void SayHello()
            {
                Console.WriteLine($"Hello {name}!");
            }
        }
    }
}
