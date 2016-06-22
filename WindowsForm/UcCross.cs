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
    public partial class UcCross : UserControl
    {
        private readonly int Id;
        public UcCross(int bikeId)
        {
            InitializeComponent();
            cbColor.Items.Add(CrossColor.Red);
            cbColor.Items.Add(CrossColor.Green);
            cbColor.Items.Add(CrossColor.Blue);
            Id = bikeId;
        }

        public UcCross(CrossBike bike)
        {
            InitializeComponent();
            tbWheelDiameter.Text = bike.WheelDiameter.ToString();
            tbName.Text = bike.Name;
            tbSpeedCount.Text = bike.Speed.ToString();
            cbColor.Items.Add(bike.Color);
            cbColor.SelectedIndex = 0;
            this.Enabled = false;
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
            if (tbSpeedCount.Text.GetInt() <= 0)
            {
                return false;
            }
            if (cbColor.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        public CrossBike GetCross()
        {
            CrossBike mnBike = new CrossBike(Id);
            mnBike.typeOfBike = BikeType.Cross;
            mnBike.Name = tbName.Text;
            mnBike.WheelDiameter = tbWheelDiameter.Text.GetDouble();
            mnBike.Speed = tbSpeedCount.Text.GetInt();

            CrossColor type = (CrossColor)Enum.Parse(
                typeof(CrossColor),
                cbColor.SelectedItem.ToString()
                );

            switch (type)
            {
                case CrossColor.Red:
                    mnBike.Color = CrossColor.Red;
                    break;

                case CrossColor.Green:
                    mnBike.Color = CrossColor.Green;
                    break;

                case CrossColor.Blue:
                    mnBike.Color = CrossColor.Red;
                    break;
                default:
                    mnBike.Color = CrossColor.Red;
                    break;
            }
            return mnBike;
        }
    }
}
