using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinTest.Basic
{
    public class FooBar
    {
        public static string GetFooBar(int number)
        {
            if (number % 2 == 0 && number % 3 == 0)
                return "FooBar";
            if (number % 2 == 0)
                return "Foo"; 
            if (number % 3 == 0) 
                return "Bar";
            return number.ToString();
        }
    }
}
