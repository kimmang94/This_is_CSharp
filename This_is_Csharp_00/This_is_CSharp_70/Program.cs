using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex070 ex070 = new Ex070();
            ex070.Run();
        }

        public class Ex070
        {
            public void Run()
            {
                Queue<string> queue = new Queue<string>();

                for (int idx = 1; idx < 11; idx++)
                {
                    queue.Enqueue(string.Format("{0}번 승객", idx));
                }

                Console.WriteLine(" * 정류장 승객 현황");
                foreach (object obj in queue)
                {
                    Console.WriteLine(obj.ToString());
                }
                Console.WriteLine("=======================");
                Console.WriteLine("버스가 도착했습니다. (6명 승차가능)");

                for (int i = 0; i < 6; i++)
                {
                    queue.Dequeue();
                }

                Console.WriteLine("버스가 출발했습니다.");
                Console.WriteLine("=======================");

                Console.WriteLine("새로운 승객이 줄을 섭니다");
                queue.Enqueue("새로운 승객");

                Console.WriteLine("* 정류장 승객 현황");
                foreach (object obj in queue)
                {
                    Console.WriteLine(obj.ToString());
                }
                Console.WriteLine("=======================");
            }
        }
        
    }
}
