using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_420_413.Basics
{
    internal class Methods
    {
        static void MethodWithoutParams()
        {
            Console.WriteLine("Salut tout le monde");
        }

        static int MethodWithReturn(int a, int b) { 
            return a + b; 
        }

        static void MethodPassingParamByValue(int var)
        {
            var += 40;
        }

        static void MethodPassingParamByRefUsingRef(ref int var)
        {
            var += 40;
        }

        static void MethodPassingParamByRefUsingOut(out int var)
        {
            var = 30;
        }

        static void callMethods()
        {
            int var1 = 10, var2 = 10, var3;

            MethodWithoutParams();
            Console.WriteLine(MethodWithReturn(var1, var2));

            MethodPassingParamByValue(var1);
            Console.WriteLine(var1);
            MethodPassingParamByRefUsingRef(ref var2);
            Console.WriteLine(var2);
            MethodPassingParamByRefUsingOut(out var3);
            Console.WriteLine(var3);
        }
    }
}
