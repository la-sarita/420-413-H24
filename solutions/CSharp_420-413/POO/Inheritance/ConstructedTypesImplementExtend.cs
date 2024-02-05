using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_420_413.POO.Inheritance
{
    class C<U, V> { }
    interface I1<V> { }
    class D : C<string, int>, I1<string> { }
    class E<T> : C<int, T>, I1<T> { }
}
