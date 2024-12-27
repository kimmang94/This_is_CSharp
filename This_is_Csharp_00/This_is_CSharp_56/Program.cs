using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex056 ex056 = new Ex056();
            ex056.Run();
        }

        public class Ex056
        {
            public void Run()
            {
                string weather = "sunny,sunny,rainy,cloudy,rainy,snow,sunny";


                var weathers = weather.Split(',');
                Console.WriteLine(weather.GetType());
                Console.WriteLine(weathers.GetType());
            }
        }
    }
}
