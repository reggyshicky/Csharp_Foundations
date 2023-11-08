using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Non_Primitive_datatype
{
    public class Calculator
    {
        public int a;
        public int c;
        public Calculator(int x, int y)
        {
            a = x;
            c = y;
        }
        public int Add()
        {
            return a + c;
        }
    }
}
