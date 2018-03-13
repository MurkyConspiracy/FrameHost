using FileIO;
using System;
using System.IO;
using System.Windows.Forms;

namespace FrameHost
{
    internal class Installer
    {
        private static string InstallPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FloppyFrame\\";
        private static string Binaries = InstallPath + "\\Binaries\\";
        private static string Settings = InstallPath + "\\Settings\\";
        private static FLOPFile flopInterpritor;

        public static bool Install()
        {
            try
            {
                Directory.CreateDirectory(InstallPath);
                Directory.CreateDirectory(Binaries);
                Directory.CreateDirectory(Settings);
                File.Copy(System.Reflection.Assembly.GetExecutingAssembly().Location, Binaries + "\\FloppyFrame.exe");
                File.Copy(System.Reflection.Assembly.Load("FileIO").Location, Binaries + "\\FileIO.dll");
                FLOPFile.CreateFlop(Settings, "DEFAULTS", "Installed", "False");
            }
            catch (Exception e)
            { MessageBox.Show(e.ToString()); }

            flopInterpritor = new FLOPFile(Settings, "DEFAULTS");
            flopInterpritor.ChangeValue("Installed", "True");

            MessageBox.Show("FloppyFrame has been succesfully installed!");

            if (MessageBox.Show("Associate .FLOP and .FLOPX with FloppyFrame?", "File Icons", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            }

            return true;
        }
    }
}