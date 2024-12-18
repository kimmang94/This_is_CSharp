namespace This_is_Csharp_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex034 ex034 = new Ex034();
            ex034.Run();
        }
        public class Ex034
        {
            public void Run()
            {
                Console.WriteLine("숫자를 입력하세요");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine("{0}은 양수입니다", number);

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("{0}은 짝수입니다", number);
                    }
                    else
                    {
                        Console.WriteLine("{0}은 홀수입니다", number);
                    }
                }
                else if (number < 0)
                {
                    Console.WriteLine("{0}은 음수입니다.", number);

                    if (number % 2 == 0)
                    {
                        Console.WriteLine("{0}은 짝수입니다", number);
                    }
                    else
                    {
                        Console.WriteLine("{0}은 홀수입니다", number);
                    }
                }
                else
                {
                    Console.WriteLine("{0} 은 zero 입니다.", number);
                    Console.WriteLine("{0}은 짝수입니다.", number);
                }
            }
        }
    }
}
