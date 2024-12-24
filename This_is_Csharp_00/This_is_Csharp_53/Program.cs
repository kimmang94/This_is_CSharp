using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Csharp_53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex053 ex053 = new Ex053();
            ex053.Run();
        }
        public class Ex053
        {
            public void Run()
            {
                GasolineCar008 gasolineCar = new GasolineCar008();
                gasolineCar.Color = "검정";
                gasolineCar.Size = "SUV";
                EletronicCar008 eletronicCar008 = new EletronicCar008();
                eletronicCar008.Color = "초록";
                eletronicCar008.Size = "경차";

                Console.WriteLine("{0}색 {1}가", gasolineCar.Color, gasolineCar.Size);
                gasolineCar.Go();
                Console.WriteLine("{0}색 {1}가", eletronicCar008.Color, eletronicCar008.Size);
                eletronicCar008.Left();
            }
        }

        public class Car008
        {
            public string Color { get; set; }
            public string Size { get; set; }

            public void Engine_on()
            {
                Console.WriteLine("시동을 켭니다");
            }

            public void Engine_off()
            {
                Console.WriteLine("시동을 끕니다");
            }

            public void Go()
            {
                Console.WriteLine("전진합니다");
            }

            public void Back()
            {
                Console.WriteLine("후진 합니다.");
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

        public class GasolineCar008 : Car008 { }
        public class EletronicCar008 : Car008 {}
    }
}
