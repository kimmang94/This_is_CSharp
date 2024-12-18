namespace This_is_Csharp_40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex040 ex040 = new Ex040();
            ex040.Run();
        }

        public class Ex040
        {
            public void Run()
            {
                const int number = 2;

                for (int index = 1; index < 10; index++)
                {
                    Console.WriteLine("{0} * {1} = {2}", number, index, number * index);
                }
            }
        }
    }
}
