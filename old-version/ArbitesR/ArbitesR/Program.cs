﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ArbitesR
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
            MdGlobals.mainForm = new FmMain();
            Application.Run(MdGlobals.mainForm);
        }
    }
}
