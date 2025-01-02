using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_88
{
    internal class Ex088
    {
       public void Run()
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> tmpNumbers = new List<int>();

           // 짝수 찾기
           for (int idx = 0; idx < numbers.Length; idx++)
            {
                if (numbers[idx] % 2 == 0)
                {
                    tmpNumbers.Add(numbers[idx]);
                }
            }

           for (int idx = 0; idx < tmpNumbers.Count; idx++)
            {
                Console.WriteLine(tmpNumbers[idx]);
            }

           tmpNumbers.Clear();

            // 홀수 찾기
            tmpNumbers = numbers.Where(n => (n % 2 ) == 1).ToList();

            for (int idx = 0; idx < tmpNumbers.Count; idx++)
            {
                Console.WriteLine(tmpNumbers[idx]);
            }
        }
    }
}
