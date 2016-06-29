using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WindowsForm
{
    [DataContract]
    public class HardBike : Bike
    {
        public HardBike()
        {
            
        }
        [DataMember]
        public string TireType { get; set; }
        [DataMember]
        public double Weight { get; set; }
        [DataMember]
        public HardBikeMaterial Material { get; set; }

        public HardBike(int id) : base(id)
        {
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5};{6}", Id, BikeType.Hard, Name, WheelDiameter, Weight, TireType, Material);
        }

        public static bool TryParce(string source, out HardBike result)
        {
            result = null;
            List<string> SplitString = source.Split(';').ToList();
            try
            {
                int Id = SplitString[0].GetInt();
                if (Id == -1)
                {
                    throw new Exception("Cannot parce Id");
                }
                else
                {
                    double diameter = SplitString[3].GetDouble();
                    if (diameter == -1)
                    {
                        throw new Exception("Cannot parce Wheel Diameter");
                    }
                    else
                    {
                        double bikeWeight = SplitString[4].GetDouble();
                        if (bikeWeight == -1)
                        {
                            throw new Exception("Cannot parce bike weight");
                        }

                        var HardBike = new HardBike(Id)
                        {
                            Name = SplitString[2],
                            WheelDiameter = diameter,
                            Weight = bikeWeight,
                            TireType = SplitString[5],
                            Material = (HardBikeMaterial)Enum.Parse(typeof(HardBikeMaterial), SplitString[6]),
                            typeOfBike = BikeType.Hard
                        };
                        result = HardBike;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}