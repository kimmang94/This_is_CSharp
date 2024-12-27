using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex064 ex063 = new Ex064();
            ex063.Run();
        }

        public class Ex064
        {
            public void Run()
            {
                Queue que = new Queue();

                for (int idx = 1; idx < 11; idx++)
                {
                    que.Enqueue(String.Format("{0}번 승객", idx));
                }

                Console.WriteLine("* 정류장 승객 현황");

                foreach(object obj in que)
                {
                    Console.WriteLine(obj.ToString());
                }
                Console.WriteLine("================================");
                Console.WriteLine("버스가 도착했습니다. (6명 승차가능)");

                for (int i = 0; i < 6; i++)
                {
                    que.Dequeue();
                }

                Console.WriteLine("버스가 출발하였습니다");
                Console.WriteLine("================================");

                Console.WriteLine("새로운 승객이 줄을 섭니다");
                que.Enqueue("새로운 승객");

                Console.WriteLine("* 정류장 승객 현황");
                foreach(object obj in que)
                {
                    Console.WriteLine(obj.ToString());
                }
                Console.WriteLine("================================");
            }
        }
    }
}
