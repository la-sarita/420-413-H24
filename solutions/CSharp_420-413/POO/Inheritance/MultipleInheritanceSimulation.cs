using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_420_413.POO.Inheritance
{
    public interface IAnimal
    {
        void Deplacer();
    }

    public interface IHerbivore : IAnimal
    {
        //void Ruminer()
        //{
            // C# 8.0
        //}
    }

    public interface ICarnivore : IAnimal
    {
        //void Chasser()
        //{
            // C# 8.0
        //}
    }


    public interface IOmnivore : ICarnivore, IHerbivore
    {

    }

    public class Animal : IAnimal
    {
        public void Deplacer()
        {

        }
    }

    public class Carnivore : Animal, ICarnivore
    {

    }

    public class Herbivore : Animal, IHerbivore
    {

    }

    public class Omnivore : Animal, IOmnivore
    {

    }




    public interface IBase
    {
        void F(int i);
    }

    public interface ILeft : IBase
    {
        new void F(int i);
    }

    public interface IRight : IBase
    {
        void G();
    }

    public interface IDerived : ILeft, IRight { }

    public class A
    {
        public void Test(IDerived d)
        {
            d.F(1);           // Invokes ILeft.F
            ((IBase)d).F(1);  // Invokes IBase.F
            ((ILeft)d).F(1);  // Invokes ILeft.F
            ((IRight)d).F(1); // Invokes IBase.F
        }
    }

    public class B : IDerived
    {
        void ILeft.F(int i)
        {
            Console.WriteLine("ILeft.F");
        }

        void IBase.F(int i)
        {
            Console.WriteLine("IBase.F");
        }

        void IRight.G()
        {
            Console.WriteLine("IRight.F");
        }
    }

}
