using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shop = new Shop();

            shop.Construct(new ScooterBuilder());
            shop.ShowVehicle();

            shop.Construct(new CarBuilder());
            shop.ShowVehicle();

            shop.Construct(new MotorCycleBuilder());
            shop.ShowVehicle();

            Console.ReadKey();
        }
    }
}
