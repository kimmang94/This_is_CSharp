﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex080 ex080 = new Ex080();
            ex080.Run();
        }

        public class Ex080
        {
            public void Run()
            {
                Console.Write("숫자를 입력 하세요 : ");

                int number = -1;
                bool isException = false;

                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Format Exception : 숫자가 아닌 값을 입력 했습니다.");
                    isException = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow Exception : 숫자의 범위를 초과했습니다.");
                    isException = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("예측하지 못한 예외 상황 발생, 관리자에게 문의하세요");
                    Console.WriteLine("에러 코드 : {0}", e.HResult);
                    Console.WriteLine("에러 메시지 : {0}", e.Message);

                    isException = true;
                }
                finally
                {
                    if (isException)
                    {
                        number = 0;
                    }
                }

                Console.WriteLine("입력 된 숫자는 {0}", number);
            }
        }
    }
}
