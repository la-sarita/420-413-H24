using CSharp_420_413.Basics;
using CSharp_420_413.Basics.Arrays;
using CSharp_420_413.Basics.Collections;
using CSharp_420_413.Basics.ControleInstructions;
using CSharp_420_413.Basics.Methods;
using CSharp_420_413.Basics.Variables_Types;
using CSharp_420_413.POO.Classes.ClassesIntro;
using System;

namespace CSharp_420_413
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###################################################");
            Console.WriteLine("================== Basics of C# ===================");
            Console.WriteLine("###################################################\n\n");

            CallControleInstruction();
            CallCollections();
            CallMethods();
            CallArrays();
            Console.WriteLine("\n###################################################");
            Console.WriteLine("====================== POO ========================");
            Console.WriteLine("###################################################\n\n");
            CallClasses();

        }

        static void CallClasses()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("============== Classes =================");
            Console.WriteLine("========================================\n");

            Car myCar = new Car("Mustang", 2020, "red", 200);
            Console.WriteLine(myCar.Model);     // Mustang

            // Use the object initializer to create the object car 
            // instead of using constructor, by specifying the fields, and assign the initials values
            // instead of using constructor, by specifying the fields, and assign the initials values
            var car = new Car
            {
                Model = "Corsa",
                Year = 2000
            };

            Person person1 = new Person(new DateTime(1989, 10, 5));
            person1.Name = "Liam";
            Console.WriteLine(person1.Name + ": " + person1.Birthday.ToShortDateString());

            Order order1 = new Order(1, 250.5, 5, 3, 1, new DateTime(2024, 1, 3));
            Order order2 = new Order(2, 315.95, 8, 5, 1, new DateTime(2024, 1, 26));
            Order order3 = new Order(3, 480.0, 2, 2);

            Customer customer = new Customer();
            customer.Name = "Trembley";
            customer.Orders.Add(order1);
            customer.Orders.Add(order2);
            customer.Orders.Add(order3);

            Console.WriteLine($"There are {customer.Orders.Count} orders made by {customer.Name}");

            StudentsGenertor studentsGenertor = new StudentsGenertor();
            studentsGenertor.DisplayStudentsList();

            var accessByIndexer = new AccessByIndexer("Sara");
            accessByIndexer.PrintCookie();
        }

        static void CallControleInstruction()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("======== Controle Instructions =========");
            Console.WriteLine("========================================\n");
            Conditional.InstructionIf();
            Conditional.InstructionIfElse();
            Conditional.InstructionIfElseElse();
            Conditional.ExpressionTernaire();
            Conditional.InstructionSwitch();
        }

        static void CallCollections()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("============ Collections ===============");
            Console.WriteLine("========================================\n");
            Lists.UseSimpleCollection();
            Lists.UseSimpleCollectionWithInitialization();
            Lists.UseSimpleCollectionAccessElements();
            Lists.UseSimpleCollectionUsingForLoop();
            Lists.UseSimpleCollectionCheckElementExists();
            Lists.UseSimpleCollectionWithAddRange();
            Lists.UseSimpleCollectionInsertElements();
            Lists.UseSimpleCollectionRemoveElements();
            Lists.UseSimpleCollectionOtherExample();

            Dictionaries.Create();
            Dictionaries.Access();
            Dictionaries.Update();
            Dictionaries.Delete();
        }

        static void CallMethods()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("=============== Methods ================");
            Console.WriteLine("========================================\n");
            MethodTypes.callMethods();
        }

        static void CallPrimitiveTypes()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("=========== Primitive Types ============");
            Console.WriteLine("========================================\n");
            PrimitiveTypes.SyntaxeOverview();
        }

        static void CallArrays()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("=============== Arrays =================");
            Console.WriteLine("========================================\n");
            SingleDimension.DeclarationAndInitialization();
            SingleDimension.AccessToElements();
            SingleDimension.ModifyElements();
            SingleDimension.PrintSize();
            SingleDimension.CreationOtherWays();
            SingleDimension.IterateWithForLoop();
            SingleDimension.IterateWithForeachLoop();
        }

        static void CallTypesConversion()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("========== Types Conversion ============");
            Console.WriteLine("========================================\n");
            TypesConversion.ConvertNumbers();
        }

    }
}
