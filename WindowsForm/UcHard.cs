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
    public partial class UcHard : UserControl
    {

        private readonly int Id;
        public UcHard(int bikeId)
        {
            InitializeComponent();
            cbMaterial.Items.Add(HardBikeMaterial.Carbon);
            cbMaterial.Items.Add(HardBikeMaterial.Aluminium);
            cbMaterial.Items.Add(HardBikeMaterial.Wood);
            Id = bikeId;
        }

        public UcHard(HardBike bike)
        {
            InitializeComponent();
            tbWheelDiameter.Text = bike.WheelDiameter.ToString();
            tbName.Text = bike.Name;
            tbWeight.Text = bike.Weight.ToString();
            tbTireType.Text = bike.TireType;
            cbMaterial.Items.Add(bike.Material);
            cbMaterial.SelectedIndex = 0;
            this.Enabled = false;
        }

        public HardBike GetHardBike()
        {
            HardBike hrdBike = new HardBike(Id);
            hrdBike.Name = tbName.Text;
            hrdBike.WheelDiameter = tbWheelDiameter.Text.GetDouble();
            hrdBike.Weight = tbWeight.Text.GetDouble();
            hrdBike.TireType = tbTireType.Text;

            HardBikeMaterial type = (HardBikeMaterial)Enum.Parse(
                typeof(HardBikeMaterial),
                cbMaterial.SelectedItem.ToString()
                );

            switch (type)
            {
                case HardBikeMaterial.Carbon:
                    hrdBike.Material = HardBikeMaterial.Carbon;
                    break;

                case HardBikeMaterial.Aluminium:
                    hrdBike.Material = HardBikeMaterial.Aluminium;
                    break;

                case HardBikeMaterial.Wood:
                    hrdBike.Material = HardBikeMaterial.Wood;
                    break;
                default:
                    hrdBike.Material = HardBikeMaterial.Wood;
                    break;
            }
            return hrdBike;
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
            if (tbWeight.Text.GetDouble() <= 0)
            {
                return false;
            }
            if (tbTireType.Text.Trim() == String.Empty)
            {
                return false;
            }
            if (cbMaterial.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
    }
}
