using System;
using System.Windows.Forms;

namespace WindowsForm
{
    public abstract class Bike
    {
        public readonly int Id;
        public double WheelDiameter { get; set; }
        public string Name { get; set; }

        public Bike(int id)
        {
            Id = id;
        }
        
        /*public readonly int Id;
        private double _wheelDiameter;
        public string Name { get; set; }

        public Bike(int id)
        {
            Id = id;
        }

        public void GetDiameter(string diameter)
        {
            _wheelDiameter = diameter.GetDouble();   
        }
        
        public double WheelDiameter => _wheelDiameter;*/
    }
}