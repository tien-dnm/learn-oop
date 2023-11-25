namespace VehicleLibs
{
    public class Bicycle : Vehicle
    {
        public int wheels = 4;
        public override int maxSpeed { get; } = 50;
        public Bicycle(int speed = 0)
        {
            Speed = speed;
        }
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }
}
