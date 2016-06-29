using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class AddBike : Form
    {
        private UcCross ucCross;
        private UcHard ucHard;
        private UcHardTeil ucHardTeil;
        public AddBike(int bikeId)
        {
            InitializeComponent();
            ucCross = new UcCross(bikeId);
            ucHard = new UcHard(bikeId);
            ucHardTeil = new UcHardTeil(bikeId);

            cbBikeType.Items.Add(BikeType.Cross);
            cbBikeType.Items.Add(BikeType.Hard);
            cbBikeType.Items.Add(BikeType.HardTeil);
            cbBikeType.SelectedIndex = 0;
        }
        

        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = GetSelectedBikeType();

            switch (type)
            {
                case BikeType.Cross:
                    panelContent.Controls.Clear();
                    panelContent.Controls.Add(ucCross);
                    break;

                case BikeType.Hard:
                    panelContent.Controls.Clear();
                    panelContent.Controls.Add(ucHard);
                    break;

                case BikeType.HardTeil:
                    panelContent.Controls.Clear();
                    panelContent.Controls.Add(ucHardTeil);
                    break;
            }
        }
        
        public Bike GetCreatedBike()
        {
            var type = GetSelectedBikeType();

            switch (type)
            {
                case BikeType.Cross:
                    return ucCross.GetCross();

                case BikeType.Hard:
                    return ucHard.GetHardBike();

                 case BikeType.HardTeil:
                     return ucHardTeil.GetHardTeilBike();

                default:
                    return null;
            }
        }

        private BikeType GetSelectedBikeType()
        {
            BikeType type = (BikeType)Enum.Parse(
                typeof(BikeType),
                cbBikeType.SelectedItem.ToString()
                );
            return type;
        }

        private bool ValidateControls()
        {
            var type = GetSelectedBikeType();
            switch (type)
            {
                case BikeType.Cross:
                    return ucCross.ValidateControls();
                case BikeType.Hard:
                    return ucHard.ValidateControls();
                case BikeType.HardTeil:
                    return ucHardTeil.ValidateControls();
                default:
                    return true; /* return false, change validation */
            }
        }

        private void AddBike_FormClosing(object sender, FormClosingEventArgs e)
        {
            var eventSource = (Form)sender;
            if (eventSource.DialogResult != DialogResult.Cancel)
            {
                if (!ValidateControls())
                {
                    MessageBox.Show("Please input correct value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }
    }
}
