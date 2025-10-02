namespace c_sharp_tutorial
{
    internal class Program
    {
        static bool isPlayer;
        static void Main(string[] args)
        {
            int age = 35;
            isPlayer = true;
            SayHello("Alejandro", 23);
            Console.WriteLine(age);
        }

        static void SayHello(string playerName, int age)
        {
            age++;
            isPlayer = false;
            Console.WriteLine($"Hello {playerName}, you are {age} years old!");
            return age;
        }
    }
}
