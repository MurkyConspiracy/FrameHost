using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using FileIO;

namespace FrameHost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FloppyFrame\\Settings\\";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {

                FlopInterpritor flop = new FlopInterpritor(path, "DEFAULTS");
                if(flop.FindValue("Installed") == "True")
                {
                    
                    foreach(var arg in args)
                    {

                        if(arg.Contains(".FLOP"))
                        {

                            Application.Run(new Frame(arg));

                        }
                        if(arg.Contains(".FLOPX"))
                        {

                            Application.Run(new GameWindow(arg));

                        }

                    }

                    Application.Run(new Frame());
                    
                }

            }
            catch (Exception e)
            {
                Installer.Install();
            }


        }
    }
}
