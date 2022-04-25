using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;


namespace Visual_Lab5
{
    public partial class Form1 : Form
    {
        private int _currentItemIndex = -1;
        private int _isFiltered = 0;
        private List<ParticipantInfo> ParticipantInfos;
        public Form1()
        {
            InitializeComponent();
            ParticipantInfos = Program.Participants;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void UpdateList()
        {
            listView1.Items.Clear();

            foreach (var Participant in ParticipantInfos)
            {
                if (!string.IsNullOrEmpty(Participant.Name) && !string.IsNullOrWhiteSpace(Participant.Name))
                {
                    listView1.Items.Add(Participant.Name);
                }
                else
                {
                    listView1.Items.Add("New Participant Info");
                }
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            var Participant = new ParticipantInfo();
            Program.Participants.Add(Participant);
            if (Program.Participants == ParticipantInfos)
            {
                listView1.Items.Add("New Participant Info");
            }
        }


        private void apply_Click(object sender, EventArgs e)
        {
            if (_currentItemIndex == -1)
            {
                return;
            }
            int itemIndex = listView1.SelectedIndices[0];
            var item = ParticipantInfos[itemIndex];
            item.Number = numberbox.Text;
            item.Country = countrybox.Text;
            item.Name = namebox.Text;
            item.TeamName = teamnamebox.Text;
            item.BirthDate = dateTimePicker1.Value;
            try
            {
                item.Height = Convert.ToInt16(heightbox.Text);
            }
            catch
            {
                item.Height = null;
            }
            try
            {
                item.Weight = Convert.ToInt16(weightbox.Text);
            }
            catch
            {
                item.Weight = null;
            }
            if (!string.IsNullOrEmpty(namebox.Text) && !string.IsNullOrWhiteSpace(namebox.Text))
            {
                listView1.SelectedItems[0].Text = namebox.Text;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (_currentItemIndex == -1)
            {
                return;
            }
            ParticipantInfos.RemoveAt(_currentItemIndex);
            if (ParticipantInfos != Program.Participants)
            {
                Program.Participants.Remove(ParticipantInfos[_currentItemIndex]);
            }
            listView1.Items.RemoveAt(_currentItemIndex);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                _currentItemIndex = -1;
                var newItem = new ParticipantInfo();
                numberbox.Text = newItem.Number;
                namebox.Text = newItem.Name;
                teamnamebox.Text = newItem.TeamName;
                countrybox.Text = newItem.Country;

                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
                dateTimePicker1.Value = DateTime.UtcNow;
                
                heightbox.Text = "";//newItem.Height;
                weightbox.Text = "";// newItem.Weight;
                apply.Enabled = false;
                delete.Enabled = false;
                return;
            }
            apply.Enabled = true;
            delete.Enabled = true;
            int itemIndex = listView1.SelectedIndices[0];
            _currentItemIndex = itemIndex;
            var item = ParticipantInfos[itemIndex];
            numberbox.Text = item.Number;
            numberbox.Text = item.Number;
            namebox.Text = item.Name;
            teamnamebox.Text = item.TeamName;
            countrybox.Text = item.Country;

            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Value = item.BirthDate;

            heightbox.Text = Convert.ToString(item.Height);
            weightbox.Text = Convert.ToString(item.Weight);
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML file|*.xml";
            saveFileDialog.Title = "Save Participants Data As XML File";
            saveFileDialog.FileName = "ParticipantsInfo.xml";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<ParticipantInfo>));
                        TextWriter textWriter = new StreamWriter(saveFileDialog.FileName);
                        serializer.Serialize(textWriter, Program.Participants);
                        textWriter.Close();
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void ValidateHandler(object? sender, ValidationEventArgs args)
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error) throw new Exception(args.Message);
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", "ParticipantsInfo1.xsd");

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML file|*.xml";
            openFileDialog.Title = "Open Participants Info";
            openFileDialog.FileName = "ParticipantsInfo.xml";

            DialogResult result = openFileDialog.ShowDialog();
            openFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && openFileDialog.FileName != "")
            {
                try
                {
                    if (openFileDialog.CheckPathExists)
                    {
                        XmlReader reader = XmlReader.Create(openFileDialog.FileName);
                        XDocument doc = XDocument.Load(reader);
                        doc.Validate(schema, ValidateHandler);

                        var serializationReader = doc.Root.CreateReader();
                        XmlSerializer serializer = new XmlSerializer(typeof(List<ParticipantInfo>));
                        TextReader textReader = new StreamReader(openFileDialog.OpenFile());
                        Program.Participants = serializer.Deserialize(serializationReader) as List<ParticipantInfo>;
                        serializationReader.Close();
                        reader.Close();
                        ParticipantInfos = Program.Participants;
                        UpdateList();
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public bool rb(System.Windows.Forms.RadioButton rbutton, int? i1, string s2)
        {
            int i2 = 0;
            if (!Int32.TryParse(s2, out i2)) return true;
            if (rbutton.Text == "<")
            {
                if (i1 < i2) return true;
                else return false;
            }
            if (rbutton.Text == ">")
            {
                if (i1 > i2) return true;
                else return false;
            }
            if (rbutton.Text == "=")
            {
                if (i1 == i2) return true;
                else return false;
            }
            return false;
        }
        public bool rbdt(System.Windows.Forms.RadioButton rbutton, DateTime i1, DateTime i2)
        {
            if (rbutton.Text == "") return true;
            if (rbutton.Text == "<")
            {
                if (i1 < i2) return true;
                else return false;
            }
            if (rbutton.Text == ">")
            {
                if (i1 > i2) return true;
                else return false;
            }
            if (rbutton.Text == "=")
            {
                if (i1 == i2) return true;
                else return false;
            }
            return false;
        }
        private void filter_Click(object sender, EventArgs e)
        {
            if (_isFiltered == 0)
            {
                var weightRB = weightPanel.Controls.OfType<RadioButton>()
                          .FirstOrDefault(r => r.Checked);
                var heightRB = heightPanel.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);
                var bdRB = bdPanel.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(r => r.Checked);
                var partlyFilteredData =
                from participant in Program.Participants
                where participant.Country.Contains(countrybox.Text) &&
                    participant.Name.Contains(namebox.Text) &&
                    participant.TeamName.Contains(teamnamebox.Text) &&
                    rb(heightRB, participant.Height, heightbox.Text) &&
                    rb(weightRB, participant.Weight, weightbox.Text) &&
                    rbdt(bdRB, participant.BirthDate, dateTimePicker1.Value) &&
                    participant.Number.Contains(numberbox.Text)
                select participant;

                ParticipantInfos = new List<ParticipantInfo>(partlyFilteredData);

                UpdateList();
                _isFiltered = 1;
            }
            else
            {
                ParticipantInfos = Program.Participants;
                UpdateList();
                _isFiltered = 0;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void heightbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void weightbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}