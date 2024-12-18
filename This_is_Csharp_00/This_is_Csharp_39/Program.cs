namespace This_is_Csharp_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex039 ex039 = new Ex039();
            ex039.Run();
        }
        
        public class Ex039
        {
            public void Run()
            {
                const int number = 2;

                for (int index = 1; ;)
                {
                    Console.WriteLine("{0} * {1} = {2} ", number, index, number * index);

                    if (index == 9)
                    {
                        break;
                    }

                    index = index + 1;
                }
            }
        }
    }
}
