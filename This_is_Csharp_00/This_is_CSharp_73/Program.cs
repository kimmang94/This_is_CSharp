using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_73
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        
        public class Ex073
        {
            public void Run()
            {
                Console.WriteLine("숫자를 입력 하세요 : ");

                int number = Convert.ToInt32(Console.ReadLine());
                // input value : "one"

                Console.WriteLine("입력 된 숫자는 {0}", number);
            }
        }
    }
}
