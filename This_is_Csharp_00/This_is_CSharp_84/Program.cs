using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_CSharp_84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex084 ex084 = new Ex084();
            ex084.Run();
        }

        public class Ex084
        {
            private readonly string currentDirectory = Environment.CurrentDirectory;
            private readonly string connectionStr = string.Format("Data Source = {0},{1};Initial Catalog={2};User ID={3};Password={4}", "127.0.0.1", 9008, "testdb", "sa", "1234");

            public void Run()
            {
                CheckedDirectory();
                TryConnectToDatabase();
            }

            private void CheckedDirectory()
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory + @"\data");

                if (!directoryInfo.Exists) { directoryInfo.Create(); }
            }

            private void TryConnectToDatabase()
            {
                SqlConnection connection = new SqlConnection(connectionStr);
                string fileName = string.Format(@"\data\db{0}.log", DateTime.Now.ToString("yyyyMMddHHmmss"));

                using (StreamWriter sw = new StreamWriter(currentDirectory + fileName, true))
                {
                    sw.WriteLine("[{0}] 데이터 베이스 연결 시도 ...", DateTime.Now);
                    connection.Open();
                    sw.WriteLine("[{0}] 데이터베이스 연결 OK...", DateTime.Now);
                    sw.WriteLine("[{0}] 데이터베이스 연결 끊기 시도...", DateTime.Now);
                    connection.Close();
                    sw.WriteLine("[{0} 데이터베이스 연결 끊기 OK...]", DateTime.Now);
                }
            }
        }
    }
}
