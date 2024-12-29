using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex081 ex081 = new Ex081();
            ex081.Run();
        }

        public class Ex081
        {
            private readonly string currentDirectory = Environment.CurrentDirectory;
            public void Run()
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"\data");
                if (!directoryInfo.Exists)
                {
                    directoryInfo.Create();
                    Console.WriteLine("디렉토리가 생성되었습니다");
                }

                Console.WriteLine("생성 경로 : {0}", directoryInfo.FullName);
            }
        }
    }
}
