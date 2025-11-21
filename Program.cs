using System.Text;
using CodeMonkey_CSharpCourse;

namespace CodeMonkey_CSharpCourse
{
    public class Program
    {
        public static string PlayerName {get; set;}
        private static string playerName;
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PlayerName = "Code Monkey";
            Console.WriteLine(PlayerName);
        }

            private static void SetPlayerName(string playerName)
        {
            Program.playerName = playerName;
        }
    }
}

public class Player
{
    public Player()
    {
        Console.WriteLine(Program.PlayerName);
    }
}