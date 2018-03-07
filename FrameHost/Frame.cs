using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FileIO;
using Microsoft.Win32;

namespace FrameHost
{
    public partial class Frame : Form
    {
        private string InstallPath, Binaries, Settings;
        private string ProgressTick;

        public Frame(string path)
        {
            InitializeComponent();

            InstallPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FloppyFrame";
            Binaries = InstallPath + "\\Binaries";
            Settings = InstallPath + "\\Settings";

            HotBar.Size = new Size(HotBar.Size.Width, Screen.PrimaryScreen.Bounds.Height / 28);

            FlopInterpritor flop = new FlopInterpritor(path);            
        }
        public Frame()
        {
            InitializeComponent();

            InstallPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FloppyFrame";
            Binaries = InstallPath + "\\Binaries";
            Settings = InstallPath + "\\Settings";

            HotBar.Size = new Size(HotBar.Size.Width, Screen.PrimaryScreen.Bounds.Height / 28);
            LeftPane.Location = new Point(HotBar.Height / 2, HotBar.Height + (HotBar.Height /2));
            LeftPane.Size = new Size((Screen.PrimaryScreen.Bounds.Width / 2) - HotBar.Height, Screen.PrimaryScreen.Bounds.Height - HotBar.Height * 2);

            RightPane.Location = new Point((Screen.PrimaryScreen.Bounds.Width /2) + (HotBar.Height / 3), HotBar.Height + (HotBar.Height / 2));
            RightPane.Size = new Size((Screen.PrimaryScreen.Bounds.Width / 2) - HotBar.Height, Screen.PrimaryScreen.Bounds.Height - HotBar.Height * 2);

        }

        private void ExitSystemButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
            if(file.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    if ((fileStream = file.OpenFile()) != null)
                    {
                        this.TopMost = false;
                        if(Path.GetExtension(file.FileName).ToLower() == ".Flop".ToLower())
                        {
                            LeftPane.Visible = true;
                            RightPane.Visible = true;
                            FlopInterpritor floppy = new FlopInterpritor(file.FileName);
                            string[,] values = floppy.GetAllValues();

                            for(int i = 0; i < values.GetLength(0); i++)
                            {
                                KeyBox.Items.Add(values[i, 0]);
                            }
                            for (int i = 0; i < values.GetLength(0); i++)
                            {
                                ValueBox.Items.Add(values[i, 1]);
                            }

                        }
                        if (Path.GetExtension(file.FileName).ToLower() == ".Flopx".ToLower())
                        {

                            MessageBox.Show("FLOPX");

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk.\n\r Original error: " + ex.Message);
                }

            }

        }

        private void Frame_Paint(object sender, PaintEventArgs e)
        {
            e.Dispose();
        }

    }
}
