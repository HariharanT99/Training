using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class DLList
    {
        private int data;
        private DLList next;
        private DLList prev;

        public DLList()
        {
            data = 0;
            next = null;
            prev = null;
        }
        public DLList(int value)
        {
            data = value;
            next = null;
            prev = null;
        }
        public DLList InsertNext(int value)
        {
            DLList node = new DLList(value);

            if (this.next == null)
            {
                node.prev = this;
                node.next = null;
                this.next = node;
            }
            else
            {
                DLList temp = this.next;
                node.prev = this;
                node.next = temp;
                this.next = node;
                temp.prev = node;
            }
            return node;
        }
        public DLList InsertPrev(int value)
        {
            DLList node = new DLList(value);

            if (this.prev == null)
            {
                node.prev = null;
                node.next = this;
                this.prev = node;
            }
            else
            {
                DLList temp = this.prev;
                node.prev = temp;
                node.next = this;
                this.prev = node;
                temp.next = node;
            }
            return node;
        }

        public void TraverseFront(DLList node)
        {
            System.Console.WriteLine("\nTraversing Forward");

            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public void TraverseBack(DLList node)
        {
            System.Console.WriteLine("\nTraversing Backward");

            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.prev;
            }
        }
    }
}
