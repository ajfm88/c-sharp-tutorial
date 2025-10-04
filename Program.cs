namespace c_sharp_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[] { 56, 123, 12 };
            int[] numbersArray2 = new int[5];
            int[] numbersArray3 = new int[7] { 13, 43, 78, 29, 56, 123, 12 };
            Console.WriteLine(numbersArray.Length);
            Console.WriteLine(numbersArray[0]);
            Console.WriteLine(System.Array.IndexOf(numbersArray, 123));

            List<int> numbersList = new List<int>();
            numbersList.Add(12);
            numbersList.Add(0);
            numbersList.Add(89);
            Console.WriteLine(numbersList.Count);
            Console.WriteLine(numbersList[0]);
            Console.WriteLine(numbersList.Contains(89));
            Console.WriteLine(numbersList.Contains(37));
            Console.WriteLine(numbersList.IndexOf(37));
        }
    }
}
