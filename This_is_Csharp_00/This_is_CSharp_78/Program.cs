using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_78
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public class Ex078
        {
            public void Run()
            {
                Console.Write("숫자를 입력하세요 : ");

                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("입력된 숫자는 {0}", number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format Exception : 숫자가 아닌 값을 입력했습니다.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow Exception : 숫자의 범위를 초과했습니다.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("예측하지 못한 예외 상황 발생, 관리자에게 문의하세요");
                    Console.WriteLine("에러 코드 : {0}", e.HResult);
                    Console.WriteLine("에러 메시지 : {0}", e.Message);
                }
            }
        }
    }
}
