using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Ejemplo);
            t.Start("Z");

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("A");
            }

            
            Console.Read();
        }

    

        public static void Ejemplo(object o)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(o);
            }
        }
    }
}
