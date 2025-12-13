using System.Numerics;
using System.Text;

namespace CodeMonkey_CSharpCourse
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Reference types just store a reference to the value
            MyClass myClass = new MyClass();
            myClass.a = 7;
            MyClass mySecondClass = myClass;
            mySecondClass.a = 5;

            Console.WriteLine(myClass.a);

            // Value types hold the actual data
            int a = 7;
            int b = a;
            b = 5;

            Console.WriteLine(a);
        }

        private class MyClass
        {
            public int a;
        }
    }
}
