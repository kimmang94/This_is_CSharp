using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Csharp_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex052 ex052 = new Ex052();
            ex052.Run();
        }

        public class Ex052
        {
            public void Run()
            {
                int number01 = 10;
                int number02 = 3;

                dynamic result01 = Sum(number01, number02);
                dynamic result02 = Minus(number01, number02);
                dynamic result03 = Multiple(number01, number02);
                dynamic result04 = Divede(number01, number02);

                Console.WriteLine("{0}과 {1}의 사칙연산 결과값 : {1}, {2}, {3}, {4}, {5}",
                    number01,
                    number02,
                    result01,
                    result02,
                    result03,
                    result04);

            }

            private int Sum(int number01, int number02)
            {
                return number01 + number02;
            }
            private int Minus(int number01, int number02)
            {
                return number01 - number02;
            }
            private int Multiple(int number01, int number02)
            {
                return number01 * number02;
            }
            private double Divede(int number01, int number02)
            {
                return (double)number01 / number02;
            }
        }
    }
}
