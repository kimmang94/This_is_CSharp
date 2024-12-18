namespace This_is_Csharp_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex042 ex042 = new Ex042();
            ex042.Run();
        }

        public class Ex042
        {
            public void Run()
            {
                int fact_result = 1;

                for (int index = 5; index > 0; index--)
                {
                    fact_result *= index;
                }

                Console.WriteLine("5!은 {0} 입니다", fact_result);
            }
        }
    }
}
