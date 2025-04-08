namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            myList.Add(1);
            myList.Add(13);
            int[] array = { 5, 4, 3 };
            int[] array2 = { 12, 87, 9 };
            int[] array3 = { 33, 14 };

            myList.Add(array);
            myList.Add(2, array3);
            myList.Add(3, 75);
            myList.Add(5, array2);
            myList.Add(7);
            Console.WriteLine("Added elements");

            myList.Sort();
            Console.WriteLine("Sorted my list");
        }
    }
}