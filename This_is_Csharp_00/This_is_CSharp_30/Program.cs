namespace This_is_CSharp_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex030 ex030 = new Ex030();
            ex030.Run();
        }

        public class Ex030
        {
            public void Run()
            {
                const int zero = 0;

                if (zero == 0)
                {
                    Console.WriteLine("첫 번째 if 문입니다");
                    Console.WriteLine("zero 는 0 이기 때문에 출력을 합니다");
                }
                else
                {
                    Console.WriteLine("첫 번째 else 문입니다");
                    Console.WriteLine("조건절에 해당하기 때문에 출력에서 제외됩니다.");
                }

                if (zero == 1)
                {
                    Console.WriteLine("두 번째 if 문입니다.");
                    Console.WriteLine("zero는 1이 아니기 때문에 출력에서 제외됩니다.");
                }
                else
                {
                    Console.WriteLine("두 번쨰 else 문입니다");
                    Console.WriteLine("조건절에 해당하지 않기 때문에 출력을 합니다");
                }

            }
        }
    }
}
