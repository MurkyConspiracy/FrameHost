using FileIO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FrameHost
{
    public partial class Frame : Form
    {
        private string InstallPath, Binaries, Settings;
        private string ProgressTick;
        private FLOPFile WorkingFLOP;
        private string[,] Values;
        private bool SkipOpen;

        public Frame()
        {
            InitializeComponent();

            InstallPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FloppyFrame";
            Binaries = InstallPath + "\\Binaries";
            Settings = InstallPath + "\\Settings";

            HotBar.Size = new Size(HotBar.Size.Width, Screen.PrimaryScreen.Bounds.Height / 28);
            LeftPane.Location = new Point(HotBar.Height / 2, HotBar.Height + (HotBar.Height / 2));
            LeftPane.Size = new Size((Screen.PrimaryScreen.Bounds.Width / 2) - HotBar.Height, Screen.PrimaryScreen.Bounds.Height - HotBar.Height * 2);

            RightPane.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) + (HotBar.Height / 3), HotBar.Height + (HotBar.Height / 2));
            RightPane.Size = new Size((Screen.PrimaryScreen.Bounds.Width / 2) - HotBar.Height, Screen.PrimaryScreen.Bounds.Height - HotBar.Height * 2);
        }

        private void ExitSystemButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WorkingFLOP != null)
            {
                DialogResult saveOrExit = MessageBox.Show("Would you like to save before closing?", "Save " + WorkingFLOP.GetName(), MessageBoxButtons.YesNoCancel);
                if (saveOrExit == DialogResult.Cancel)
                    return;
                if (saveOrExit == DialogResult.Yes)
                    saveToolStripMenuItem_Click(sender, e);

                clearFlop();
            }
        }

        private void clearFlop()
        {
            WorkingFLOP = null;
            LeftPane.Visible = false;
            RightPane.Visible = false;

            KeyBox.Items.Clear();
            ValueBox.Items.Clear();
        }

        private void ValueBox_DoubleClick(object sender, EventArgs e)
        {
            if (ValueBox.SelectedItem != null)
            {
                string newValue = Microsoft.VisualBasic.Interaction.InputBox("Enter the new value for " + KeyBox.SelectedItem.ToString(), "New Value");
                if (newValue != "")
                {
                    int TempDex = ValueBox.SelectedIndex;
                    ValueBox.Items.RemoveAt(TempDex);
                    ValueBox.Items.Insert(TempDex, newValue);
                }
            }
        }

        private void ValueBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyBox.SelectedIndex = ValueBox.SelectedIndex;
        }

        private void KeyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueBox.SelectedIndex = KeyBox.SelectedIndex;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WorkingFLOP != null)
            {
                Values = new string[KeyBox.Items.Count, 2];
                for (int i = 0; i < KeyBox.Items.Count; i++)
                {
                    Values[i, 1] = KeyBox.Items[i].ToString();
                    Values[i, 0] = ValueBox.Items[i].ToString();
                }
                WorkingFLOP.saveFlop(Values);
            }
            else
            {
                MessageBox.Show("No .FLOP Open!");
            }
        }

        private void AddKeyToolButton_Click(object sender, EventArgs e)
        {
            string KEY = Microsoft.VisualBasic.Interaction.InputBox("Enter a new Key:", "New Key");
            KeyBox.Items.Add(KEY);
            string VALUE = Microsoft.VisualBasic.Interaction.InputBox("Enter a value for the new key " + KEY + ":", "Value for " + KEY);
            ValueBox.Items.Add(VALUE);
        }

        private void ValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValueBox_DoubleClick(sender, e);
            }
        }

        private void KeyBox_DoubleClick(object sender, EventArgs e)
        {
            if (KeyBox.SelectedItem != null)
            {
                if (MessageBox.Show("Editing Key names can make games unplayable!\nDo not edit these if you are unsure what you are doing!\nDo you want to continue?", "Edit a Key?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string newKey = Microsoft.VisualBasic.Interaction.InputBox("Enter a new name for \"" + KeyBox.SelectedIndex.ToString() + "\"", "New Key name");
                    if (newKey != "")
                    {
                        int TempDex = KeyBox.SelectedIndex;
                        KeyBox.Items.RemoveAt(TempDex);
                        KeyBox.Items.Insert(TempDex, newKey);
                    }
                }
            }
        }

        private void deleteKeyToolButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteDialog = MessageBox.Show("Warning, you are deleting the current key!\nAre you sure you want to permanintly delete \"" + KeyBox.SelectedItem.ToString() + "\"", "Delete Key!?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (deleteDialog == DialogResult.Yes)
            {
                int currentSelect = KeyBox.SelectedIndex;
                KeyBox.Items.RemoveAt(currentSelect);
                ValueBox.Items.RemoveAt(currentSelect);
            }
        }

        private void KeyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                KeyBox_DoubleClick(sender, e);
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            if (WorkingFLOP != null)
            {
                DialogResult saveOrExit = MessageBox.Show("Would you like to save before creating a new file?", "Save " + WorkingFLOP.GetName(), MessageBoxButtons.YesNoCancel);
                if (saveOrExit == DialogResult.Cancel)
                    return;
                if (saveOrExit == DialogResult.Yes)
                    saveToolStripMenuItem_Click(sender, e);

                clearFlop();
            }

            SaveFileDialog newFile = new SaveFileDialog();
            newFile.InitialDirectory = InstallPath;
            newFile.SupportMultiDottedExtensions = false;
            newFile.Filter = "Flop File (*.FLOP)|*.FLOP|Flopx File (*.FLOPX)|*.FLOPX";
            newFile.AddExtension = false;
            newFile.FilterIndex = 1;
            newFile.RestoreDirectory = true;

            if (newFile.ShowDialog() == DialogResult.OK)
            {
                WorkingFLOP = FLOPFile.CreateFlop(newFile.FileName);
                SkipOpen = true;
                openToolStripMenuItem_Click(sender, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = InstallPath;
            file.AddExtension = true;
            file.SupportMultiDottedExtensions = true;
            file.Filter = "Flop Files (*.FLOP)|*.FLOP|Flopx Files (*.FLOPX)|*.FLOPX";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;

            if (WorkingFLOP != null && !SkipOpen)
            {
                DialogResult saveOrExit = MessageBox.Show("Would you like to save before opening a new file?", "Save " + WorkingFLOP.GetName(), MessageBoxButtons.YesNoCancel);
                if (saveOrExit == DialogResult.Cancel)
                    return;
                if (saveOrExit == DialogResult.Yes)
                    saveToolStripMenuItem_Click(sender, e);

                clearFlop();
            }

            if (SkipOpen || file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (SkipOpen || (fileStream = file.OpenFile()) != null)
                    {
                        this.TopMost = false;
                        if (SkipOpen || Path.GetExtension(file.FileName).ToLower() == ".Flop".ToLower())
                        {
                            LeftPane.Visible = true;
                            RightPane.Visible = true;
                            EditFLOPStrip.Visible = true;
                            if (SkipOpen)
                            {
                                file.FileName = WorkingFLOP.GetPath();
                                fileStream = WorkingFLOP.OpenFile();
                                SkipOpen = false;
                            }
                            WorkingFLOP = new FLOPFile(file.FileName);
                            Values = WorkingFLOP.GetAllValues();

                            for (int i = 0; i < Values.GetLength(0); i++)
                            { KeyBox.Items.Add(Values[i, 1]); }
                            for (int i = 0; i < Values.GetLength(0); i++)
                            { ValueBox.Items.Add(Values[i, 0]); }
                        }
                        if (Path.GetExtension(file.FileName).ToLower() == ".Flopx".ToLower())
                        {

                            ExecuteFLOPX(file.FileName);

                        }
                        fileStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk.\n\r Original error:\r\n" + ex.Message);
                }
            }
        }

        private void ExecuteFLOPX(string fileName)
        {
            throw new NotImplementedException();
        }

        private void Frame_Paint(object sender, PaintEventArgs e)
        {
            e.Dispose();
        }
    }
}