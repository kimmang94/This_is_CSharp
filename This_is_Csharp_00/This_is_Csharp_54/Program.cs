using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace This_is_Csharp_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex054 ex054 = new Ex054();
            ex054.Run();
        }

        public class Ex054
        {
            public void Run()
            {
                GasolineCar009 gasolineCar = new GasolineCar009();
                gasolineCar.Color = "검정";
                gasolineCar.Size = "SUV";
                ElectronicCar009 electronicCar009 = new ElectronicCar009();
                electronicCar009.Color = "초록";
                electronicCar009.Size = "경차";

                Console.WriteLine("{0}색 {1}가", gasolineCar.Color, gasolineCar.Size);
                gasolineCar.InputGas();
                Console.WriteLine("{0}색 {1}가", electronicCar009.Color, electronicCar009.Size);
                electronicCar009.InputGas();
            }
        }

        public class Car009
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

            public void Left()
            {
                Console.WriteLine("좌회전 합니다");
            }

            public void Right()
            {
                Console.WriteLine("우회전 합니다.");
            }

            public virtual void InputGas()
            {
                Console.WriteLine("기름을 넣습니다.");
            }
        }

        public class GasolineCar009 : Car009
        {
            public override void InputGas()
            {
                Console.WriteLine("휘발유를 넣습니다");
            }
        }
        public class ElectronicCar009 : Car009
        {
            public override void InputGas()
            {
                Console.WriteLine("전기를 넣습니다.");
            }
        }
    }
}
