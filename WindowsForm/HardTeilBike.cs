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
    }
}