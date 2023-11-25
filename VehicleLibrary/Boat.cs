
namespace VehicleLibs
{
    public class Boat : Vehicle
    {
        public int wheels = 0;
        public override int MaxSpeed { get; } = 100;
        public Boat(int speed = 0)
        {

            Speed = speed;
        }
        public override void Go()
        {
            Console.WriteLine("The boat is moving");
        }
    }
}
