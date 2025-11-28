using System.Text;

namespace CodeMonkey_CSharpCourse
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(i + ", " + j);
                    // break;
                    // continue;
                }
            }
        }
    }
}
