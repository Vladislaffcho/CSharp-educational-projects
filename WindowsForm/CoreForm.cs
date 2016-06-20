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
    public partial class CoreForm : Form
    {
        private int _bikeId = 1;
        private List<Bike> _bikes = new List<Bike>();
        public CoreForm()
        {
            InitializeComponent();
        }

        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBike ab = new AddBike(_bikeId);
            if (ab.ShowDialog() == DialogResult.OK) /* show dialog prints our window */
            {
                Bike bike = ab.GetCreatedBike();
                _bikes.Add(bike);
                var item = new ListViewItem(bike.Name);
                item.SubItems.Add(bike.WheelDiameter.ToString());
                item.SubItems.Add(_bikeId.ToString());
                lvBikes.Items.Add(item);
                _bikeId++;
            }
        }

        private void coreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Goodbye!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lvBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                var listViewItem = listView.SelectedItems[0];

                int id = listViewItem.SubItems[2].Text.GetInt();

                foreach (var bike in _bikes)
                {
                    if (bike.Id == id)
                    {
                        string type = (_bikes.Find(i => i.Id == id)).ToString();
                        stContent.Panel2.Controls.Clear();
                        switch (type)
                        {
                            case ("WindowsForm.CrossBike"):
                                stContent.Panel2.Controls.Add(new UcCross((CrossBike)bike) { Dock = DockStyle.Fill });
                                break;
                            case ("WindowsForm.HardBike"):
                                stContent.Panel2.Controls.Add(new UcHard((HardBike)bike) { Dock = DockStyle.Fill });
                                break;
                            case ("WindowsForm.HardTeilBike"):
                                stContent.Panel2.Controls.Add(new UcHardTeil((HardTeilBike)bike) { Dock = DockStyle.Fill });
                                break;
                        }
                        break;
                    }
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_bikes.Count > 0)
            {
                RemoveBike rb = new RemoveBike(_bikes);
                if (rb.ShowDialog() == DialogResult.OK)
                {
                    _bikes.RemoveAt(rb.IndexToRemove);
                    lvBikes.Items.RemoveAt(rb.IndexToRemove);
                    stContent.Panel2.Controls.Clear();
                }
            }
            else
            {
                MessageBox.Show("There are no recordings to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
