using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_420_413.POO.Interfaces
{
    interface ISampleInterface
    {
        void SampleMethod();
    }

    class ImplementationClass : ISampleInterface
    {
        // Explicit interface member implementation:
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("This method is now implemented!");
        }

    }
}
