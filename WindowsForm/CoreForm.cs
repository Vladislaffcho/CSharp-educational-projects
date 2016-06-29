using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
                AddItemsToListView(bike);
                _bikeId++;
            }
        }

        private void AddItemsToListView(Bike bike)
        {
            var item = new ListViewItem(bike.Name);
            item.SubItems.Add(bike.WheelDiameter.ToString());
            item.SubItems.Add(_bikeId.ToString());
            lvBikes.Items.Add(item);
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
                        BikeType type = (bike.typeOfBike);
                        stContent.Panel2.Controls.Clear();
                        switch (type)
                        {
                            case (BikeType.Cross):
                                stContent.Panel2.Controls.Add(new UcCross((CrossBike)bike) { Dock = DockStyle.Fill });
                                break;
                            case (BikeType.Hard):
                                stContent.Panel2.Controls.Add(new UcHard((HardBike)bike) { Dock = DockStyle.Fill });
                                break;
                            case (BikeType.HardTeil):
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
                RemoveBike rb = new RemoveBike(_bikes.Count);
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

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /* Save to .xml file */
            try
            {
                SerilizeToFile();
                MessageBox.Show("File saved", "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            /* Save to .txt file */

            /* Method 1 */
            /*string result = string.Empty;
            foreach (var bike in _bikes)
            {
                result += bike + Environment.NewLine;
            }
            File.WriteAllText(@"D:\ITacademy\C#\WindowsFormLongTerm\WindowsForm\TextFile\base.txt", result);*/



            /* Method 2 
            try
            {
                using (var st = new FileStream(@"D:\ITacademy\C#\WindowsFormLongTerm\WindowsForm\TextFile\base.txt", FileMode.OpenOrCreate))
                {
                    using (var sr = new StreamWriter(st))
                    {
                        foreach (var bike in _bikes)
                        {
                            sr.Write(bike + Environment.NewLine);
                        }
                        sr.Close();
                    }
                    st.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }*/

            /* Method 3 - Old one
             * 
             * 
             * Stream st = null;
            StreamWriter sr = null;
            try
            {
                st = new FileStream(@"D:\ITacademy\C#\WindowsFormLongTerm\WindowsForm\TextFile\base.txt",
                    FileMode.OpenOrCreate);
                sr = new StreamWriter(st);
                foreach (var bike in _bikes)
                {
                    sr.Write(bike.ToString() + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
                if (st != null)
                {
                    st.Close();
                }
            }*/

        }

        private void openSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*string filter = "Text Files|*.txt";*/
            string filter = "Xml files|*.xml";
            OpenSavedFile(filter);
        }

        private void OpenSavedFile(string filter)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = filter;
            openFile.Multiselect = false;
            openFile.InitialDirectory = Directory.GetCurrentDirectory();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                lvBikes.Items.Clear();
                _bikes.Clear();
                DeSerializeFromFile(openFile.FileName);
                /*ReadFromTxt(openFile.FileName);*/
            }
        }

        private void ReadFromTxt(string fileName)
        {
            string filetext = File.ReadAllText(fileName);
            List<string> stringBikes =
                filetext.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            _bikes.Clear();

            foreach (var stringBike in stringBikes)
            {
                var stringBikeType = stringBike.Split(';').ToList()[1];
                BikeType type;
                Enum.TryParse(stringBikeType, true, out type);
                _bikeId++;

                switch (type)
                {
                    case BikeType.Cross:
                        CrossBike bikeCross;
                        if (CrossBike.TryParce(stringBike, out bikeCross))
                        {
                            _bikes.Add(bikeCross);
                            AddItemsToListView(bikeCross);
                        }
                        break;

                    case BikeType.Hard:
                        HardBike bikeHard;
                        if (HardBike.TryParce(stringBike, out bikeHard))
                        {
                            _bikes.Add(bikeHard);
                            AddItemsToListView(bikeHard);
                        }
                        break;

                    case BikeType.HardTeil:
                        HardTeilBike bikeHardTeil;
                        if (HardTeilBike.TryParce(stringBike, out bikeHardTeil))
                        {
                            _bikes.Add(bikeHardTeil);
                            AddItemsToListView(bikeHardTeil);
                        }
                        break;
                }
            }
        }

        public void SerilizeToFile()
        {
            /*Directory. to check if directory exists */
            using (var stream = new FileStream(@"D:\ITacademy\C#\WindowsFormLongTerm\WindowsForm\TextFile\Ser.xml",
                    FileMode.OpenOrCreate))
            {
                var ser = new XmlSerializer(typeof (List<Bike>),
                    new[] {typeof (CrossBike), typeof (HardBike), typeof (HardTeilBike)});
                ser.Serialize(stream, _bikes);
            }
        }

        public void DeSerializeFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (var stream = new FileStream(@"D:\ITacademy\C#\WindowsFormLongTerm\WindowsForm\TextFile\Ser.xml",
                    FileMode.OpenOrCreate))
                {
                    var ser = new XmlSerializer(typeof(List<Bike>),
                        new[] { typeof(CrossBike), typeof(HardBike), typeof(HardTeilBike) });
                    _bikes = (List<Bike>)ser.Deserialize(stream);
                    foreach (var bike in _bikes)
                    {
                        AddItemsToListView(bike);
                        _bikeId++;
                    }
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
    }
}
