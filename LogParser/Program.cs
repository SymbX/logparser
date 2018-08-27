using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LogParser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files|*.txt";
                ofd.FilterIndex = 0;
                if (ofd.ShowDialog() == DialogResult.OK)
                    Application.Run(new BeginForm(ofd.FileName));
            }
            else {
                Application.Run(new BeginForm(args[0]));
            }
        }
    }
}
