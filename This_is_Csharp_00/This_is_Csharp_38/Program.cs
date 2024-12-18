namespace This_is_Csharp_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex038 ex038 = new Ex038();
            ex038.Run();
        }

        public class Ex038
        {
            public void Run()
            {
                const int number = 2;
                int index = 1;

                for (; ; )
                {
                    Console.WriteLine("{0} * {1} = {2}", number, index, number * index);
                    break;
                }
            }
        }
    }
}
