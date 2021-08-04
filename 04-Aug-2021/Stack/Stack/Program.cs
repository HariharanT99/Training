using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { Id = 1, Name = "Hari" };
            Student student2 = new Student() { Id = 2, Name = "Ram" };
            Student student3 = new Student() { Id = 3, Name = "Sonu" };
            Student student4 = new Student() { Id = 4, Name = "Raju" };

            Stack stackObj = new Stack();

            stackObj.Push(student1);
            stackObj.Push(student2);
            stackObj.Push(student3);
            stackObj.Push(student4);

            stackObj.Pop();
            stackObj.Pop();
        }
    }
}
