namespace This_is_Csharp_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex047 ex047 = new Ex047();
            ex047.Run();
        }

        public class Ex047
        {
            public void Run()
            {
                Random rand = new Random();
                int target_number = rand.Next(1, 10);

                Console.WriteLine("제가 생각하고 있는 1 ~ 10 사이의 숫자를 맞춰보세요");

                int count = 0;
                bool isMathed = false;

                do
                {
                    if (Convert.ToInt32(Console.ReadLine) == target_number)
                    {
                        isMathed = true;
                        Console.WriteLine("정답입니다. 맞추기까지 {0} 번 소요되었습니다", count);
                    }
                    else
                    {
                        Console.WriteLine("틀렷어요!");
                        count++;
                    }
                } while (isMathed == false);

            }
        }
    }
}
