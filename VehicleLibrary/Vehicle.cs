namespace VehicleLibs
{
    public abstract class Vehicle
    {
        private int speed;
        public virtual int MaxSpeed
        {
            get
            {
                // bắt buộc phải khai báo maxSpeed khi tạo class kế thừa
                throw new NotImplementedException();
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > MaxSpeed)
                {
                    speed = MaxSpeed;
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