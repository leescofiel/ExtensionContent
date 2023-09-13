using System;
using ClassLibrary1;

namespace PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reference variable
            ParentClass pc;

            //object of child
            pc = new ChildClass() { x = 10, y = 20 };

            //acess parent class

          if(pc is ChildClass)
            {
                ChildClass cc = (ChildClass)pc;
                Console.WriteLine(cc.x);
                Console.WriteLine(cc.y);
            }

            Console.ReadKey();
        }
    }
}
