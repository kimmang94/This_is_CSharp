using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex082 ex082 = new Ex082();
            ex082.Run();
        }

        public class Ex082
        {
            private readonly string currentDirectory = Environment.CurrentDirectory;
            public void Run()
            {

                using (StreamWriter sw = new StreamWriter(currentDirectory + @"\data\log.txt", true))
                {
                    sw.WriteLine("프로그램 실행 시간 : {0}", DateTime.Now);
                }
            }
        }
    }
}
