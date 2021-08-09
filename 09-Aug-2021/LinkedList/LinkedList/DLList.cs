using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DLList
    {
        List<DLList> listValue = new List<DLList>() ;

        private int data;
        private DLList next;
        private DLList prev;

        public DLList()
        {
            this.data = 0;
            this.next = null;
            this.prev = null;
        }
        public DLList(int value)
        {
            data = value;
            next = null;
            prev = null;    
        }

        public void Enqueue(int value)

        {

            DLList node = new DLList(value);

            node.prev = this;
            node.next = null;
            this.next = node;
            listValue.Add(node);
            foreach (var item in listValue)
            {
                Console.Write($"{item.data} {item.next}");
            }
            Console.WriteLine("\n\n");
        }

        public void Dequeue()
        {
            if (listValue.Count > 0)
            {
                listValue.Remove(listValue[0]);

                foreach (var item in listValue)
                {
                    Console.Write($"{item.data} {item.next}");
                }
                Console.WriteLine("\n\n");
            }
            else
                Console.WriteLine("List doesn't contains any element");
        }
    }
}
