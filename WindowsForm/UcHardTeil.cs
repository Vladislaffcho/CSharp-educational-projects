using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class UcHardTeil : UserControl
    {
        private readonly int Id;

        public UcHardTeil(int bikeId)
        {
            InitializeComponent();
            Id = bikeId;
        }

        public UcHardTeil(HardTeilBike bike)
        {
            InitializeComponent();
            tbWheelDiameter.Text = bike.WheelDiameter.ToString();
            tbName.Text = bike.Name;
            tbAbsorbers.Text = bike.ShockAbsorbersNumber.ToString();
            tbSpeedNo.Text = bike.SpeedNumber.ToString();
            cbWithAirPump.Checked = bike.AirPumpEquiped;
            this.Enabled = false;
        }

        public HardTeilBike GetHardTeilBike()
        {
            HardTeilBike hrdTailBike = new HardTeilBike(Id);
            hrdTailBike.typeOfBike = BikeType.HardTeil;
            hrdTailBike.Name = tbName.Text;
            hrdTailBike.WheelDiameter = tbWheelDiameter.Text.GetDouble();
            hrdTailBike.ShockAbsorbersNumber = tbAbsorbers.Text.GetInt();
            hrdTailBike.SpeedNumber = tbSpeedNo.Text.GetInt();
            if (cbWithAirPump.Checked)
            {
                hrdTailBike.AirPumpEquiped = true;
            }
            else
            {
                hrdTailBike.AirPumpEquiped = false;
            }
            return hrdTailBike;
        }


        public bool ValidateControls()
        {
            if (tbName.Text.Trim() == String.Empty)
            {
                return false;
            }
            if (tbWheelDiameter.Text.GetDouble() <= 0)
            {
                return false;
            }
            if (tbAbsorbers.Text.GetInt() <= 0)
            {
                return false;
            }
            if (tbSpeedNo.Text.GetInt() <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
