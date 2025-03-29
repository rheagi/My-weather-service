namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyList List = new MyList();
            //List.Add(1);
            //List.Add(13);
            //List.Add(4);
            //List.Add(5);

            //int[] array = new int[] { 11, 5, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 };

            //List.Add(2, array);

            //Console.WriteLine(List[1]);

            MyList myList = new MyList();
            int[] array = { 5, 4, 3, 2, 1 };
            myList.Add(array);
            myList.Sort();
            Console.WriteLine("pupupu");

        }
    }
}