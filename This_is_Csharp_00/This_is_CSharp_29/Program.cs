using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int zero = 0;

            if (zero == 0)
                Console.WriteLine("첫 번째 if문 입니다.");

            if (zero == 0)
            {
                Console.WriteLine("두 번째 if 문입니다");
                Console.WriteLine("zero 는 0 이기 때문에 출력을 합니다.");
            }

            if (zero == 1)
                Console.WriteLine("세 번째 if 문입니다");
                Console.WriteLine("zero는 1이 아니기 때문에 출력에서 제외됩니다");
        }
    }
}
