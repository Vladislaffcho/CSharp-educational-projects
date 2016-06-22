namespace WindowsForm
{
    public class HardTeilBike : Bike
    {
        public int ShockAbsorbersNumber { get; set; }
        public int SpeedNumber { get; set; }
        public bool AirPumpEquiped { get; set; }

        public HardTeilBike(int id) : base(id)
        {
        }
        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3}", Id, Name, WheelDiameter, BikeType.HardTeil);
        }
    }
}