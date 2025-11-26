using System.Text;

namespace CodeMonkey_CSharpCourse
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
    
            int[][] intArray = new int[5][];
            intArray[0] = new int[3];
            intArray[1] = new int[6];
            intArray[2] = new int[10];

            for (int i=0; i < intArray.GetLength(0); i++)
            {
                Console.WriteLine(intArray[i] == null);
                intArray[i] = new int[6];
            }

            intArray[0][2] = 5;

            /*
            int[,] intArray = new int[,] { { 1, 2, 3}, { 4, 5, 6} };

            intArray[0, 2] = 2;

            for (int i=0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.WriteLine(intArray[i, j]);
                }
            }
            */
        }
    }
}
