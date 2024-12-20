namespace This_is_Csharp_49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex049 ex049 = new Ex049();
            ex049.Run();
        }

        public class Ex049
        {
            public void Run()
            {
                Car001 car = new Car001();
                car.Size = "세단";
                car.Color = "하얀";

                Console.WriteLine("고객님의 차, {0} {1} 이... ", car.Color, car.Size);
                car.Engine_on();
                car.Go();
                car.Back();
                car.Left();
                car.Right();
                car.Engine_off();
            }
        }

        class Car001
        {
            private string size;
            private string color;

            public string Size
            {
                set { size = value; }
                get { return size; }
            }

            public string Color
            {
                set { color = value; }
                get { return color; }
            }

            // 간략화
            //public string Color { get; set; }
            //public string Size { get; set; }
            public void Engine_on()
            {
                Console.WriteLine("시동을 켭니다");
            }

            public void Engine_off()
            {
                Console.WriteLine("시동을 끕니다.");
            }

            public void Go()
            {
                Console.WriteLine("전진합니다");
            }

            public void Back()
            {
                Console.WriteLine("후진합니다.");
            }

            public void Left()
            {
                Console.WriteLine("좌회전 합니다.");
            }

            public void Right()
            {
                Console.WriteLine("우회전 합니다.");
            }
        }
    }
}
