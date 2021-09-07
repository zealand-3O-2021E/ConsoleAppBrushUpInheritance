using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBrushUpInheritance
{
    public abstract class MyBaseClass
    {

        public abstract string MyAbstractMethod();

        private string MyProperty { get; set; }

        public MyBaseClass(string myProperty)
        {
            MyProperty = myProperty;
        }

        public MyBaseClass()
        {

        }

        public virtual string MyBaseClassMethod()
        {
            return "In the MyBaseClassMethod";
        }

        public override string ToString()
        {
            return MyBaseClassMethod();
        }
    }
}
