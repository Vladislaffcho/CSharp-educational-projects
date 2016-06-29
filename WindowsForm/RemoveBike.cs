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
    public partial class RemoveBike : Form
    {

        private int _bikeIndex;
        private int _lBikesCount;
        public RemoveBike(int count)
        {
            InitializeComponent();
            _lBikesCount = count;
        }

        private void RemoveBike_FormClosing(object sender, FormClosingEventArgs e)
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

        private bool ValidateControls()
        {

            if (numUpDnRemove.Value < 1 ||
                numUpDnRemove.Value > _lBikesCount)
            {
                return false;
            }
            _bikeIndex = (int)numUpDnRemove.Value;
            return true;
        }

        public int IndexToRemove => _bikeIndex - 1;
    }
}
