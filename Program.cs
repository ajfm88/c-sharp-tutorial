using System.Text;

namespace CodeMonkey_CSharpCourse
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PrintPlayerName("Alejandro Foucault", "Lionel Messi");
        }
        // params is the keyword that we use when we want to add any number of parameters into a function.
        private static void PrintPlayerName(params string[] playerNameArray)
        {
            Console.WriteLine(playerNameArray.Length);
        }
    }
}
