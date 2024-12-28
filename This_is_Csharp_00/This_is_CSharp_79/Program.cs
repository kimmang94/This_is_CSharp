using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_79
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public class Ex079
        {
            public void Run()
            {
                Console.Write("숫자를 입력하세요 : ");
                int number = 0;

                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format Exception : 숫자가 아닌 값을 입력했습니다");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow Exception : 숫자 범위를 초과했습니다");
                }
                catch (Exception e)
                {
                    Console.WriteLine("예측하지 못한 예외 상황 발생, 관리자에게 문의하세요");
                    Console.WriteLine("에러 코드 : {0}", e.HResult);
                    Console.WriteLine("에러 메시지 : {0}", e.Message);
                }
                Console.WriteLine("입력된 숫자는 {0}", number);
            }
        }
    }
}
