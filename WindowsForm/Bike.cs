using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace WindowsForm
{
    [DataContract]
    public abstract class Bike
    {
        [DataMember]
        public int Id;
        [DataMember]
        public double WheelDiameter { get; set; }
        [DataMember]
        public string Name { get; set; }

        public Bike(int id)
        {
            Id = id;
        }

        public BikeType typeOfBike { get; set; }

        protected Bike()
        {
            
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