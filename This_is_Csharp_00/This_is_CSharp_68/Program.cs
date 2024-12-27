using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex068 ex068 = new Ex068();
            ex068.Run();
        }

        public class Ex068
        {
            public void Run()
            {
                List<int> aList = new List<int>();

                for (int idx = 0; idx < 15; idx++)
                {
                    aList.Add(idx);
                }

                aList.Insert(5, 100);

                for (int idx = 0; idx < aList.Count; idx++)
                {
                    Console.WriteLine("Value : {0} / Type : {1}", aList[idx], aList[idx].GetType());
                }

                aList.RemoveAt(5);

                for (int idx = 0; idx < aList.Count; idx++)
                {
                    Console.WriteLine("Value : {0} / Type {1}", aList[idx], aList[idx].GetType());
                }
            }
        }
    }
}
