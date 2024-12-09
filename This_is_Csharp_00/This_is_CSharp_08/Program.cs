namespace This_is_CSharp_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 오버플로
            uint a = uint.MaxValue;

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
        }
    }
}
