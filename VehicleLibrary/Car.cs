
namespace VehicleLibs
{
    public class Car : Vehicle
    {
        public int wheels = 4;
        public override int maxSpeed { get; } = 500;
        public Car(int speed = 0)
        {
            Speed = speed;
        }
        public override void Go()
        {
            Console.WriteLine("The car is moving");
        }
    }
}
