using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Base Class object
            Console.WriteLine("Base Class");
            MyBaseClass objectA = new MyBaseClass();
            objectA.WriteNum();
            objectA.WriteStr();

            //DownCasting
            Console.WriteLine(" \n \nDown Casting");
            var objectB = (MyChildClass)objectA;
            //MyChildClass objectB = MyBaseClass as MyChildClass;
            objectB.WriteNum();
            objectB.WriteStr();

            //Derived Class object
            Console.WriteLine(" \n \nDerived Class");
            MyChildClass objectC = new MyChildClass();
            objectC.WriteNum();
            objectC.WriteStr();
        }
    }
}
