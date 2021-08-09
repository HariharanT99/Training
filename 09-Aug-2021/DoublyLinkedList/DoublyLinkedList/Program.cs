using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLList obj = new DLList();
            DLList node1 = new DLList(2);
            DLList node3 = node1.InsertNext(4);
            DLList node2 = node3.InsertPrev(6);
            DLList node5 = node3.InsertNext(8);
            DLList node4 = node5.InsertPrev(9);
            obj.TraverseFront(node1);
            obj.TraverseBack(node5);
        }
    }
}
