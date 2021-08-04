using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        public int index;
        List<Student> listOfElement = new List<Student>();

        public void Push(Student element)
        {
            listOfElement.Add(element);
        }

        public void Pop()
        {
            index = listOfElement.Count() - 1;
            var ele = listOfElement[index];
            Console.WriteLine($"Last Student\nId: {ele.Id} Name:{ele.Name} \n");
            listOfElement.Remove(listOfElement[index]);
        }
    }
}
