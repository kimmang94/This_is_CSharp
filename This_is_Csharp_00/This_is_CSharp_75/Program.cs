using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_75
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public class Ex075
        {
            public void Run()
            {
                List<string> strList = new List<string>();

                strList.Add("HI");
                Console.WriteLine(strList[0]);

                strList.Clear();
                Console.WriteLine(strList[0]);
            }
        }
    }
}
