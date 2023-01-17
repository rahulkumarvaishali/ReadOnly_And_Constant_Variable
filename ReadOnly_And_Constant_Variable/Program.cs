using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly_And_Constant_Variable
{
    public class ConstantVariable
    {
        public const int x = 100;
        public readonly int y;
        ConstantVariable(int xyz)
        {
            y = xyz;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(x);
            ConstantVariable objVar = new ConstantVariable(20);
            Console.WriteLine(objVar.y);
            Console.ReadKey();
        }

    }
}
