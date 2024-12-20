using System.ComponentModel.DataAnnotations;

namespace This_is_Csharp_48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex048 ex048 = new Ex048();
            ex048.Run();
        }

        public class Ex048
        {
            public void Run()
            {
                Car001 car = new Car001();
                car.setSize("세단");
                car.setColor("하얀");

                Console.WriteLine("고객님의 차, {0} {1} 이... ", car.getColor(), car.getSize());
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

            public void setSize(string size)
            {
                this.size = size;
            }

            public string getSize()
            {
                return size;
            }

            public void setColor(string color)
            {
                this.color = color;
            }

            public string getColor()
            {
                return color;
            }

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
