using System;

namespace ConsoleAppBrushUpInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BrushUp Inheritance!");

            //MyBaseClass baseClass = new MyBaseClass();

            //Console.WriteLine(baseClass.MyBaseClassMethod());

            MySpecializedClass mySpecializedClass = new MySpecializedClass();

            //Console.WriteLine(mySpecializedClass.MyBaseClassMethod());


            if(mySpecializedClass is MyBaseClass)
                Console.WriteLine((mySpecializedClass as MyBaseClass).MyBaseClassMethod()  );

            //if(mySpecializedClass is Myinterface)
            //    Console.WriteLine((mySpecializedClass as Myinterface).MyInterfaceMethod());



        }
    }
}
