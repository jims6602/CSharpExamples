using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using program.ExtensionMethods;

namespace program
{

    class Program
    {
        delegate void Operaion(int num);
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }
        public static int Data { get; private set; }
        public static bool Success { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine(" *** C# Tutorial ***");

            Console.WriteLine("---1) CLASSES ---");

            program.Classes.Animal animal = new program.Classes.Animal("Spot", 9);

            Console.Write("Cat[ {0} ] \n", animal.ToString());

            animal.Age = -10;
            animal.Name = "Sam";

            Console.Write("Cat[ {0} ] \n", animal.ToString());

            Console.WriteLine("---2) GENERICS ---");

            var resultPrinter = new program.Generics.ResultPrinter();

            var result1 = new program.Generics.Result<String,int>{ Success = true, Data = "John", Action= 78};
            resultPrinter.Print(result1);

            var result2 = new program.Generics.Result<int,bool> { Success = true, Data = 5, Action=true };
            resultPrinter.Print(result2);

            Console.WriteLine("---3) ATTRIBUTES ---");

            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<program.Attributes.AttributeSample>().Count() > 0
                        select t;


            foreach (var t in types)
            {
                Console.WriteLine(t.Name);

                foreach(var p in t.GetRuntimeProperties())
                {
                    Console.WriteLine(p.Name);
                }
            }

            Console.WriteLine("---4) REFLECTION ---");

            var assemblyRef = Assembly.GetCallingAssembly();
            Console.WriteLine(assemblyRef.FullName);

            var typesRef = assemblyRef.GetTypes();

            foreach (var t in types)
            {
                Console.WriteLine("Types: " + t.Name);

                var props = t.GetProperties();
                foreach( var p in props)
                {
                    Console.WriteLine("\t Property: " + p.Name + " Property Type : " + p.PropertyType);
                }

                var fields = t.GetFields();
                foreach( var f in fields)
                {
                    Console.WriteLine("\t Field: " + f.Name);
                }

                var methods = t.GetMethods();
                foreach (var m in methods)
                {
                    Console.WriteLine("\t Method: "  +m.Name);
                }
            }

            Console.WriteLine("---5) DELEGATES ---");

            program.Delegates.Square square = new program.Delegates.Square();

            // Crate an instance of the delegate, pointing to the logging function.
            // This delegate will then be passed to the Process() function.
            program.Delegates.Square.LogHandler myLogger = new program.Delegates.Square.LogHandler(Logger);
            square.Area(myLogger, 2);

            Console.WriteLine("---6) ANONYMOUS METHODS AND LAMBDA EXPRESSIONS ---");

            Operaion op1 = delegate (int num)
            {
                Console.WriteLine("{0} x 2 = {1}", num, num * 2);
            };

            op1(2);

            Action<int> op2 = delegate (int num)
            {
                Console.WriteLine("{0} x 2 = {1}", num, num * 2);
            };

            op2(2);

            Console.WriteLine("---7) EVENTS ---");

            var tower = new program.Events.ClockTower();
            var john = new program.Events.Person("John", tower);

            tower.ChimeFivePM();

            Console.WriteLine("---8) EXTENSION METHOD ---");

            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine(result);

            Console.WriteLine("---9)  LINQ ---");

            var sample = "I enjoy writing uber-software in C#";

            var resultSample = from c in sample.ToLower()
                               where c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                               select c;

            foreach( var item in resultSample)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
