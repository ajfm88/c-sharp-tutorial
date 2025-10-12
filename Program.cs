namespace c_sharp_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loops
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Loop " + i);
                i++;
            }

            // Do while loops
            i = 0;
            do
            {
                Console.WriteLine("Do While Loop " + i);
                i++;
            } while (i < 3);

            //  For loops
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("For Loop " + j);
            }

            string[] nameArray = new string[]
            {
                "Alejandro Foucault",
                "Cristiano Ronaldo",
                "Lionel Messi",
                "Roberto Carlos"
            };
            for (int k = 0; k < nameArray.Length; k++)
            {
                Console.WriteLine(nameArray[k]);
            }

            // For each loops
            foreach (string name in nameArray)
            {
                Console.WriteLine(name);
            }
        }
    }
}
