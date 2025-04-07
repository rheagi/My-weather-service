using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{

    public class MyCustomLinkedList
    {
        private Node head;
        public int Count { get; private set; }

        public void Add(int value)
        {
            var newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;

                while(current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }

            Count++;
        }

        public void Add(int index, int value)
        {
            if (index < 0 || index > Count)
                throw new IndexOutOfRangeException();

            var newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                if (index == 0)
                {
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {
                    var counter = 0;
                    var current = head;

                    while (counter != index - 1)
                    {
                        current = current.Next;
                        counter++;
                    }

                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
            }

            Count++;
        }

        public int Get(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();

            var counter = 0;
            var current = head;

            while (counter != index)
            {
                current = current.Next;
                counter++;
            }

            return current.Value;
        }

        public void Set(int index, int value)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();

            var newNode = new Node(value);

            if (index == 0)
            {
                newNode.Next = head.Next;
                head = newNode;
            }
            else
            {
                var counter = 0;
                var current = head;

                while (counter != index - 1)
                {
                    current = current.Next;
                    counter++;
                }
                newNode.Next = current.Next.Next;
                current.Next = newNode;
            }
        }

        public int this[int index]
        {
            get
            {
                return Get(index);
            }
            set
            {
                Set(index, value);
            }
        }
    }
}
