namespace c_sharp_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello("Alejandro", 23);
                                    
        }

        static void SayHello (string playerName, int age)
        {
            Console.WriteLine($"Hello {playerName}, you are {age} years old!");
        }
    }
}
