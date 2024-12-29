namespace This_is_CSharp_83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex083 ex083 = new Ex083();
            ex083.Run();
        }

        public class Ex083
        {
            private readonly string currentDirectory = Environment.CurrentDirectory;
            public void Run()
            {
                FileInfo fileInfo = new FileInfo(currentDirectory + @"\data\log.txt");

                Console.WriteLine("저장 경로 : {0}", fileInfo.DirectoryName);
                Console.WriteLine("파일명 : {0}", fileInfo.Name);

                Console.WriteLine("=== 파일 내용 ===");
                using (StreamReader sr = new StreamReader(fileInfo.FullName))
                {
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
