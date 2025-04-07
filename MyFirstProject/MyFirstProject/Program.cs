using MyLinkedList;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCustomLinkedList linkedList = new MyCustomLinkedList();
            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);
            linkedList.Add(0, 100);
            linkedList[1] = 7;
            Console.WriteLine(linkedList[1]);
        }

    }
}
