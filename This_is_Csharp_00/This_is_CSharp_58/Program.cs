using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex058 ex058 = new Ex058();
            ex058.Run();
        }

        public class Ex058
        {
            public void Run()
            {
                string[] weathers = new string[7];

                weathers[0] = "sunny";
                weathers[6] = "sunny";
                //weathers[7] = "new!!"; // IndexOutOfRangeException 에러발생!
            }
        }
    }
}
