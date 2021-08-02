using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked
{
    class LList
    {
        public int Count;

        private Node _head;

        private Node _current;

        public LList()
        {
            this._head = new Node();
            this._current = _head;
        }

        public void AddFirst(object data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.Next = _head.Next;
            _head.Next = newNode;
            Count++;
        }

        public void AddLast(object d)
        {
            Node newNode = new Node();
            newNode.data = d;
            _current.Next = newNode;
            _current = newNode;
            Count++;
        }

        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                _head.Next = _head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("The List is Empty");
            }
        }

        public void PrintNodes()
        {
            Node currentNode = _head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;

                Console.Write($"{currentNode.data} =>");
            }
            Console.WriteLine("Null");
        }
    }
}
