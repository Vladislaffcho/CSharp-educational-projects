using System;

namespace WindowsForm
{
    public class CrossBike : Bike
    {
        public int Speed { get; set; }
        public CrossColor Color { get; set; }

        public CrossBike(int id) : base(id)
        {
        }


        /*private int speedCount;
        private CrossColor _cbColor;

        public CrossBike(int id) : base(id)
        {
        }

        public void GetSpeed(string speed)
        {
            int i;
            bool isDouble = int.TryParse(speed, out i);
            if (!isDouble)
            {
                speedCount = 0;
            }
            else
            {
                speedCount = i;
            }
        }

        public int Speed => speedCount;

        public CrossColor Color
        {
            set { _cbColor = value; }
        }*/
    }
}