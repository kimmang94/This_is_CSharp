namespace This_is_Csharp_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex035 ex035 = new Ex035();
            ex035.Run();
        }

        public class Ex035
        {
            public void Run()
            {
                Console.WriteLine("숫자를 입력해주세요");
                int number = Convert.ToInt32(Console.ReadLine());

                bool isOddNumber = ((number % 2 == 1) ? true : false);

                if (number > 0 && isOddNumber)
                {
                    Console.WriteLine("{0}은 양의 홀수 입니다.", number);
                }
                else if (number > 0 && !isOddNumber)
                {
                    Console.WriteLine("{0}은 짝수입니다.", number);
                }
                else if (number < 0 && isOddNumber)
                {
                    Console.WriteLine("{0}은 음의 홀수입니다.", number);
                }
                else if (number < 0 && !isOddNumber)
                {
                    Console.WriteLine("{0}은 음의 짝수입니다.", number);
                }
                else
                {
                    Console.WriteLine("{0}은 zero 입니다", number);
                }
            }
        }
    }
}
