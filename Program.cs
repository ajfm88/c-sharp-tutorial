using System.Text;

namespace CodeMonkey_CSharpCourse
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Stack = First In Last Out - Push elements in, and Pop elements out
            Stack<string> nameStack = new Stack<string>();

            nameStack.Push("Code Monkey");
            nameStack.Push("Iron Man");
            nameStack.Push("Spider-Man");

            Console.WriteLine(nameStack.Pop());

            // Queue = First In First Out - Equeue elements in, Dequeue elements out
            Queue<string> stringQueue = new Queue<string>();

            stringQueue.Enqueue("Code Monkey");
            stringQueue.Enqueue("Iron Man");
            stringQueue.Enqueue("Spider-Man");

            Console.WriteLine(stringQueue.Dequeue());
        }
    }
}
