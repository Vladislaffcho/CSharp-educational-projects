using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace WindowsForm
{
    [DataContract]
    public class HardTeilBike : Bike
    {
        public HardTeilBike()
        {
            
        }
        [DataMember]
        public int ShockAbsorbersNumber { get; set; }
        [DataMember]
        public int SpeedNumber { get; set; }
        [DataMember]
        public bool AirPumpEquiped { get; set; }

        public HardTeilBike(int id) : base(id)
        {
        }
        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5};{6}", Id, BikeType.HardTeil, Name, WheelDiameter, SpeedNumber, ShockAbsorbersNumber, AirPumpEquiped);
        }

        public static bool TryParce(string source, out HardTeilBike result)
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
                        int speedNumber = SplitString[4].GetInt();
                        if (speedNumber == -1)
                        {
                            throw new Exception("Cannot parce bike speed");
                        }
                        else
                        {
                            int absorb = SplitString[5].GetInt();
                            if (absorb == -1)
                            {
                                throw new Exception("Cannot parce number of absorbers");
                            }
                            else
                            {
                                bool flag;
                                if (!Boolean.TryParse(SplitString[6], out flag))
                                {
                                    throw new Exception("Cannot parce air pump equipped");
                                }
                                var HardBike = new HardTeilBike(Id)
                                {
                                    Name = SplitString[2],
                                    WheelDiameter = diameter,
                                    SpeedNumber = speedNumber,
                                    ShockAbsorbersNumber = absorb,
                                    AirPumpEquiped = flag,
                                    typeOfBike = BikeType.HardTeil
                                };
                                result = HardBike;
                                return true;
                            }
                        }
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