using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_74
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public class Ex074
        {
            public void Run()
            {
                Console.WriteLine("숫자를 입력하세요 : ");
                int number = Convert.ToInt32(Console.ReadLine());
                // input value : "one"

                Console.WriteLine("입력된 숫자는 {0}", number);
            }
        }
    }
}
