using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_77
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public class Ex077
        {
            public void Run()
            {
                Console.Write("숫자를 입력하세요 : ");

                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("입력된 숫자는 {0}", number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("예외 상황 발생, 관리자에게 문의하세요");
                    Console.WriteLine("에러 코드 : {0}", ex.HResult);
                    Console.WriteLine("에러 메시지 : {0}", ex.Message);
                }
            }
        }
    }
}
