using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_92
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex092 ex092 = new Ex092();
            ex092.Run();
        }

        public class Ex092
        {
            private delegate int RunCalc(int a, int b);

            public void Run()
            {
                RunCalc calc = (a,b) => a + b;
                Console.WriteLine(calc(1,2));

                calc = (a, b) => a * b;
                Console.WriteLine(calc(1,2));
            }
        }

    }
}
