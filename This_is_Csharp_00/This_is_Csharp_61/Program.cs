using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Csharp_61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex061 ex061 = new Ex061();
            ex061.Run();
        }

        public class Ex061
        {
            public void Run()
            {
                ArrayList aList = new ArrayList();

                for (int idx = 0; idx < 10; idx++)
                {
                    aList.Add(idx);
                }

                for (int idx = 10; idx < 15; idx++)
                {
                    aList.Add(idx.ToString());
                }

                for (int idx = 0; idx < aList.Count; idx++)
                {
                    Console.WriteLine("Value : {0} / Type : {1}", aList[idx], aList[idx].GetType());
                }
            }
        }
    }
}
