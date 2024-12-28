using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_76
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public class Ex076
        {
            public void Run()
            {
                Console.Write("숫자를 입력하세요 : ");

                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("예외 상황 발생");
                }
            }
        }
    }
}
