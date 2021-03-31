using Models;
using System;

namespace ConsoleApp4Encapsulation
{
    class Program
    {
        /// <summary>
        /// determina cuanto acceso y cuanta restriccion tendra mi clase
        /// ATTRIBUTE:  describe the status of the object
        ///             information of an object
        ///             1 object is diferent of other because of their attributes
        ///             has two parts: Identifier and value
        /// PROPERTY:   give set and get methods to a private field: both of them can have business logic
        ///             see timePeriod example
        ///             
        /// Expression Body definitions: single line statement, ver Person.cs
        /// autoimplemented properties: public type NameProperty { get; set; }
        /// 
        /// Access Modifiers: 
        /// 
        /// public: all objects can access, inherited, non inherited, outside of the assembly
        /// private: only the object have access
        /// internal: only the objects of the assembly can use
        /// protected: same object and inherited objects
        /// sealed: cant have childs
        /// 
        /// protected internal: protected or internal
        /// private protected: private and protected
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TimePeriod t = new TimePeriod
            {
                Hours = 24
            };

            Console.WriteLine($"time in hours: {t.Hours}");
        }
    }
}
