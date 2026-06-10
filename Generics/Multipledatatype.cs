//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Generics
//{
//    class newclass
//    {
//        internal void show<t,k>(t a, k b)
//        {
//            Console.WriteLine("value of a is : " + a);
//            Console.WriteLine("value of b is : " + b);
//        }
//        internal void display<t,k>(t a, k b)
//        {
//            Console.WriteLine("value of a is : " + a);
//            Console.WriteLine("value of b is : " + b);
//        }
//    }
//    internal class Multipledatatype
//    {
//        static void Main()
//        {
//            newclass n = new newclass();
//            n.show<int, string>(10, "hi");
//            n.show<double, bool>(5.6, true);
//            n.display<string, char>("bye", 'z');
//            n.display<float, long>(6.545f, 987654321765);
//        }
//    }
//}
