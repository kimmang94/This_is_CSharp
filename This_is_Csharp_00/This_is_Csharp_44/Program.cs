namespace This_is_Csharp_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex044 ex044 = new Ex044();
            ex044.Run();
        }

        public class Ex044
        {
            public void Run()
            {
                for (int index_i = 2; index_i < 10; index_i++)
                {
                    Console.WriteLine("{0} 단 시작", index_i);
                    for (int index_j = 1; index_j < 10; index_j++)
                    {
                        Console.WriteLine("{0} * {1} = {2},", index_i, index_j, index_i * index_j);
                    }
                }
            }
        }
    }
}
