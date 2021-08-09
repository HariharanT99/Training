using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLList listObj = new DLList();
            while(true)
            {
                Console.WriteLine("Enter '1' for add item, '2' for remove item, '3' for exit");
                var opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Enter the element to add [NOTE: element cotains numbers only]");
                        var item = Convert.ToInt32(Console.ReadLine());
                        listObj.Enqueue(item);
                        break;
                    case 2:
                        listObj.Dequeue();
                        break;
                    default:
                        Console.WriteLine("Enter the valid input");
                        break;
                }
                if(opt == 3)
                {
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
