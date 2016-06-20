namespace WindowsForm
{
    public class HardBike : Bike
    {
        public string TireType { get; set; }
        public double Weight { get; set; }
        public HardBikeMaterial Material { get; set; }

        public HardBike(int id) : base(id)
        {
        }
    }
}