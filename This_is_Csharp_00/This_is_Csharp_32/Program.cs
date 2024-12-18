namespace This_is_Csharp_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int number = 0;

            if (number > 0)
            {
                Console.WriteLine("{0}은 양수입니다.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("{0}은 음수입니다.", number);
            }
            else
            {
                Console.WriteLine("{0}은 zero 입니다.", number);
            }
           
        }
    }
}
