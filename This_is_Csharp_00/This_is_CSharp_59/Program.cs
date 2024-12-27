using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex059 ex059 = new Ex059();
            ex059.Run();
        }

        public class Ex059
        {
            public void Run()
            {
                string[] days = { "sunny", "sunny", "rainy", "cloudy", "rainy", "snow", "sunny" };

                int dayCnt = days.Length;

                int sunnyCnt = 0;
                int cloudyCnt = 0;
                int rainyCnt = 0;
                int snowCnt = 0;

                for (int idx = 0; idx < dayCnt; idx++)
                {
                    string weather = days[idx];
                    if (weather == "sunny") sunnyCnt++;
                    if (weather == "cloudy") cloudyCnt++;
                    if (weather == "rainy") rainyCnt++;
                    if (weather == "snow") snowCnt++;
                }

                Console.WriteLine("맑음 : {0} / 흐림 : {1} / 비 : {2} / 눈 : {3}", sunnyCnt, cloudyCnt, rainyCnt, snowCnt);
            }
        }
    }
}
