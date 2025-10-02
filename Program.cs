namespace c_sharp_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 35;

            SayHello("Alejandro", 23);

            // my comment
            /* my 
            multiline
            comment*/
        }

        static void SayHello(string playerName, int age)
        {
            Console.WriteLine($"Hello {playerName}, you are {age} years old!");
        }
    }
}
