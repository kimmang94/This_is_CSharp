using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex071 ex071 = new Ex071();
            ex071.Run();
        }

        public class Ex071
        {
            public void Run()
            {
                Stack<string> stk = new Stack<string>();

                Console.WriteLine("* 시작점");
                for (int idx = 1; idx < 11; idx++)
                {
                    Console.WriteLine("{0}번 선수 도착", idx);
                    stk.Push(string.Format("{0}번 선수", idx));
                }

                Console.WriteLine("====");
                Console.WriteLine("5 ~ 10 등 선수는 탈락입니다");
                for (int idx = 0; idx < 6; idx++)
                {
                    stk.Pop();
                }
                Console.WriteLine("====");

                Console.WriteLine("* 올림픽 대표선수 명단");
                foreach(object obj in stk)
                {
                    Console.WriteLine(obj.ToString());
                }
            }
        }
    }
}
