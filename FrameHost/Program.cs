using FileIO;
using System;
using System.IO;
using System.Windows.Forms;

namespace FrameHost
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FloppyFrame\\Settings\\";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Directory.Exists(path))
            {
                FLOPFile flop = new FLOPFile(path, "DEFAULTS");
                if (flop.FindValue("Installed") == "True")
                {
                    foreach (var arg in args)
                    {
                        if (arg.Contains(".FLOP"))
                        {
                            Application.Run(new Frame());
                        }
                        if (arg.Contains(".FLOPX"))
                        {
                            Application.Run(new GameWindow(arg));
                        }
                    }
                    Application.Run(new Frame());
                }
            }
            else { Installer.Install(); }
        }
    }
}