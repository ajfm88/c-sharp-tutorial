using System.Text;

namespace CodeMonkey_CSharpCourse
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number = 0;
            while (number < 5)
            {
                number++;
            }
            Console.WriteLine(number);

            Console.WriteLine(RecursionIncrementer(0, 5, 1));
        }

        private static int RecursionIncrementer(int number, int numberMax, int incrementAmount)
        {   
            if (number < 5)
            {
                return RecursionIncrementer(number + incrementAmount, numberMax, incrementAmount);
            } else
            {
                return number;
            }
        }
    }
}
