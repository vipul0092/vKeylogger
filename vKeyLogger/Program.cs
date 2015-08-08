using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace vKeyLogger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 app = new Form1();
            Application.Run(app);
        }
    }
}
