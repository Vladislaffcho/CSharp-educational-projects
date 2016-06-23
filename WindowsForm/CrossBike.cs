using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsForm
{
    public class CrossBike : Bike
    {
        public int Speed { get; set; }
        public CrossColor Color { get; set; }

        public CrossBike(int id) : base(id)
        {
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5}", Id, BikeType.Cross, Name, WheelDiameter, Speed, Color);
        }

        public static bool TryParce(string source, out CrossBike result)
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
                        int bikeSpeed = SplitString[4].GetInt();
                        if (bikeSpeed == -1)
                        {
                            throw new Exception("Cannot parce bike weight");
                        }

                        var HardBike = new CrossBike(Id)
                        {
                            Name = SplitString[2],
                            WheelDiameter = diameter,
                            Speed = bikeSpeed,
                            Color = (CrossColor)Enum.Parse(typeof(CrossColor), SplitString[5]),
                            typeOfBike = BikeType.Cross
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