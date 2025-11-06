namespace c_sharp_tutorial
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Player codeMonkeyPlayer = new Player("Hideo Kojima");
            codeMonkeyPlayer.SayHello();
            Player ironManPlayer = new Player("Tony Stark");
            ironManPlayer.SayHello();

            Console.WriteLine("");
        }

        private class Player
        {
            private string name = "-";

            public Player (string name)
            {
                this.name = name;
                Console.WriteLine($"Creating player {name}!");

                SayHello();
            }
            public void SayHello()
            {
                Console.WriteLine($"Hello {name}!");
            }
        }
    }
}
