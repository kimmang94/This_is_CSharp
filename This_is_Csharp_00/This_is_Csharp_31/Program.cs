namespace This_is_Csharp_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex031 ex031 = new Ex031();
            ex031.Run();
        }


        public class Ex031
        {
            public void Run()
            {
                const int zero = 0;

                if (zero == 0)
                {
                    Console.WriteLine("첫 번째 if 문입니다");
                    Console.WriteLine("zero 는 0이기 때문에 출력을 합니다");
                }

                if (zero != 0)
                {
                    Console.WriteLine("첫 번째 else 문 입니다");
                    Console.WriteLine("조건절에 해당하지 않기 때문에 출력에서 제외됩니다.");
                }

                if (zero == 1)
                {
                    Console.WriteLine("두 번째 if 문입니다.");
                    Console.WriteLine("zero 는 1이 아니기 때문에 출력에서 제외됩니다.");
                }

                if (zero != 1)
                {
                    Console.WriteLine("두 번째 else 문입니다.");
                    Console.WriteLine("조건절에 해당하지 않기 때문에 출력을 합니다.");
                }
            }
        }
    }
}
