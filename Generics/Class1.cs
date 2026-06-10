using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class employee
    {
        internal void Display<t,k,l>(t a,k b,l c)
        {
            Console.WriteLine("EMPLOYEE DETAILS");
            Console.WriteLine("NAME : " + a);
            Console.WriteLine("ID : " + b);
            Console.WriteLine("SALARY : " + c);
        }
        internal void show<t, K>(t l,K m)
        {
            Console.WriteLine("COMPANY DETAILS");
            Console.WriteLine("COMPANY NAME : " + l);
            Console.WriteLine("COMPANY LOCATION : " + m);
        }
    }
    internal class Class1
    {
        static void Main()
        {
            employee obj = new employee();
            obj.Display<string,int,double>("john",99,55000);
            obj.show<string,string>("microsoft","banglore");

        }
    }
}
