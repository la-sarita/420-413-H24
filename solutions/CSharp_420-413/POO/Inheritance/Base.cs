using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_420_413.POO.Inheritance
{
    class Base<T> { }

    // Valid, non-constructed class with constructed base class
    class Extend1 : Base<int> { }

    // Error, type parameter used as base class
    // class Extend2<V> : V { }

    // Valid, type parameter used as type argument for base class
    class Extend3<V> : Base<V> { }
}
