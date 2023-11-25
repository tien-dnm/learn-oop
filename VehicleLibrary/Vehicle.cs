namespace VehicleLibs
{
    public abstract class Vehicle
    {
        private int speed;
        public virtual int maxSpeed { get; }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > maxSpeed)
                {
                    speed = maxSpeed;
                }
                else
                {
                    speed = value;
                }

            }
        }
        public virtual void Go()
        {

        }
    }

}