using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_89
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex089 ex089 = new Ex089();
            ex089.Run();
        }

        public class Ex089
        { 
            private delegate int RunCalc(int a, int b);

            private static int Sum(int number1, int number2)
            {
                return number1 + number2;
            }

            private static int Multiply(int number1, int number2)
            {
                return number1 * number2;
            }

            public void Run()
            {
                RunCalc calc = Sum;
                Console.WriteLine(calc(1, 2));
                calc = Multiply;
                Console.WriteLine(calc(1,2));
            }
        }

    }
}
