using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBrushUpInheritance
{
    public class MySpecializedClass : MyBaseClass , Myinterface
    {
        private string MySpecializedProperty { get; set; }

        public MySpecializedClass(string myProperty, string myspecializedproperty)
            :base (myProperty)
        {
            MySpecializedProperty = myspecializedproperty;
            //MyProperty = myProperty;
        }

        public MySpecializedClass()
        {

        }

        public override string MyBaseClassMethod()
        {
            return "In MySpecialized class";
        }

        public override string MyAbstractMethod()
        {
            return "in MyAbstractMethod";
        }

        public string MySpeczializedMethod()
        {
            return "in MySpecizializedMethod";
        }

        public string MyInterfaceMethod()
        {
            return "in MyInterfaceMethod";
        }
    }
}
