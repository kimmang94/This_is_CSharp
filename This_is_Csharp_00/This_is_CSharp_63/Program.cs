using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EX063 ex063 = new EX063();
            ex063.Run();
        }

        public class EX063
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

                aList.Insert(5, "100");

                for (int idx = 0; idx < aList.Count; idx++)
                {
                    Console.WriteLine("Value : {0} / Type : {1}", aList[idx], aList[idx].GetType());
                }
            }
        }
    }
}
