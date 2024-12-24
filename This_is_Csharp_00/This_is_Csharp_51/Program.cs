using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Csharp_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam051 exam051 = new Exam051();
            exam051.Run();
        }

        public class Exam051
        {
            public void Run()
            {
                Sum(1, 1);
                Sum(2, 2);
                Sum(3, 3);
            }

            private void Sum(int number01, int number02)
            {
                Console.WriteLine("{0} + {1} = {2}", number01, number02, number01 + number02);
            }
        }
    }
}
